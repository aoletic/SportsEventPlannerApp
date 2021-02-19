namespace SportsEventPlanner
{
    partial class NatjecateljskoStabloKontrola
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKreiranjeStabla = new System.Windows.Forms.Button();
            this.lblOdabirDogadaja = new System.Windows.Forms.Label();
            this.cmbOdabirDogadaja = new System.Windows.Forms.ComboBox();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.btnDodajRezultat = new System.Windows.Forms.Button();
            this.btnPromijeniRezultat = new System.Windows.Forms.Button();
            this.btnIzbrisiRezultat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 102);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "NATJECATELJSKO STABLO";
            // 
            // btnKreiranjeStabla
            // 
            this.btnKreiranjeStabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnKreiranjeStabla.ForeColor = System.Drawing.Color.White;
            this.btnKreiranjeStabla.Location = new System.Drawing.Point(485, 183);
            this.btnKreiranjeStabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKreiranjeStabla.Name = "btnKreiranjeStabla";
            this.btnKreiranjeStabla.Size = new System.Drawing.Size(253, 42);
            this.btnKreiranjeStabla.TabIndex = 3;
            this.btnKreiranjeStabla.Text = "Kreiranje natjecateljskog stabla";
            this.btnKreiranjeStabla.UseVisualStyleBackColor = false;
            this.btnKreiranjeStabla.Click += new System.EventHandler(this.btnKreiranjeStabla_Click);
            // 
            // lblOdabirDogadaja
            // 
            this.lblOdabirDogadaja.AutoSize = true;
            this.lblOdabirDogadaja.Location = new System.Drawing.Point(27, 197);
            this.lblOdabirDogadaja.Name = "lblOdabirDogadaja";
            this.lblOdabirDogadaja.Size = new System.Drawing.Size(114, 17);
            this.lblOdabirDogadaja.TabIndex = 8;
            this.lblOdabirDogadaja.Text = "Odaberi događaj";
            // 
            // cmbOdabirDogadaja
            // 
            this.cmbOdabirDogadaja.FormattingEnabled = true;
            this.cmbOdabirDogadaja.Location = new System.Drawing.Point(147, 193);
            this.cmbOdabirDogadaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOdabirDogadaja.Name = "cmbOdabirDogadaja";
            this.cmbOdabirDogadaja.Size = new System.Drawing.Size(235, 24);
            this.cmbOdabirDogadaja.TabIndex = 9;
            this.cmbOdabirDogadaja.SelectedIndexChanged += new System.EventHandler(this.cmbOdabirDogadaja_SelectedIndexChanged);
            this.cmbOdabirDogadaja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbOdabirDogadaja_MouseClick);
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUtakmice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtakmice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUtakmice.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUtakmice.EnableHeadersVisualStyles = false;
            this.dgvUtakmice.Location = new System.Drawing.Point(147, 244);
            this.dgvUtakmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvUtakmice.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUtakmice.RowTemplate.Height = 24;
            this.dgvUtakmice.Size = new System.Drawing.Size(921, 268);
            this.dgvUtakmice.TabIndex = 10;
            // 
            // btnDodajRezultat
            // 
            this.btnDodajRezultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnDodajRezultat.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezultat.Location = new System.Drawing.Point(147, 594);
            this.btnDodajRezultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajRezultat.Name = "btnDodajRezultat";
            this.btnDodajRezultat.Size = new System.Drawing.Size(192, 42);
            this.btnDodajRezultat.TabIndex = 11;
            this.btnDodajRezultat.Text = "Dodaj rezultat";
            this.btnDodajRezultat.UseVisualStyleBackColor = false;
            this.btnDodajRezultat.Click += new System.EventHandler(this.btnDodajRezultat_Click);
            // 
            // btnPromijeniRezultat
            // 
            this.btnPromijeniRezultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnPromijeniRezultat.ForeColor = System.Drawing.Color.White;
            this.btnPromijeniRezultat.Location = new System.Drawing.Point(473, 594);
            this.btnPromijeniRezultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromijeniRezultat.Name = "btnPromijeniRezultat";
            this.btnPromijeniRezultat.Size = new System.Drawing.Size(192, 42);
            this.btnPromijeniRezultat.TabIndex = 12;
            this.btnPromijeniRezultat.Text = "Promijeni rezultat";
            this.btnPromijeniRezultat.UseVisualStyleBackColor = false;
            this.btnPromijeniRezultat.Click += new System.EventHandler(this.btnPromijeniRezultat_Click);
            // 
            // btnIzbrisiRezultat
            // 
            this.btnIzbrisiRezultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(202)))));
            this.btnIzbrisiRezultat.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiRezultat.Location = new System.Drawing.Point(876, 594);
            this.btnIzbrisiRezultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzbrisiRezultat.Name = "btnIzbrisiRezultat";
            this.btnIzbrisiRezultat.Size = new System.Drawing.Size(192, 42);
            this.btnIzbrisiRezultat.TabIndex = 13;
            this.btnIzbrisiRezultat.Text = "Izbriši rezultat";
            this.btnIzbrisiRezultat.UseVisualStyleBackColor = false;
            this.btnIzbrisiRezultat.Click += new System.EventHandler(this.btnIzbrisiRezultat_Click_1);
            // 
            // NatjecateljskoStabloKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzbrisiRezultat);
            this.Controls.Add(this.btnPromijeniRezultat);
            this.Controls.Add(this.btnDodajRezultat);
            this.Controls.Add(this.dgvUtakmice);
            this.Controls.Add(this.cmbOdabirDogadaja);
            this.Controls.Add(this.lblOdabirDogadaja);
            this.Controls.Add(this.btnKreiranjeStabla);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NatjecateljskoStabloKontrola";
            this.Size = new System.Drawing.Size(1201, 689);
            this.Load += new System.EventHandler(this.NatjecateljskoStabloKontrola_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreiranjeStabla;
        private System.Windows.Forms.Label lblOdabirDogadaja;
        private System.Windows.Forms.ComboBox cmbOdabirDogadaja;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Button btnDodajRezultat;
        private System.Windows.Forms.Button btnPromijeniRezultat;
        private System.Windows.Forms.Button btnIzbrisiRezultat;
    }
}
