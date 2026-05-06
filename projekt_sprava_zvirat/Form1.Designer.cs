namespace projekt_sprava_zvirat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxVybehy = new ListBox();
            buttonPridatVybeh = new Button();
            buttonPridatZvire = new Button();
            listBoxZvirata = new ListBox();
            label6 = new Label();
            label9 = new Label();
            textBoxVyhledavani = new TextBox();
            buttonUlozit = new Button();
            buttonNacist = new Button();
            buttonSmazatVbh = new Button();
            buttonSmazatZvr = new Button();
            buttonUpravitV = new Button();
            buttonUpravitZ = new Button();
            listBoxZdravi = new ListBox();
            buttonPridatZZ = new Button();
            buttonUpravitZZ = new Button();
            buttonSmazatZZ = new Button();
            buttonSmazatKrmeni = new Button();
            buttonUpravitKrmeni = new Button();
            buttonPridatKrmeni = new Button();
            listBoxKrmeni = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBoxVyhledavaniDruh = new TextBox();
            comboBoxVyhledejDleVybehu = new ComboBox();
            SuspendLayout();
            // 
            // listBoxVybehy
            // 
            listBoxVybehy.FormattingEnabled = true;
            listBoxVybehy.Location = new Point(169, 36);
            listBoxVybehy.Name = "listBoxVybehy";
            listBoxVybehy.Size = new Size(177, 139);
            listBoxVybehy.TabIndex = 2;
            // 
            // buttonPridatVybeh
            // 
            buttonPridatVybeh.Location = new Point(27, 50);
            buttonPridatVybeh.Name = "buttonPridatVybeh";
            buttonPridatVybeh.Size = new Size(101, 23);
            buttonPridatVybeh.TabIndex = 3;
            buttonPridatVybeh.Text = "Přidat Výběh";
            buttonPridatVybeh.UseVisualStyleBackColor = true;
            buttonPridatVybeh.Click += button1_Click;
            // 
            // buttonPridatZvire
            // 
            buttonPridatZvire.Location = new Point(27, 254);
            buttonPridatZvire.Name = "buttonPridatZvire";
            buttonPridatZvire.Size = new Size(101, 23);
            buttonPridatZvire.TabIndex = 9;
            buttonPridatZvire.Text = "Přidat Zvíře";
            buttonPridatZvire.UseVisualStyleBackColor = true;
            buttonPridatZvire.Click += buttonPridatZvire_Click;
            // 
            // listBoxZvirata
            // 
            listBoxZvirata.FormattingEnabled = true;
            listBoxZvirata.Location = new Point(169, 241);
            listBoxZvirata.Name = "listBoxZvirata";
            listBoxZvirata.Size = new Size(177, 139);
            listBoxZvirata.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(199, 9);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 14;
            label6.Text = "Seznam výběhů";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(204, 210);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 17;
            label9.Text = "Seznam zvířat";
            // 
            // textBoxVyhledavani
            // 
            textBoxVyhledavani.ForeColor = SystemColors.WindowFrame;
            textBoxVyhledavani.Location = new Point(143, 395);
            textBoxVyhledavani.Name = "textBoxVyhledavani";
            textBoxVyhledavani.Size = new Size(111, 23);
            textBoxVyhledavani.TabIndex = 18;
            textBoxVyhledavani.Text = "Vyhledávání jméno";
            textBoxVyhledavani.MouseClick += textBoxVyhledavani_MouseClick;
            textBoxVyhledavani.TextChanged += textBoxVyhledavani_TextChanged;
            textBoxVyhledavani.Leave += textBoxVyhledavani_Leave;
            // 
            // buttonUlozit
            // 
            buttonUlozit.Location = new Point(713, 415);
            buttonUlozit.Name = "buttonUlozit";
            buttonUlozit.Size = new Size(75, 23);
            buttonUlozit.TabIndex = 19;
            buttonUlozit.Text = "Uložit";
            buttonUlozit.UseVisualStyleBackColor = true;
            buttonUlozit.Click += buttonUlozit_Click;
            // 
            // buttonNacist
            // 
            buttonNacist.Location = new Point(632, 415);
            buttonNacist.Name = "buttonNacist";
            buttonNacist.Size = new Size(75, 23);
            buttonNacist.TabIndex = 20;
            buttonNacist.Text = "Načíst";
            buttonNacist.UseVisualStyleBackColor = true;
            buttonNacist.Click += buttonNacist_Click;
            // 
            // buttonSmazatVbh
            // 
            buttonSmazatVbh.Location = new Point(27, 92);
            buttonSmazatVbh.Name = "buttonSmazatVbh";
            buttonSmazatVbh.Size = new Size(101, 23);
            buttonSmazatVbh.TabIndex = 21;
            buttonSmazatVbh.Text = "Smazat";
            buttonSmazatVbh.UseVisualStyleBackColor = true;
            buttonSmazatVbh.Click += buttonSmazatVbh_Click;
            // 
            // buttonSmazatZvr
            // 
            buttonSmazatZvr.Location = new Point(27, 296);
            buttonSmazatZvr.Name = "buttonSmazatZvr";
            buttonSmazatZvr.Size = new Size(101, 23);
            buttonSmazatZvr.TabIndex = 22;
            buttonSmazatZvr.Text = "Smazat";
            buttonSmazatZvr.UseVisualStyleBackColor = true;
            buttonSmazatZvr.Click += buttonSmazatZvr_Click;
            // 
            // buttonUpravitV
            // 
            buttonUpravitV.Location = new Point(27, 128);
            buttonUpravitV.Name = "buttonUpravitV";
            buttonUpravitV.Size = new Size(101, 23);
            buttonUpravitV.TabIndex = 23;
            buttonUpravitV.Text = "Upravit";
            buttonUpravitV.UseVisualStyleBackColor = true;
            buttonUpravitV.Click += buttonUpravitV_Click;
            // 
            // buttonUpravitZ
            // 
            buttonUpravitZ.Location = new Point(27, 341);
            buttonUpravitZ.Name = "buttonUpravitZ";
            buttonUpravitZ.Size = new Size(101, 23);
            buttonUpravitZ.TabIndex = 24;
            buttonUpravitZ.Text = "Upravit";
            buttonUpravitZ.UseVisualStyleBackColor = true;
            buttonUpravitZ.Click += buttonUpravitZ_Click;
            // 
            // listBoxZdravi
            // 
            listBoxZdravi.FormattingEnabled = true;
            listBoxZdravi.Location = new Point(493, 36);
            listBoxZdravi.Name = "listBoxZdravi";
            listBoxZdravi.Size = new Size(177, 139);
            listBoxZdravi.TabIndex = 27;
            // 
            // buttonPridatZZ
            // 
            buttonPridatZZ.Location = new Point(687, 50);
            buttonPridatZZ.Name = "buttonPridatZZ";
            buttonPridatZZ.Size = new Size(101, 23);
            buttonPridatZZ.TabIndex = 28;
            buttonPridatZZ.Text = "Přidat Záznam";
            buttonPridatZZ.UseVisualStyleBackColor = true;
            buttonPridatZZ.Click += buttonPridatZ_Click;
            // 
            // buttonUpravitZZ
            // 
            buttonUpravitZZ.Location = new Point(687, 92);
            buttonUpravitZZ.Name = "buttonUpravitZZ";
            buttonUpravitZZ.Size = new Size(101, 23);
            buttonUpravitZZ.TabIndex = 29;
            buttonUpravitZZ.Text = "Upravit";
            buttonUpravitZZ.UseVisualStyleBackColor = true;
            buttonUpravitZZ.Click += buttonUpravitZZ_Click;
            // 
            // buttonSmazatZZ
            // 
            buttonSmazatZZ.Location = new Point(687, 128);
            buttonSmazatZZ.Name = "buttonSmazatZZ";
            buttonSmazatZZ.Size = new Size(101, 23);
            buttonSmazatZZ.TabIndex = 30;
            buttonSmazatZZ.Text = "Smazat";
            buttonSmazatZZ.UseVisualStyleBackColor = true;
            buttonSmazatZZ.Click += buttonSmazatZZ_Click;
            // 
            // buttonSmazatKrmeni
            // 
            buttonSmazatKrmeni.Location = new Point(687, 330);
            buttonSmazatKrmeni.Name = "buttonSmazatKrmeni";
            buttonSmazatKrmeni.Size = new Size(101, 23);
            buttonSmazatKrmeni.TabIndex = 34;
            buttonSmazatKrmeni.Text = "Smazat";
            buttonSmazatKrmeni.UseVisualStyleBackColor = true;
            buttonSmazatKrmeni.Click += buttonSmazatKrmeni_Click;
            // 
            // buttonUpravitKrmeni
            // 
            buttonUpravitKrmeni.Location = new Point(687, 294);
            buttonUpravitKrmeni.Name = "buttonUpravitKrmeni";
            buttonUpravitKrmeni.Size = new Size(101, 23);
            buttonUpravitKrmeni.TabIndex = 33;
            buttonUpravitKrmeni.Text = "Upravit";
            buttonUpravitKrmeni.UseVisualStyleBackColor = true;
            buttonUpravitKrmeni.Click += buttonUpravitKrmeni_Click;
            // 
            // buttonPridatKrmeni
            // 
            buttonPridatKrmeni.Location = new Point(687, 254);
            buttonPridatKrmeni.Name = "buttonPridatKrmeni";
            buttonPridatKrmeni.Size = new Size(101, 23);
            buttonPridatKrmeni.TabIndex = 32;
            buttonPridatKrmeni.Text = "Přidat Krmeni";
            buttonPridatKrmeni.UseVisualStyleBackColor = true;
            buttonPridatKrmeni.Click += buttonPridatKrmeni_Click;
            // 
            // listBoxKrmeni
            // 
            listBoxKrmeni.FormattingEnabled = true;
            listBoxKrmeni.Location = new Point(493, 239);
            listBoxKrmeni.Name = "listBoxKrmeni";
            listBoxKrmeni.Size = new Size(177, 139);
            listBoxKrmeni.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(487, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 19);
            label1.TabIndex = 35;
            label1.Text = "Seznam zdravotních záznamů";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(498, 210);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 36;
            label2.Text = "Seznam záznamů o krmení";
            // 
            // textBoxVyhledavaniDruh
            // 
            textBoxVyhledavaniDruh.ForeColor = SystemColors.WindowFrame;
            textBoxVyhledavaniDruh.Location = new Point(277, 395);
            textBoxVyhledavaniDruh.Name = "textBoxVyhledavaniDruh";
            textBoxVyhledavaniDruh.Size = new Size(115, 23);
            textBoxVyhledavaniDruh.TabIndex = 37;
            textBoxVyhledavaniDruh.Text = "Vyhledávání druh";
            textBoxVyhledavaniDruh.MouseClick += textBoxVyhledavaniDruh_MouseClick;
            textBoxVyhledavaniDruh.TextChanged += textBoxVyhledavaniDruh_TextChanged;
            textBoxVyhledavaniDruh.Leave += textBoxVyhledavaniDruh_Leave;
            // 
            // comboBoxVyhledejDleVybehu
            // 
            comboBoxVyhledejDleVybehu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVyhledejDleVybehu.FormattingEnabled = true;
            comboBoxVyhledejDleVybehu.Location = new Point(204, 434);
            comboBoxVyhledejDleVybehu.Name = "comboBoxVyhledejDleVybehu";
            comboBoxVyhledejDleVybehu.Size = new Size(121, 23);
            comboBoxVyhledejDleVybehu.TabIndex = 38;
            comboBoxVyhledejDleVybehu.SelectionChangeCommitted += comboBoxVyhledejDleVybehu_SelectionChangeCommitted;
            comboBoxVyhledejDleVybehu.Click += comboBoxVyhledejDleVybehu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(comboBoxVyhledejDleVybehu);
            Controls.Add(textBoxVyhledavaniDruh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSmazatKrmeni);
            Controls.Add(buttonUpravitKrmeni);
            Controls.Add(buttonPridatKrmeni);
            Controls.Add(listBoxKrmeni);
            Controls.Add(buttonSmazatZZ);
            Controls.Add(buttonUpravitZZ);
            Controls.Add(buttonPridatZZ);
            Controls.Add(listBoxZdravi);
            Controls.Add(buttonUpravitZ);
            Controls.Add(buttonUpravitV);
            Controls.Add(buttonSmazatZvr);
            Controls.Add(buttonSmazatVbh);
            Controls.Add(buttonNacist);
            Controls.Add(buttonUlozit);
            Controls.Add(textBoxVyhledavani);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(buttonPridatZvire);
            Controls.Add(listBoxZvirata);
            Controls.Add(buttonPridatVybeh);
            Controls.Add(listBoxVybehy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxVybehy;
        private Button buttonPridatVybeh;
        private Button buttonPridatZvire;
        private ListBox listBoxZvirata;
        private Label label6;
        private Label label9;
        private TextBox textBoxVyhledavani;
        private Button buttonUlozit;
        private Button buttonNacist;
        private Button buttonSmazatVbh;
        private Button buttonSmazatZvr;
        private Button buttonUpravitV;
        private Button buttonUpravitZ;
        private ListBox listBoxZdravi;
        private Button buttonPridatZZ;
        private Button buttonUpravitZZ;
        private Button buttonSmazatZZ;
        private Button buttonSmazatKrmeni;
        private Button buttonUpravitKrmeni;
        private Button buttonPridatKrmeni;
        private ListBox listBoxKrmeni;
        private Label label1;
        private Label label2;
        private TextBox textBoxVyhledavaniDruh;
        private ComboBox comboBoxVyhledejDleVybehu;
    }
}
