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
    public partial class FormZdraviPridat : Form
    {
        public string nazev;
        public string diagnoza;
        public int idZ;
        public string jmenoZvire;
        public FormZdraviPridat(string nazevZZ, string diagnozaZZ, Zvire zvire, ZvireLogika zvireLogika, string buttonText)
        {
            InitializeComponent();
            comboBoxZvirata.Items.Clear();
            comboBoxZvirata.Items.AddRange(zvireLogika.VratZvirata().ToArray());
            comboBoxZvirata.SelectedItem = zvire;
            textBoxNazevZ.Text = nazevZZ;
            richTextBoxDiagnoza.Text = diagnozaZZ;
            buttonPridat.Text = buttonText;
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            nazev = textBoxNazevZ.Text;
            diagnoza = richTextBoxDiagnoza.Text;
            idZ = ((Zvire)comboBoxZvirata.SelectedItem).Id;
            jmenoZvire = ((Zvire)comboBoxZvirata.SelectedItem).Jmeno;
        }
    }
}
