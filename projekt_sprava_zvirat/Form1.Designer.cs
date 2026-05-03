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
            SuspendLayout();
            // 
            // listBoxVybehy
            // 
            listBoxVybehy.FormattingEnabled = true;
            listBoxVybehy.Location = new Point(169, 36);
            listBoxVybehy.Name = "listBoxVybehy";
            listBoxVybehy.Size = new Size(164, 139);
            listBoxVybehy.TabIndex = 2;
            // 
            // buttonPridatVybeh
            // 
            buttonPridatVybeh.Location = new Point(27, 50);
            buttonPridatVybeh.Name = "buttonPridatVybeh";
            buttonPridatVybeh.Size = new Size(101, 23);
            buttonPridatVybeh.TabIndex = 3;
            buttonPridatVybeh.Text = "Přidat";
            buttonPridatVybeh.UseVisualStyleBackColor = true;
            buttonPridatVybeh.Click += button1_Click;
            // 
            // buttonPridatZvire
            // 
            buttonPridatZvire.Location = new Point(27, 254);
            buttonPridatZvire.Name = "buttonPridatZvire";
            buttonPridatZvire.Size = new Size(101, 23);
            buttonPridatZvire.TabIndex = 9;
            buttonPridatZvire.Text = "Přidat";
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
            textBoxVyhledavani.Location = new Point(204, 395);
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
            listBoxZdravi.Location = new Point(488, 36);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
