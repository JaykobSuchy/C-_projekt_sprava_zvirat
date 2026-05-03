using projekt_sprava_zvirat.Entity;
using projekt_sprava_zvirat.Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projekt_sprava_zvirat
{
    public partial class FormUpravitVybeh : Form
    {
        public string nazevV;
        public int kapacitaV;
        private VybehLogika vybehlogika;
        public FormUpravitVybeh(string nazev, int kapacita, VybehLogika vybehLogika, string buttonText)
        {
            InitializeComponent();
            textBoxNazevVybehu.Text = nazev;
            textBoxKapacitaVybehu.Text = kapacita.ToString();
            vybehlogika = vybehLogika;
        }

        private void buttonUpravit_Click(object sender, EventArgs e)
        {
            if (textBoxNazevVybehu.Text == "Název už existuje")
            {
                textBoxNazevVybehu.Select(0, textBoxNazevVybehu.TextLength);
                return;
            }

                foreach (var item in vybehlogika.vratVybehy())
                {
                    if (item.Nazev == ZvireLogika.VelkePismeno(textBoxNazevVybehu.Text))
                    {
                        textBoxNazevVybehu.Text = "Název už existuje";
                        textBoxNazevVybehu.Select();
                        return;
                    }
                }



            nazevV = ZvireLogika.VelkePismeno(textBoxNazevVybehu.Text);
            int.TryParse(textBoxKapacitaVybehu.Text, out kapacitaV);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }

}

