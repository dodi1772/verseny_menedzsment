using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    public class Futas : Verseny
    {
        public Futas(string nev, int maxIndulo)
            : base(nev, "futás", maxIndulo)
        {
        }

        public void KiirUtasitas()
        {
            Console.WriteLine($"A versenyzők 5 km futással kezdik a(z) {Nev} versenyt.");
        }
    }
}
