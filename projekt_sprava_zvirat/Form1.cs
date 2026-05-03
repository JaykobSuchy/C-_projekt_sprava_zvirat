using projekt_sprava_zvirat.Entity;
using projekt_sprava_zvirat.Logika;

using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt_sprava_zvirat
{
    public partial class Form1 : Form
    {
        private VybehLogika vybehLogika;
        private ZvireLogika zvireLogika;
        private ZZaznamLogika zzaznamLogika;
        public Form1(VybehLogika vybehlogika, ZvireLogika zvireLogika, ZZaznamLogika zzaznamLogika)
        {
            InitializeComponent();
            this.vybehLogika = vybehlogika;
            this.zvireLogika = zvireLogika;
            this.zzaznamLogika = zzaznamLogika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormUpravitVybeh dialog = new FormUpravitVybeh(null, 0, vybehLogika, "Přidat"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string nazev = dialog.nazevV;
                    int kapacita = dialog.kapacitaV;
                    var vybeh = new Vybeh(nazev, kapacita);
                    vybehLogika.pridejVybeh(vybeh);
                    aktualizujVse();
                }
            }
        }

        private void buttonPridatZvire_Click(object sender, EventArgs e)
        {
            using (FormUpravitZvire dialog = new FormUpravitZvire(null, null, null, vybehLogika, "Přidat"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Vybeh v = dialog.vybeh;
                    string jmeno = ZvireLogika.VelkePismeno(dialog.jmenoZ);
                    string druh = ZvireLogika.VelkePismeno(dialog.druhZ);
                    if (v == null)
                    {
                        return;
                    }
                    if (vybehLogika.testKapacity(v))
                    {
                        return;
                    }
                    var zvire = new Zvire(dialog.jmenoZ, dialog.druhZ, dialog.vybehZ);
                    zvireLogika.PridejZvire(zvire);
                    vybehLogika.navysPocetZvirat(v);
                    aktualizujVse();
                }
            }
        }

        private void textBoxVyhledavani_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVyhledavani.Text == "Vyhledávání")
            {
                return;
            }
            listBoxZvirata.Items.Clear();
            listBoxZvirata.Items.AddRange(zvireLogika.VyhledejZvire(textBoxVyhledavani.Text).ToArray());
        }

        private void textBoxVyhledavani_Leave(object sender, EventArgs e)
        {
            if (textBoxVyhledavani.Text.Equals("Vyhledávání"))
            {
                return;
            }
            if (textBoxVyhledavani.Text == "")
            {
                textBoxVyhledavani.Text = "Vyhledávání";
                return;
            }
        }

        private void textBoxVyhledavani_MouseClick(object sender, MouseEventArgs e)
        {

            textBoxVyhledavani.Select(0, textBoxVyhledavani.TextLength);
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            vybehLogika.Ulozit("Vybehy.json");
            zvireLogika.Ulozit("Zvirata.json");
            zzaznamLogika.Ulozit("ZZaznamy.json");
        }

        private void buttonNacist_Click(object sender, EventArgs e)
        {
            vybehLogika.Nacti("Vybehy.json");

            //comboBoxSeznamVybehu.Items.Clear();
            //comboBoxSeznamVybehu.Items.AddRange(vybehLogika.vratVybehy().ToArray());
            //listBoxVybehy.Items.Clear();
            //listBoxVybehy.Items.AddRange(vybehLogika.vratVybehy().ToArray());

            zvireLogika.Nacti("Zvirata.json");
            //listBoxZvirata.Items.Clear();
            //listBoxZvirata.Items.AddRange(zvireLogika.VratZvirata().ToArray());
            //label8.Text = vybehLogika.vratId().ToString();

            zzaznamLogika.Nacti("ZZaznamy.json");
            aktualizujVse();
        }

        private void buttonSmazatVbh_Click(object sender, EventArgs e)
        {
            if ((Vybeh)listBoxVybehy.SelectedItem != null)
            {
                zvireLogika.SmazatZvirataPodleV((Vybeh)listBoxVybehy.SelectedItem);
                vybehLogika.odeberVybeh((Vybeh)listBoxVybehy.SelectedItem);
                aktualizujVse();
            }
            else return;
        }

        private void buttonSmazatZvr_Click(object sender, EventArgs e)
        {
            if ((Zvire)listBoxZvirata.SelectedItem != null)
            {
                Vybeh vybeh = vybehLogika.NajdiVybeh(((Zvire)listBoxZvirata.SelectedItem).VybehNazev);
                vybehLogika.uberPocetZvirat(vybeh);
                zvireLogika.SmazatZvire((Zvire)listBoxZvirata.SelectedItem);
                zzaznamLogika.SmazatZaznamyPodleZ((Zvire)listBoxZvirata.SelectedItem);
                aktualizujVse();
            }
            else return;

        }

        private void aktualizujVse()
        {
            listBoxZvirata.Items.Clear();
            listBoxZvirata.Items.AddRange(zvireLogika.VratZvirata().ToArray());
            listBoxVybehy.Items.Clear();
            listBoxVybehy.Items.AddRange(vybehLogika.vratVybehy().ToArray());
            listBoxZdravi.Items.Clear();
            listBoxZdravi.Items.AddRange(zzaznamLogika.VratZZaznamy().ToArray());
            //comboBoxSeznamVybehu.Items.Clear();
            //comboBoxSeznamVybehu.Items.AddRange(vybehLogika.vratVybehy().ToArray());
        }

        private void buttonUpravitV_Click(object sender, EventArgs e)
        {
            if (listBoxVybehy.SelectedItem == null)
            {
                return;
            }
            string nazev = ((Vybeh)listBoxVybehy.SelectedItem).Nazev;
            int kapacita = ((Vybeh)listBoxVybehy.SelectedItem).kapacita;

            using (FormUpravitVybeh dialog = new FormUpravitVybeh(nazev, kapacita, vybehLogika, "Upravit"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    nazev = ZvireLogika.VelkePismeno(dialog.nazevV);
                    kapacita = dialog.kapacitaV;
                    vybehLogika.UpravitVybeh((Vybeh)listBoxVybehy.SelectedItem, nazev, kapacita);
                    aktualizujVse();
                }
            }
        }

        private void buttonUpravitZ_Click(object sender, EventArgs e)
        {
            if (listBoxZvirata.SelectedItem == null)
            {
                return;
            }
            string jmeno = ((Zvire)listBoxZvirata.SelectedItem).Jmeno;
            string druh = ((Zvire)listBoxZvirata.SelectedItem).Druh;
            string vybeh = ((Zvire)listBoxZvirata.SelectedItem).VybehNazev;
            //Vybeh vybeh = vybehLogika.NajdiVybeh(((Zvire)listBoxZvirata.SelectedItem).VybehNazev);
            Vybeh v = vybehLogika.NajdiVybeh(vybeh);

            using (FormUpravitZvire dialog = new FormUpravitZvire(jmeno, druh, v, vybehLogika, "Upravit"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    jmeno = ZvireLogika.VelkePismeno(dialog.jmenoZ);
                    druh = ZvireLogika.VelkePismeno(dialog.druhZ);
                    vybeh = dialog.vybehZ;
                    v = vybehLogika.NajdiVybeh(vybeh);
                    if (vybeh == null) return;
                    if (vybehLogika.testKapacity(v))
                    {
                        return;
                    }
                    vybehLogika.uberPocetZvirat(vybehLogika.NajdiVybeh(((Zvire)listBoxZvirata.SelectedItem).VybehNazev));
                    zvireLogika.UpravitZvire((Zvire)listBoxZvirata.SelectedItem, jmeno, druh, vybeh);
                    vybehLogika.navysPocetZvirat(v);
                    aktualizujVse();
                }

            }

        }

        private void buttonPridatZ_Click(object sender, EventArgs e)
        {
            using (FormZdraviPridat dialog = new FormZdraviPridat(null,null,null, zvireLogika, "Přidat"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var zzaznam = new ZZaznam(dialog.nazev, dialog.diagnoza, dialog.idZ, dialog.jmenoZvire);
                    zzaznamLogika.pridejZZaznam(zzaznam);
                    aktualizujVse();
                }
            }
        }

        private void buttonUpravitZZ_Click(object sender, EventArgs e)
        {
            if (listBoxZdravi.SelectedItem == null)
            {
                return;
            }
            string nazev = ((ZZaznam)listBoxZdravi.SelectedItem).Nazev;
            string diagnoza = ((ZZaznam)listBoxZdravi.SelectedItem).Diagnoza;
            int zvireid = ((ZZaznam)listBoxZdravi.SelectedItem).ZvireId;
            Zvire zvire = zvireLogika.NajdiZvire(zvireid);

            using (FormZdraviPridat dialog = new FormZdraviPridat(nazev,diagnoza,zvire, zvireLogika, "Upravit"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string jmenoZ = dialog.jmenoZvire;
                    nazev = ZvireLogika.VelkePismeno(dialog.nazev);
                    diagnoza = dialog.diagnoza;
                    zvireid = dialog.idZ;

                    zzaznamLogika.UpravitZZaznam((ZZaznam)listBoxZdravi.SelectedItem, nazev, diagnoza, zvireid, jmenoZ);
                    aktualizujVse();
                }
            }
        }

        private void buttonSmazatZZ_Click(object sender, EventArgs e)
        {
            if ((ZZaznam)listBoxZdravi.SelectedItem != null)
            {
                zzaznamLogika.SmazatZZaznam((ZZaznam)listBoxZdravi.SelectedItem);
                aktualizujVse();
            }
            else return;
        }
    }
}
