using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    public class VersenyMenet
    {
        private List<Verseny> versenyek;

        public VersenyMenet()
        {
            versenyek = new List<Verseny>();
        }

        // Verseny hozzáadása
        public void VersenyHozzaadasa(Verseny verseny)
        {
            versenyek.Add(verseny);
        }

        // Versenyek listázása
        public void VersenyekListazasa()
        {
            Console.WriteLine("Versenyek listája:");
            foreach (var v in versenyek)
            {
                Console.WriteLine($"Név: {v.Nev}, Kategória: {v.Kategoria}, Max. indulók: {v.MaxIndulo}, Indulók száma: {v.Indulok.Count}");
            }
        }

        // Verseny eredmények kiírása (egyszerűsített, csak indulókat írja ki)
        public void VersenyEredmenyekKiirasa()
        {
            foreach (var v in versenyek)
            {
                Console.WriteLine($"\nVerseny: {v.Nev} ({v.Kategoria})");
                Console.WriteLine("Indulók:");
                foreach (var indulo in v.Indulok)
                {
                    Console.WriteLine($"- {indulo.Nev}");
                }
            }
        }
    }
}