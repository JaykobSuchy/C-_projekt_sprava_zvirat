namespace projekt_sprava_zvirat
{
    partial class FormPridatKrmeni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonZrusit = new Button();
            buttonPridat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxZvirata = new ComboBox();
            textBoxJidlo = new TextBox();
            textBoxMnozstvi = new TextBox();
            SuspendLayout();
            // 
            // buttonZrusit
            // 
            buttonZrusit.DialogResult = DialogResult.Cancel;
            buttonZrusit.Location = new Point(224, 233);
            buttonZrusit.Name = "buttonZrusit";
            buttonZrusit.Size = new Size(75, 23);
            buttonZrusit.TabIndex = 10;
            buttonZrusit.Text = "Zrušit";
            buttonZrusit.UseVisualStyleBackColor = true;
            // 
            // buttonPridat
            // 
            buttonPridat.DialogResult = DialogResult.OK;
            buttonPridat.Location = new Point(123, 233);
            buttonPridat.Name = "buttonPridat";
            buttonPridat.Size = new Size(75, 23);
            buttonPridat.TabIndex = 9;
            buttonPridat.Text = "Přidat";
            buttonPridat.UseVisualStyleBackColor = true;
            buttonPridat.Click += buttonPridat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 62);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 11;
            label1.Text = "Jídlo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Množství:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 158);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Zvíře:";
            // 
            // comboBoxZvirata
            // 
            comboBoxZvirata.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZvirata.FormattingEnabled = true;
            comboBoxZvirata.Location = new Point(105, 158);
            comboBoxZvirata.Name = "comboBoxZvirata";
            comboBoxZvirata.Size = new Size(121, 23);
            comboBoxZvirata.TabIndex = 14;
            // 
            // textBoxJidlo
            // 
            textBoxJidlo.Location = new Point(105, 59);
            textBoxJidlo.Name = "textBoxJidlo";
            textBoxJidlo.Size = new Size(121, 23);
            textBoxJidlo.TabIndex = 15;
            // 
            // textBoxMnozstvi
            // 
            textBoxMnozstvi.Location = new Point(105, 110);
            textBoxMnozstvi.Name = "textBoxMnozstvi";
            textBoxMnozstvi.Size = new Size(121, 23);
            textBoxMnozstvi.TabIndex = 16;
            // 
            // FormPridatKrmeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 281);
            Controls.Add(textBoxMnozstvi);
            Controls.Add(textBoxJidlo);
            Controls.Add(comboBoxZvirata);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonZrusit);
            Controls.Add(buttonPridat);
            Name = "FormPridatKrmeni";
            Text = "FormPridatKrmeni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZrusit;
        private Button buttonPridat;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxZvirata;
        private TextBox textBoxJidlo;
        private TextBox textBoxMnozstvi;
    }
}