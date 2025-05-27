using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace verseny_menedzsment
    {
        public class Verseny
        {
            public string Nev { get; set; }
            public string Kategoria { get; set; }
            public int MaxIndulo { get; set; }

            public List<Versenyzo> Indulok = new List<Versenyzo>();

            public Verseny(string nev, string kategoria, int maxIndulo)
            {
                Nev = nev;
                Kategoria = kategoria;
                MaxIndulo = maxIndulo;
            }

            public bool HozzaadVersenyzo(Versenyzo v)
            {
                if (Indulok.Count >= MaxIndulo)
                {
                    return false;
                }
                Indulok.Add(v);
                return true;
            }
            public void LeggyorsabbVersenyzo()
            {
                string nev = "";
                TimeSpan legjobbido = TimeSpan.MaxValue;
                foreach (var versenyzo in Indulok)
                {
                    foreach (var eredmeny in versenyzo.Eredmenyek)
                    {
                        if (eredmeny.VersenyNev == this.Nev && eredmeny.Ido < legjobbido)
                        {
                            legjobbido = eredmeny.Ido;
                            nev = versenyzo.Nev;
                        }
                    }
                }
                if (nev != "")
                {
                    Console.WriteLine($"A leggyorsabb volt a(z) {Nev} versenyen: {nev} ({legjobbido})");
                }
                else
                {
                    Console.WriteLine("Nincs eredmény");
                }
            }
    }
    }
