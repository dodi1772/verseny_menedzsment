using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    public class Kerekpar : Verseny
    {
        public Kerekpar(string nev, int maxIndulo)
            : base(nev, "kerékpár", maxIndulo)
        {
        }

        public void KiirUtasitas()
        {
            Console.WriteLine($"A versenyzők 10 km kerékpározással kezdik a(z) {Nev} versenyt.");
        }
    }
}
