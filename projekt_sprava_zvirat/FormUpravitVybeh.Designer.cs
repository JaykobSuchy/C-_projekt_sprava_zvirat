namespace projekt_sprava_zvirat
{
    partial class FormUpravitVybeh
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
            label2 = new Label();
            label1 = new Label();
            textBoxKapacitaVybehu = new TextBox();
            textBoxNazevVybehu = new TextBox();
            buttonZrusit = new Button();
            buttonUpravit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "Kapacita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Název:";
            // 
            // textBoxKapacitaVybehu
            // 
            textBoxKapacitaVybehu.Location = new Point(87, 86);
            textBoxKapacitaVybehu.Name = "textBoxKapacitaVybehu";
            textBoxKapacitaVybehu.Size = new Size(113, 23);
            textBoxKapacitaVybehu.TabIndex = 7;
            // 
            // textBoxNazevVybehu
            // 
            textBoxNazevVybehu.Location = new Point(87, 38);
            textBoxNazevVybehu.Name = "textBoxNazevVybehu";
            textBoxNazevVybehu.Size = new Size(113, 23);
            textBoxNazevVybehu.TabIndex = 6;
            // 
            // buttonZrusit
            // 
            buttonZrusit.DialogResult = DialogResult.Cancel;
            buttonZrusit.Location = new Point(146, 143);
            buttonZrusit.Name = "buttonZrusit";
            buttonZrusit.Size = new Size(73, 23);
            buttonZrusit.TabIndex = 11;
            buttonZrusit.Text = "Zrušit";
            buttonZrusit.UseVisualStyleBackColor = true;
            // 
            // buttonUpravit
            // 
            buttonUpravit.Location = new Point(59, 143);
            buttonUpravit.Name = "buttonUpravit";
            buttonUpravit.Size = new Size(71, 23);
            buttonUpravit.TabIndex = 10;
            buttonUpravit.Text = "Upravit";
            buttonUpravit.UseVisualStyleBackColor = true;
            buttonUpravit.Click += buttonUpravit_Click;
            // 
            // FormUpravitVybeh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 191);
            Controls.Add(buttonZrusit);
            Controls.Add(buttonUpravit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxKapacitaVybehu);
            Controls.Add(textBoxNazevVybehu);
            Name = "FormUpravitVybeh";
            Text = "FormUpravitVybeh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBoxKapacitaVybehu;
        private TextBox textBoxNazevVybehu;
        private Button buttonZrusit;
        private Button buttonUpravit;
    }
}