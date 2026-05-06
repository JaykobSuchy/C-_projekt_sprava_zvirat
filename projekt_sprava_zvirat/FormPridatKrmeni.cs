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
    public partial class FormPridatKrmeni : Form
    {
        public string jidlo;
        public string mnozstvi;
        public int idZ;
        public string jmenoZvire;
        public FormPridatKrmeni(string jidloK, string mnozstviK, Zvire zvire, ZvireLogika zvireLogika, string buttonText)
        {
            InitializeComponent();
            comboBoxZvirata.Items.Clear();
            comboBoxZvirata.Items.AddRange(zvireLogika.VratZvirata().ToArray());
            comboBoxZvirata.SelectedItem = zvire;
            textBoxJidlo.Text = jidloK;
            textBoxMnozstvi.Text = mnozstviK;
            buttonPridat.Text = buttonText;
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            jidlo = textBoxJidlo.Text;
            mnozstvi = textBoxMnozstvi.Text;
            idZ = ((Zvire)comboBoxZvirata.SelectedItem).Id;
            jmenoZvire = ((Zvire)comboBoxZvirata.SelectedItem).Jmeno;
        }
    }
}
