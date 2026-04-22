using projekt_sprava_zvirat.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace projekt_sprava_zvirat.Logika
{
    public class ZvireLogika
    {
        private List<Zvire> zvirata;
        //private VybehLogika vybehLogika; 

        public ZvireLogika()
        {
            zvirata = new List<Zvire>();
            //vybehLogika = new VybehLogika();
        }

        public void PridejZvire(Zvire zvire)
        {
            //if (vybehLogika.testKapacity(vybehLogika.NajdiVybeh(zvire.VybehNazev)))
            //{
            //    return;
            //}
            zvirata.Add(zvire);
            //vybehLogika.NajdiVybeh(zvire.VybehNazev).pocetZvirat++;
            //zvire.Vybeh.pocetZvirat++;
        }

        public void SmazatZvire(Zvire zvire)
        {
            zvirata.Remove(zvire);
        }

        public void SmazatZvirataPV(Vybeh vybeh)
        {
            zvirata.RemoveAll(z => z.VybehNazev.Equals(vybeh.Nazev));
        }

        public List<Zvire> VratZvirata()
        {
            return zvirata;
        }

        public List<Zvire> VyhledejZvire(string pismena)
        { 
            List<Zvire> vysledek = new List<Zvire>();

            foreach (var zvire in zvirata)
            {
                if (zvire.Jmeno.StartsWith(pismena,StringComparison.OrdinalIgnoreCase))
                {
                    vysledek.Add(zvire);
                }
            }
            return vysledek;
        }

        public void Ulozit(string cesta)
        //{
            {
                string json = JsonSerializer.Serialize(zvirata);
                File.WriteAllText(cesta, json);
            }
        //    using (StreamWriter sw = new StreamWriter(cesta))
        //    {
        //        foreach (var z in zvirata)
        //        {
        //            sw.WriteLine($"{z.Id};{z.Jmeno};{z.Druh};{z.VybehNazev}");
        //        }
        //    }
        //}

        public void Nacti(string cesta)
        {
            Zvire.SynchronizaceId(1);
            if (!File.Exists(cesta))
            {
                return;
            }
            string json = File.ReadAllText(cesta);
            zvirata = JsonSerializer.Deserialize<List<Zvire>>(json);

            if (zvirata.Count == 0)
            {
                return;
            }

            int tmpId = zvirata.Last().Id;
            Zvire.SynchronizaceId(tmpId+1);
        }

        public static string VelkePismeno(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
    }
}
