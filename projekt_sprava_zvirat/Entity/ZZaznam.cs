using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt_sprava_zvirat.Entity
{
    public class ZZaznam
    {
        public int Id { get; set; }

        static int pocetId = 1;

        public string Nazev { get; set; }

        public string Diagnoza { get; set; }

        public int ZvireId { get; set; }

        public string jmenoZvire { get; set; }

        public ZZaznam(string nazev, string diagnoza, int Zvireid, string jmenoZvire)
        {
            Id = pocetId++;
            Nazev = nazev;
            Diagnoza = diagnoza;
            ZvireId = Zvireid;
            this.jmenoZvire = jmenoZvire;
        }
        public override string ToString()
        {
            return $"ID {Id}: {Nazev}--{ZvireId}: {jmenoZvire}";
        }
        public static void SynchronizaceId(int id)
        {
            pocetId = id;
        }
    }
}
