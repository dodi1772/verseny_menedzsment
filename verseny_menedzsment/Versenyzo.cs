﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny_menedzsment
{
    public class Versenyzo
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Nem { get; set; }
        public List<Eredmeny> Eredmenyek=new List<Eredmeny>();

        public Versenyzo(string nev, int kor, string nem)
        {
            Nev = nev;
            Kor = kor;
            Nem = nem;
        }
        public void EredmenyEmber()
        {
            Console.WriteLine($"Résztvevő neve: {Nev}\nRésztvevő neme: {Nem}\nVerseny neve: {Eredmenyek[0].VersenyNev}\nIdő: {Eredmenyek[0].Ido}\nHelyezés: {Eredmenyek[0].Helyezes}\n");
        }
    }
}
