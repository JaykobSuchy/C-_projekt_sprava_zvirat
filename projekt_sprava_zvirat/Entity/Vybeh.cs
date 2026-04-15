using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_sprava_zvirat.Entity
{
    public class Vybeh
    {
        public int Id { get; set; }

        static int pocetId = 1;
        public string Nazev {  get; set; }

        public int kapacita { get; set; }

        public int pocetZvirat { get; set; }


        public Vybeh(string nazev, int kapacita)
        {
            Id = pocetId++;
            Nazev = nazev;
            this.kapacita = kapacita;
            this.pocetZvirat = 0;
        }

        public override string ToString()
        {
            return $"Výběh: {Id} {Nazev}({pocetZvirat}/{kapacita})";
        }

        public string VypsaniUZvirete()
        {
            return $"Výběh:{Nazev}";
        }

        public static void SynchronizaceId(int id)
        {
            pocetId = id;
        }
    }
}
