using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_sprava_zvirat.Entity
{
    public class Krmeni
    {
        public int Id { get; set; }

        static int pocetId = 1;

        public string Jidlo { get; set; }

        public string Mnozstvi { get; set; }

        public int ZvireId { get; set; }

        public string jmenoZvire { get; set; }

        public Krmeni(string jidlo, string mnozstvi, int Zvireid, string jmenoZvire)
        {
            Id = pocetId++;
            Jidlo = jidlo;
            Mnozstvi = mnozstvi;
            ZvireId = Zvireid;
            this.jmenoZvire = jmenoZvire;
        }
        public override string ToString()
        {
            return $"ID {Id}: {Jidlo} {Mnozstvi} / {ZvireId}: {jmenoZvire}";
        }
        public static void SynchronizaceId(int id)
        {
            pocetId = id;
        }
    }
}

