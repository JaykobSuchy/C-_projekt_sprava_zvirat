using projekt_sprava_zvirat.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace projekt_sprava_zvirat.Logika
{
    public class ZZaznamLogika
    {
        private List<ZZaznam> zaznamy;

        public ZZaznamLogika()
        {
            zaznamy = new List<ZZaznam>();
        }

        public void pridejZZaznam(ZZaznam zzaznam)
        {
            zaznamy.Add(zzaznam);
        }

        public List<ZZaznam> VratZZaznamy()
        {
            return zaznamy;
        }

        public void SmazatZZaznam(ZZaznam zaznam)
        {
            zaznamy.Remove(zaznam);
        }

        public void SmazatZaznamyPodleZ(Zvire zvire)
        {
            zaznamy.RemoveAll(z => z.Id.Equals(zvire.Id));
        }
        public void UpravitZZaznam(ZZaznam zaznamOld, string nazev, string diagnoza, int zvireId, string zvireJmeno)
        {
            foreach (var zaznam in zaznamy)
            {
                if (zaznam.Id.Equals(zaznamOld.Id))
                {
                    zaznam.Nazev = nazev;
                    zaznam.Diagnoza = diagnoza;
                    zaznam.ZvireId = zvireId;
                    zaznam.jmenoZvire = zvireJmeno;
                }
            }
        }

        public void Ulozit(string cesta)
        {
            string json = JsonSerializer.Serialize(zaznamy);
            File.WriteAllText(cesta, json);
        }

        public void Nacti(string cesta)
        {
            if (!File.Exists(cesta))
            {
                return;
            }
            string json = File.ReadAllText(cesta);
            zaznamy = JsonSerializer.Deserialize<List<ZZaznam>>(json);

            if (zaznamy.Count == 0)
            {
                return;
            }
            int tmpId = zaznamy.Last().Id;

            ZZaznam.SynchronizaceId(tmpId + 1);
        }
    }
}
