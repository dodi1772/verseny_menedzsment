using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    internal class Eredmeny
    {
        public string VersenyNev { get; set; }
        public TimeSpan Ido { get; set; }
        public int Helyezes { get; set; }

        public Eredmeny(string versenyNev, TimeSpan ido, int helyezes)
        {
            VersenyNev = versenyNev;
            Ido = ido;
            Helyezes = helyezes;
        }
    }
}
