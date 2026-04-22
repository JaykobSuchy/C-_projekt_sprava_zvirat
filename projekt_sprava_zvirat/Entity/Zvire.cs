using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_sprava_zvirat.Entity
{
    public class Zvire
    {
        public int Id { get; set; }

        static int pocetId = 1;

        public string Jmeno { get; set; }

        public string Druh { get; set; }

        public string VybehNazev { get; set; }

        public Zvire(string jmeno, string druh, string vybehNazev) {
            Id = pocetId++;
            Jmeno = jmeno;
            Druh = druh;
            VybehNazev = vybehNazev;
        }

        public override string ToString()
        {
            return $"{Id}: {Jmeno} {Druh}/{VybehNazev}";
        }

        public static void SynchronizaceId(int id)
        {
            pocetId = id;
        }
    }
}
