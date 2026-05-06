using projekt_sprava_zvirat.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace projekt_sprava_zvirat.Logika
{
    public class KrmeniLogika
    {
        private List<Krmeni> krmeni;

        public KrmeniLogika()
        {
            krmeni = new List<Krmeni>();
        }

        public void pridejKrmeni(Krmeni krmeno)
        {
            krmeni.Add(krmeno);
        }

        public List<Krmeni> VratKrmeni()
        {
            return krmeni;
        }

        public void SmazatKrmeni(Krmeni krmeno)
        {
            krmeni.Remove(krmeno);
        }

        public void SmazatKrmeniPodleZ(Zvire zvire)
        {
            krmeni.RemoveAll(z => z.ZvireId.Equals(zvire.Id));
        }
        public void UpravitKrmeni(Krmeni krmenoOld, string jidlo, string mnozstvi, int zvireId, string zvireJmeno)
        {
            foreach (var krmen in krmeni)
            {
                if (krmen.Id.Equals(krmenoOld.Id))
                {
                    krmen.Jidlo = jidlo;
                    krmen.Mnozstvi = mnozstvi;
                    krmen.ZvireId = zvireId;
                    krmen.jmenoZvire = zvireJmeno;
                }
            }
        }

        public void Ulozit(string cesta)
        {
            string json = JsonSerializer.Serialize(krmeni);
            File.WriteAllText(cesta, json);
        }

        public void Nacti(string cesta)
        {
            if (!File.Exists(cesta))
            {
                return;
            }
            string json = File.ReadAllText(cesta);
            krmeni = JsonSerializer.Deserialize<List<Krmeni>>(json);

            if (krmeni.Count == 0)
            {
                return;
            }
            int tmpId = krmeni.Last().Id;

            Krmeni.SynchronizaceId(tmpId + 1);
        }
    }
}
