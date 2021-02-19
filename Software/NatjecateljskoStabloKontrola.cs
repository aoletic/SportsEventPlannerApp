using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using Org.BouncyCastle.Asn1.Cmp;
using Google.Protobuf.WellKnownTypes;
using System.Linq.Expressions;

namespace SportsEventPlanner
{
    public partial class NatjecateljskoStabloKontrola : UserControl
    {
        private Utakmica novautakmica = null;
        //sakrivanje gumbova za CRUD rezultata te za kreiranje stabla ako korisnik nije admin ili organizator
        public NatjecateljskoStabloKontrola()
        {
            InitializeComponent();
            if(PrijavaForma.uloga > 2)
            {
                btnDodajRezultat.Hide();
                btnIzbrisiRezultat.Hide();
                btnPromijeniRezultat.Hide();
                btnKreiranjeStabla.Hide();
            }
        }

        public NatjecateljskoStabloKontrola(Utakmica utakmica)
        {
            novautakmica = utakmica;
        }

        //osvjezavanje prikaza utakmica u datagridu
        private void OsvjeziUtakmice()
        {
            Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
            dgvUtakmice.DataSource = UtakmiceRepozitorij.DohvatiUtakmice(dogadaj.IdDogadaj);


            List<Tim> listatimova = TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);
            int broj = 0;
            foreach (Tim tim in listatimova)
            {
                if (tim.pobjedio == "da")
                {
                    broj++;
                }
            }

            if (broj == 1)
            {
                btnKreiranjeStabla.Hide();
            }
            else
            {
                btnKreiranjeStabla.Show();
            }
            dgvUtakmice.Columns[3].Visible = false;

            int bezrez = 0;
            List<Utakmica> listautakmica = UtakmiceRepozitorij.DohvatiUtakmice(dogadaj.IdDogadaj);
            foreach (Utakmica utakmica in listautakmica)
            {
                if (utakmica.brojPoenaTim1 == "-" || utakmica.brojPoenaTim2 == "-")
                {
                    bezrez++;
                }
            }
            if (bezrez > 0)
            {
                btnKreiranjeStabla.Hide();
            }
            else
            {
                if (broj != 1)
                {
                    btnKreiranjeStabla.Show();
                }
            }

        }



        // klikom na gumb, otvara se forma za unos rezultata
        private void btnDodajRezultat_Click(object sender, EventArgs e)
        {

            if (dgvUtakmice.SelectedRows.Count > 0)
            {
                Utakmica odabranaUtakmica = dgvUtakmice.CurrentRow.DataBoundItem as Utakmica;
                unosRezultataForma unosRezultata = new unosRezultataForma(odabranaUtakmica);
                unosRezultata.ShowDialog();



                OsvjeziUtakmice();
            }
        }

        // klikom na gumb, otvara se forma za promjenu rezultata

        private void btnPromijeniRezultat_Click(object sender, EventArgs e)
        {

            if (dgvUtakmice.SelectedRows.Count > 0)
            {
                Utakmica odabranaUtakmica = dgvUtakmice.CurrentRow.DataBoundItem as Utakmica;
                unosRezultataForma unosRezultata = new unosRezultataForma(odabranaUtakmica);
                unosRezultata.ShowDialog();
                OsvjeziUtakmice();
            }
        }

        private void NatjecateljskoStabloKontrola_Load(object sender, EventArgs e)
        {
            cmbOdabirDogadaja.DataSource = DogadajiRepozitorij.DohvatiDogadaje();
            OsvjeziUtakmice();
        }

        //klikom na gumb za kreiranje stabla, ako već stablo ne postoji, timovi iz oznacenog dogadaja se ucitavaju u listu te se randomly kreiraju parovi za utakmice
        private void btnKreiranjeStabla_Click(object sender, EventArgs e)
        {

            if (dgvUtakmice.Rows.Count == 0)
            {
                Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
                if (PrijavaForma.prijavljeniKorisnik.ulogaKorisnika_iduloga > 1)
                {
                    if (dogadaj.idKorisnik == PrijavaForma.prijavljeniKorisnik.idKorisnik)
                    {

                        List<Tim> listatimova = TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);
                        int i = 0;

                        int broj = 0;
                        foreach (Tim tim in listatimova)
                        {
                            broj++;
                        }

                        int[] polje = new int[broj];


                        var randombrojevi = new int[broj];
                        for (int x = 0; x < broj; x++)
                        {
                            randombrojevi[x] = x;
                        }

                        Random r = new Random();
                        for (int k = randombrojevi.Length - 1; k > 0; --k)
                        {
                            int l = r.Next(k + 1);
                            int temp = randombrojevi[k];
                            randombrojevi[k] = randombrojevi[l];
                            randombrojevi[l] = temp;
                        }



                        foreach (Tim tim in listatimova)
                        {
                            polje[i] = tim.idTim;
                            i++;
                        }
                        try
                        {
                            for (int m = 0; m <broj; m += 2)
                            {
                                novautakmica = new Utakmica();
                                novautakmica.korisnikId = PrijavaForma.prijavljeniKorisnik.idKorisnik;
                                novautakmica.dogadajId = dogadaj.IdDogadaj;
                                novautakmica.idTima1 = polje[randombrojevi[m]];
                                novautakmica.idTima2 = polje[randombrojevi[m + 1]];
                                UtakmiceRepozitorij.DodajUtakmicu(novautakmica);

                            }

                            OsvjeziUtakmice();
                        }
                        catch
                        {
                            MessageBox.Show("Nema timova u događaju!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ne možete kreirati stablo za odabrani događaj, niste njegov organizator!");
                    }
                }
                else
                {

                    List<Tim> listatimova = TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);
                    int i = 0;

                    int broj = 0;
                    foreach (Tim tim in listatimova)
                    {
                        broj++;
                    }

                    int[] polje = new int[broj];


                    var randombrojevi = new int[broj];
                    for (int x = 0; x < broj; x++)
                    {
                        randombrojevi[x] = x;
                    }

                    Random r = new Random();
                    for (int k = randombrojevi.Length - 1; k > 0; --k)
                    {
                        int l = r.Next(k + 1);
                        int temp = randombrojevi[k];
                        randombrojevi[k] = randombrojevi[l];
                        randombrojevi[l] = temp;
                    }



                    foreach (Tim tim in listatimova)
                    {
                        polje[i] = tim.idTim;
                        i++;
                    }
                    try
                    {
                        for (int m = 0; m < broj; m += 2)
                    {
                        novautakmica = new Utakmica();
                        novautakmica.korisnikId = PrijavaForma.prijavljeniKorisnik.idKorisnik;
                        novautakmica.dogadajId = dogadaj.IdDogadaj;
                        novautakmica.idTima1 = polje[randombrojevi[m]];
                        novautakmica.idTima2 = polje[randombrojevi[m + 1]];
                        UtakmiceRepozitorij.DodajUtakmicu(novautakmica);

                    }
                    OsvjeziUtakmice();
                    }
                    catch
                    {
                        MessageBox.Show("Nema timova u događaju!");
                    }
                }

            }

      
    
                //ako stablo već postoji, traže se pobjednici iz utakmica, pobjednike stavlja u novu listu te sa njima kreiraju nove utakmice
                else
                {
                    Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
                if (PrijavaForma.prijavljeniKorisnik.ulogaKorisnika_iduloga > 1)
                {
                    if (dogadaj.idKorisnik == PrijavaForma.prijavljeniKorisnik.idKorisnik)
                    {

                        List<Tim> listatimova = TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);

                        int i = 0;

                        int broj = 0;
                        foreach (Tim tim in listatimova)
                        {
                            if (tim.pobjedio == "da")
                            {
                                broj++;
                            }
                        }

                        int[] polje = new int[broj];


                        var randombrojevi = new int[broj];
                        for (int x = 0; x < broj; x++)
                        {
                            randombrojevi[x] = x;
                        }

                        Random r = new Random();
                        for (int k = randombrojevi.Length - 1; k > 0; --k)
                        {
                            int l = r.Next(k + 1);
                            int temp = randombrojevi[k];
                            randombrojevi[k] = randombrojevi[l];
                            randombrojevi[l] = temp;
                        }



                        foreach (Tim tim in listatimova)
                        {
                            if (tim.pobjedio == "da")
                            {
                                polje[i] = tim.idTim;
                                i++;
                            }
                        }

                        try
                        {
                            for (int m = 0; m < broj; m += 2)
                            {

                                novautakmica = new Utakmica();
                                novautakmica.korisnikId = PrijavaForma.prijavljeniKorisnik.idKorisnik;
                                novautakmica.dogadajId = dogadaj.IdDogadaj;
                                novautakmica.idTima1 = polje[randombrojevi[m]];
                                if (m + 1 >= broj)
                                {
                                    novautakmica.idTima2 = 0;
                                }
                                else
                                {
                                    novautakmica.idTima2 = polje[randombrojevi[m + 1]];
                                }

                                UtakmiceRepozitorij.DodajUtakmicu(novautakmica);

                            }
                            OsvjeziUtakmice();
                        }
                        catch
                        {
                            MessageBox.Show("Nema timova u događaju!");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Ne možete kreirati stablo za odabrani događaj, niste njegov organizator!");
                    }


                }
                else
                {

                    List<Tim> listatimova = TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);

                    int i = 0;

                    int broj = 0;
                    foreach (Tim tim in listatimova)
                    {
                        if (tim.pobjedio == "da")
                        {
                            broj++;
                        }
                    }

                    int[] polje = new int[broj];


                    var randombrojevi = new int[broj];
                    for (int x = 0; x < broj; x++)
                    {
                        randombrojevi[x] = x;
                    }

                    Random r = new Random();
                    for (int k = randombrojevi.Length - 1; k > 0; --k)
                    {
                        int l = r.Next(k + 1);
                        int temp = randombrojevi[k];
                        randombrojevi[k] = randombrojevi[l];
                        randombrojevi[l] = temp;
                    }



                    foreach (Tim tim in listatimova)
                    {
                        if (tim.pobjedio == "da")
                        {
                            polje[i] = tim.idTim;
                            i++;
                        }
                    }
                    try
                    {
                        for (int m = 0; m < broj; m += 2)
                        {

                            novautakmica = new Utakmica();
                            novautakmica.korisnikId = PrijavaForma.prijavljeniKorisnik.idKorisnik;
                            novautakmica.dogadajId = dogadaj.IdDogadaj;
                            novautakmica.idTima1 = polje[randombrojevi[m]];
                            if (m + 1 >= broj)
                            {
                                novautakmica.idTima2 = 0;
                            }
                            else
                            {
                                novautakmica.idTima2 = polje[randombrojevi[m + 1]];
                            }

                            UtakmiceRepozitorij.DodajUtakmicu(novautakmica);

                        }
                        OsvjeziUtakmice();
                }
                        catch
                {
                    MessageBox.Show("Nema timova u događaju!");
                }

            }

            }
           
           
        }
        //odabir dogadaja u comboboxu
        private void cmbOdabirDogadaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
            dgvUtakmice.DataSource = UtakmiceRepozitorij.DohvatiUtakmice(dogadaj.IdDogadaj);

            if(PrijavaForma.uloga !=1)
            {
                
                btnDodajRezultat.Hide();
                btnIzbrisiRezultat.Hide();
                btnPromijeniRezultat.Hide();

                if(PrijavaForma.prijavljeniKorisnik.idKorisnik == dogadaj.idKorisnik)
                {
                    btnDodajRezultat.Show();
                    btnIzbrisiRezultat.Show();
                    btnPromijeniRezultat.Show();
                }

            }
            else
            {
                btnDodajRezultat.Show();
                btnIzbrisiRezultat.Show();
                btnPromijeniRezultat.Show();
            }
            OsvjeziUtakmice();

        }

        //brisanje rezultata
        private void btnIzbrisiRezultat_Click(object sender, EventArgs e)
        {
            if (dgvUtakmice.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUtakmice.SelectedRows)
                {
                    Utakmica odabranaUtakmica = row.DataBoundItem as Utakmica;
                    UtakmiceRepozitorij.ObrisiRezultat(odabranaUtakmica);
                }
            }
            OsvjeziUtakmice();
        }

        private void cmbOdabirDogadaja_MouseClick(object sender, MouseEventArgs e)
        {
            cmbOdabirDogadaja.DataSource = DogadajiRepozitorij.DohvatiDogadaje();
        }

        private void btnIzbrisiRezultat_Click_1(object sender, EventArgs e)
        {
            if (dgvUtakmice.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUtakmice.SelectedRows)
                {
                    Utakmica odabranaUtakmica = row.DataBoundItem as Utakmica;
                    UtakmiceRepozitorij.ObrisiRezultat(odabranaUtakmica);
                }
            }
            OsvjeziUtakmice();

        }
    }
}
