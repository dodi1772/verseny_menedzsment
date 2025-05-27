namespace verseny_menedzsment
{
    class Program
    {
        static void Main(string[] args)
        {
            // VersenyMenet példány létrehozása
            VersenyMenet menet = new VersenyMenet();

            // Versenyek létrehozása
            Futas futas = new Futas("Futó1", 3);
            Uszas uszas = new Uszas("Úszó2", 2);
            Kerekpar kerekpar = new Kerekpar("Bicikli3", 2);
            Versenyzo v1 = new Versenyzo("Talpas Bélané", 20, "Nő");
            Versenyzo v2 = new Versenyzo("Bocskor Feri", 25, "Férfi");
            Versenyzo v3 = new Versenyzo("Csimicsanga Csabi", 22, "Férfi");
            Versenyzo v4 = new Versenyzo("Légy Kreatív Mari", 19, "Nő");
            v1.Eredmenyek.Add(new Eredmeny ("Bicikli3",TimeSpan.FromSeconds(12.3),1 ));
            v2.Eredmenyek.Add(new Eredmeny ("Futó1",TimeSpan.FromSeconds(13.1),2 ));
            v3.Eredmenyek.Add(new Eredmeny ("Futó1",TimeSpan.FromSeconds(14.0),3 ));
            v4.Eredmenyek.Add(new Eredmeny ("Úszó2",TimeSpan.FromSeconds(2.1),1));
            futas.HozzaadVersenyzo(v1);
            futas.HozzaadVersenyzo(v2);
            futas.HozzaadVersenyzo(v3);
            uszas.HozzaadVersenyzo(v1);
            uszas.HozzaadVersenyzo(v4);
            kerekpar.HozzaadVersenyzo(v2);
            kerekpar.HozzaadVersenyzo(v3);
            menet.VersenyHozzaadasa(futas);
            menet.VersenyHozzaadasa(uszas);
            menet.VersenyHozzaadasa(kerekpar);
            menet.VersenyekListazasa();
            futas.KiirUtasitas();
            uszas.KiirUtasitas();
            kerekpar.KiirUtasitas();
            menet.VersenyEredmenyekKiirasa();

        }
    }
}
