using projekt_sprava_zvirat.Entity;
using projekt_sprava_zvirat.Logika;

using System.Text.Json;

namespace projekt_sprava_zvirat
{
    public partial class Form1 : Form
    {
        private VybehLogika vybehLogika;
        private ZvireLogika zvireLogika;
        public Form1(VybehLogika vybehlogika, ZvireLogika zvireLogika)
        {
            InitializeComponent();
            this.vybehLogika = vybehlogika;
            this.zvireLogika = zvireLogika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNazevVybehu.Text == "Název už existuje")
            {
                textBoxNazevVybehu.Select(0, textBoxNazevVybehu.TextLength);
                return;
            }
            foreach (var item in vybehLogika.vratVybehy())
            {
                if (item.Nazev == textBoxNazevVybehu.Text)
                {
                    textBoxNazevVybehu.Text = "Název už existuje";
                    textBoxNazevVybehu.Select();
                    return;
                }
            }

            int kapacita;
            if (int.TryParse(textBoxKapacitaVybehu.Text, out kapacita))
            {
                var vybeh = new Vybeh(textBoxNazevVybehu.Text, kapacita);
                vybehLogika.pridejVybeh(vybeh);
                comboBoxSeznamVybehu.Items.Add(vybeh);
            }
            textBoxNazevVybehu.Clear();
            listBoxVybehy.Items.Clear();
            listBoxVybehy.Items.AddRange(vybehLogika.vratVybehy().ToArray());
            textBoxKapacitaVybehu.Clear();
        }

        private void buttonPridatZvire_Click(object sender, EventArgs e)
        {
            if (comboBoxSeznamVybehu.SelectedItem == null)
            {
                return;
            }

            if (vybehLogika.testKapacity((Vybeh)comboBoxSeznamVybehu.SelectedItem))
            {
                return;
            }
            vybehLogika.navysPocetZvirat((Vybeh)comboBoxSeznamVybehu.SelectedItem);
            string jmeno = textBoxJmenoZvirete.Text;
            var zvire = new Zvire(ZvireLogika.VelkePismeno(jmeno), ZvireLogika.VelkePismeno(textBoxDruh.Text),
                ((Vybeh)comboBoxSeznamVybehu.SelectedItem).Nazev);

            zvireLogika.PridejZvire(zvire);
            aktualizujVse();
            comboBoxSeznamVybehu.ResetText();
            textBoxJmenoZvirete.Clear();
            textBoxDruh.Clear();


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
        }

        private void buttonNacist_Click(object sender, EventArgs e)
        {
            vybehLogika.Nacti("Vybehy.json");

            comboBoxSeznamVybehu.Items.Clear();
            comboBoxSeznamVybehu.Items.AddRange(vybehLogika.vratVybehy().ToArray());
            listBoxVybehy.Items.Clear();
            listBoxVybehy.Items.AddRange(vybehLogika.vratVybehy().ToArray());

            zvireLogika.Nacti("Zvirata.json");
            listBoxZvirata.Items.Clear();
            listBoxZvirata.Items.AddRange(zvireLogika.VratZvirata().ToArray());
            //label8.Text = vybehLogika.vratId().ToString();
        }

        private void buttonSmazatVbh_Click(object sender, EventArgs e)
        {
            if ((Vybeh)listBoxVybehy.SelectedItem != null)
            {
                zvireLogika.SmazatZvirataPV((Vybeh)listBoxVybehy.SelectedItem);
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
            comboBoxSeznamVybehu.Items.Clear();
            comboBoxSeznamVybehu.Items.AddRange(vybehLogika.vratVybehy().ToArray());
        }
    }
}
