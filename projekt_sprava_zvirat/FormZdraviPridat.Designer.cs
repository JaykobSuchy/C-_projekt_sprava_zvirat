namespace projekt_sprava_zvirat
{
    partial class FormZdraviPridat
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
            richTextBoxDiagnoza = new RichTextBox();
            label1 = new Label();
            comboBoxZvirata = new ComboBox();
            label2 = new Label();
            textBoxNazevZ = new TextBox();
            label3 = new Label();
            buttonPridat = new Button();
            buttonZrusit = new Button();
            SuspendLayout();
            // 
            // richTextBoxDiagnoza
            // 
            richTextBoxDiagnoza.Location = new Point(126, 97);
            richTextBoxDiagnoza.Name = "richTextBoxDiagnoza";
            richTextBoxDiagnoza.Size = new Size(309, 118);
            richTextBoxDiagnoza.TabIndex = 1;
            richTextBoxDiagnoza.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Diagnóza:";
            // 
            // comboBoxZvirata
            // 
            comboBoxZvirata.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZvirata.FormattingEnabled = true;
            comboBoxZvirata.Location = new Point(126, 249);
            comboBoxZvirata.Name = "comboBoxZvirata";
            comboBoxZvirata.Size = new Size(121, 23);
            comboBoxZvirata.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 249);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Zvíře:";
            // 
            // textBoxNazevZ
            // 
            textBoxNazevZ.Location = new Point(126, 43);
            textBoxNazevZ.Name = "textBoxNazevZ";
            textBoxNazevZ.Size = new Size(121, 23);
            textBoxNazevZ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Název záznamu: ";
            // 
            // buttonPridat
            // 
            buttonPridat.DialogResult = DialogResult.OK;
            buttonPridat.Location = new Point(267, 303);
            buttonPridat.Name = "buttonPridat";
            buttonPridat.Size = new Size(75, 23);
            buttonPridat.TabIndex = 7;
            buttonPridat.Text = "Přidat";
            buttonPridat.UseVisualStyleBackColor = true;
            buttonPridat.Click += buttonPridat_Click;
            // 
            // buttonZrusit
            // 
            buttonZrusit.DialogResult = DialogResult.Cancel;
            buttonZrusit.Location = new Point(373, 303);
            buttonZrusit.Name = "buttonZrusit";
            buttonZrusit.Size = new Size(75, 23);
            buttonZrusit.TabIndex = 8;
            buttonZrusit.Text = "Zrušit";
            buttonZrusit.UseVisualStyleBackColor = true;
            // 
            // FormZdraviPridat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 349);
            Controls.Add(buttonZrusit);
            Controls.Add(buttonPridat);
            Controls.Add(label3);
            Controls.Add(textBoxNazevZ);
            Controls.Add(label2);
            Controls.Add(comboBoxZvirata);
            Controls.Add(label1);
            Controls.Add(richTextBoxDiagnoza);
            Name = "FormZdraviPridat";
            Text = "FormZdraviPridat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxDiagnoza;
        private Label label1;
        private ComboBox comboBoxZvirata;
        private Label label2;
        private TextBox textBoxNazevZ;
        private Label label3;
        private Button buttonPridat;
        private Button buttonZrusit;
    }
}