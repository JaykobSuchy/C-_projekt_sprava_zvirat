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
            textBoxNazevVybehu = new TextBox();
            textBoxKapacitaVybehu = new TextBox();
            listBoxVybehy = new ListBox();
            buttonPridatVybeh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonPridatZvire = new Button();
            listBoxZvirata = new ListBox();
            textBoxDruh = new TextBox();
            textBoxJmenoZvirete = new TextBox();
            comboBoxSeznamVybehu = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxVyhledavani = new TextBox();
            buttonUlozit = new Button();
            buttonNacist = new Button();
            buttonSmazatVbh = new Button();
            buttonSmazatZvr = new Button();
            SuspendLayout();
            // 
            // textBoxNazevVybehu
            // 
            textBoxNazevVybehu.Location = new Point(74, 36);
            textBoxNazevVybehu.Name = "textBoxNazevVybehu";
            textBoxNazevVybehu.Size = new Size(100, 23);
            textBoxNazevVybehu.TabIndex = 0;
            // 
            // textBoxKapacitaVybehu
            // 
            textBoxKapacitaVybehu.Location = new Point(74, 84);
            textBoxKapacitaVybehu.Name = "textBoxKapacitaVybehu";
            textBoxKapacitaVybehu.Size = new Size(100, 23);
            textBoxKapacitaVybehu.TabIndex = 1;
            // 
            // listBoxVybehy
            // 
            listBoxVybehy.FormattingEnabled = true;
            listBoxVybehy.Location = new Point(194, 36);
            listBoxVybehy.Name = "listBoxVybehy";
            listBoxVybehy.Size = new Size(164, 124);
            listBoxVybehy.TabIndex = 2;
            // 
            // buttonPridatVybeh
            // 
            buttonPridatVybeh.Location = new Point(12, 128);
            buttonPridatVybeh.Name = "buttonPridatVybeh";
            buttonPridatVybeh.Size = new Size(75, 23);
            buttonPridatVybeh.TabIndex = 3;
            buttonPridatVybeh.Text = "Přidat";
            buttonPridatVybeh.UseVisualStyleBackColor = true;
            buttonPridatVybeh.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Název:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Kapacita:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 289);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Druh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Jméno:";
            // 
            // buttonPridatZvire
            // 
            buttonPridatZvire.Location = new Point(12, 372);
            buttonPridatZvire.Name = "buttonPridatZvire";
            buttonPridatZvire.Size = new Size(75, 23);
            buttonPridatZvire.TabIndex = 9;
            buttonPridatZvire.Text = "Přidat";
            buttonPridatZvire.UseVisualStyleBackColor = true;
            buttonPridatZvire.Click += buttonPridatZvire_Click;
            // 
            // listBoxZvirata
            // 
            listBoxZvirata.FormattingEnabled = true;
            listBoxZvirata.Location = new Point(194, 241);
            listBoxZvirata.Name = "listBoxZvirata";
            listBoxZvirata.Size = new Size(177, 139);
            listBoxZvirata.TabIndex = 8;
            // 
            // textBoxDruh
            // 
            textBoxDruh.Location = new Point(61, 289);
            textBoxDruh.Name = "textBoxDruh";
            textBoxDruh.Size = new Size(113, 23);
            textBoxDruh.TabIndex = 7;
            // 
            // textBoxJmenoZvirete
            // 
            textBoxJmenoZvirete.Location = new Point(63, 241);
            textBoxJmenoZvirete.Name = "textBoxJmenoZvirete";
            textBoxJmenoZvirete.Size = new Size(111, 23);
            textBoxJmenoZvirete.TabIndex = 6;
            // 
            // comboBoxSeznamVybehu
            // 
            comboBoxSeznamVybehu.FormattingEnabled = true;
            comboBoxSeznamVybehu.Location = new Point(61, 329);
            comboBoxSeznamVybehu.Name = "comboBoxSeznamVybehu";
            comboBoxSeznamVybehu.Size = new Size(114, 23);
            comboBoxSeznamVybehu.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 329);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "Výběh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(211, 9);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 14;
            label6.Text = "Seznam výběhů";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(32, 9);
            label7.Name = "label7";
            label7.Size = new Size(117, 19);
            label7.TabIndex = 15;
            label7.Text = "Vytvoření výběhu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(32, 210);
            label8.Name = "label8";
            label8.Size = new Size(112, 19);
            label8.TabIndex = 16;
            label8.Text = "Vytvoření zvířete";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(211, 210);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 17;
            label9.Text = "Seznam zvířat";
            // 
            // textBoxVyhledavani
            // 
            textBoxVyhledavani.ForeColor = SystemColors.WindowFrame;
            textBoxVyhledavani.Location = new Point(229, 386);
            textBoxVyhledavani.Name = "textBoxVyhledavani";
            textBoxVyhledavani.Size = new Size(100, 23);
            textBoxVyhledavani.TabIndex = 18;
            textBoxVyhledavani.Text = "Vyhledávání";
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
            buttonSmazatVbh.Location = new Point(99, 128);
            buttonSmazatVbh.Name = "buttonSmazatVbh";
            buttonSmazatVbh.Size = new Size(75, 23);
            buttonSmazatVbh.TabIndex = 21;
            buttonSmazatVbh.Text = "Smazat";
            buttonSmazatVbh.UseVisualStyleBackColor = true;
            buttonSmazatVbh.Click += buttonSmazatVbh_Click;
            // 
            // buttonSmazatZvr
            // 
            buttonSmazatZvr.Location = new Point(99, 372);
            buttonSmazatZvr.Name = "buttonSmazatZvr";
            buttonSmazatZvr.Size = new Size(75, 23);
            buttonSmazatZvr.TabIndex = 22;
            buttonSmazatZvr.Text = "Smazat";
            buttonSmazatZvr.UseVisualStyleBackColor = true;
            buttonSmazatZvr.Click += buttonSmazatZvr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSmazatZvr);
            Controls.Add(buttonSmazatVbh);
            Controls.Add(buttonNacist);
            Controls.Add(buttonUlozit);
            Controls.Add(textBoxVyhledavani);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxSeznamVybehu);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(buttonPridatZvire);
            Controls.Add(listBoxZvirata);
            Controls.Add(textBoxDruh);
            Controls.Add(textBoxJmenoZvirete);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPridatVybeh);
            Controls.Add(listBoxVybehy);
            Controls.Add(textBoxKapacitaVybehu);
            Controls.Add(textBoxNazevVybehu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNazevVybehu;
        private TextBox textBoxKapacitaVybehu;
        private ListBox listBoxVybehy;
        private Button buttonPridatVybeh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonPridatZvire;
        private ListBox listBoxZvirata;
        private TextBox textBoxDruh;
        private TextBox textBoxJmenoZvirete;
        private ComboBox comboBoxSeznamVybehu;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxVyhledavani;
        private Button buttonUlozit;
        private Button buttonNacist;
        private Button buttonSmazatVbh;
        private Button buttonSmazatZvr;
    }
}
