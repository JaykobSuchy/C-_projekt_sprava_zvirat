using projekt_sprava_zvirat.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt_sprava_zvirat.Logika
{
    public class VybehLogika
    {
        private List<Vybeh> vybehy;

        public VybehLogika()
        {
            vybehy = new List<Vybeh>();
        }

        public void pridejVybeh(Vybeh vybeh)
        {
            vybehy.Add(vybeh);
        }

        public void odeberVybeh(Vybeh vybeh)
        {
            vybehy.Remove(vybeh);
        }

        public List<Vybeh> vratVybehy()
        {
            return vybehy;
        }

        public void navysPocetZvirat(Vybeh vybeh)
        {
            vybeh.pocetZvirat++;
        }

        public void uberPocetZvirat(Vybeh vybeh)
        {
            vybeh.pocetZvirat--;
        }

        public bool testKapacity(Vybeh vybeh)
        {
            return vybeh.kapacita == vybeh.pocetZvirat;
        }

        public void Ulozit(string cesta)
        {
            string json = JsonSerializer.Serialize(vybehy);
            File.WriteAllText(cesta, json);
        }

        public void Nacti(string cesta)
        {
            if (!File.Exists(cesta))
            {
                return;
            }
            string json = File.ReadAllText(cesta);
            vybehy = JsonSerializer.Deserialize<List<Vybeh>>(json);

            if(vybehy.Count == 0)
            {
                return;
            }
            int tmpId = vybehy.Last().Id;

            Vybeh.SynchronizaceId(tmpId+1);
        }

        public Vybeh NajdiVybeh(string vybehNazev)
        {
            //Vybeh vysledek = null;

            return vybehy
            .FirstOrDefault(v => v.Nazev.Equals(vybehNazev));

            //foreach (var vybeh in vybehy)
            //{
            //    if (vybeh.Nazev == vybehNazev)
            //    {
            //        vysledek = vybeh;
            //        return vysledek;
            //    }
            //}
            //    return null;
        }
        public void UpravitVybeh(Vybeh vybehOld, string nazev, int kapacita)
        {
            foreach (var vybeh in vybehy)
            {
                if (vybeh.Id.Equals(vybehOld.Id))
                {
                    vybeh.Nazev = nazev;
                    vybeh.kapacita = kapacita;
                }
            }
        }
    }
}
