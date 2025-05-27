using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    public class Uszas : Verseny
    {
        public Uszas(string nev, int maxIndulo)
            : base(nev, "úszás", maxIndulo)
        {
        }

        public void KiirUtasitas()
        {
            Console.WriteLine($"A versenyzők 2 km úszással kezdik a(z) {Nev} versenyt.");
        }
    }
}
