using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportovi
{
    public partial class Sport
    {
        public int IdSport { get; set; }
        public string NazivSport { get; set; }
        public int BrojClanovaTim { get; set; }


        public Sport()
        {

        }

        public override string ToString()
        {
            return NazivSport;
        }
    }
}
