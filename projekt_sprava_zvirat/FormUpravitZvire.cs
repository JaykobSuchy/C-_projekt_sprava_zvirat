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
    public partial class FormUpravitZvire : Form
    {
        public string jmenoZ;
        public string druhZ;
        public string vybehZ;
        public Vybeh vybeh;
        public FormUpravitZvire(string jmeno, string druh, Vybeh vybeh, VybehLogika vybehLogika, string buttonText)
        {
            InitializeComponent();
            textBoxJmeno.Text = jmeno;
            textBoxDruh.Text = druh;
            comboBoxVybeh.Items.Clear();
            comboBoxVybeh.Items.AddRange(vybehLogika.vratVybehy().ToArray());
            buttonUpravit.Text = buttonText;
            comboBoxVybeh.SelectedItem = vybeh;
        }

        private void buttonUpravit_Click(object sender, EventArgs e)
        {
            if ((Vybeh)comboBoxVybeh.SelectedItem == null) {
                vybehZ = null;
                    return;
            }
            jmenoZ = textBoxJmeno.Text;
            druhZ = textBoxDruh.Text;
            vybehZ = ((Vybeh)comboBoxVybeh.SelectedItem).Nazev;
            vybeh = (Vybeh)comboBoxVybeh.SelectedItem;
        }
    }


}
