namespace projekt_sprava_zvirat
{
    partial class FormUpravitZvire
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
            textBoxJmeno = new TextBox();
            textBoxDruh = new TextBox();
            comboBoxVybeh = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonUpravit = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Location = new Point(84, 47);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.Size = new Size(121, 23);
            textBoxJmeno.TabIndex = 0;
            // 
            // textBoxDruh
            // 
            textBoxDruh.Location = new Point(84, 112);
            textBoxDruh.Name = "textBoxDruh";
            textBoxDruh.Size = new Size(121, 23);
            textBoxDruh.TabIndex = 1;
            // 
            // comboBoxVybeh
            // 
            comboBoxVybeh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVybeh.FormattingEnabled = true;
            comboBoxVybeh.Location = new Point(84, 176);
            comboBoxVybeh.Name = "comboBoxVybeh";
            comboBoxVybeh.Size = new Size(121, 23);
            comboBoxVybeh.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Jméno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 112);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Druh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 184);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Výběh:";
            // 
            // buttonUpravit
            // 
            buttonUpravit.DialogResult = DialogResult.OK;
            buttonUpravit.Location = new Point(57, 241);
            buttonUpravit.Name = "buttonUpravit";
            buttonUpravit.Size = new Size(75, 23);
            buttonUpravit.TabIndex = 6;
            buttonUpravit.Text = "Upravit";
            buttonUpravit.UseVisualStyleBackColor = true;
            buttonUpravit.Click += buttonUpravit_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(162, 241);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Zrušit";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormUpravitZvire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 292);
            Controls.Add(button2);
            Controls.Add(buttonUpravit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxVybeh);
            Controls.Add(textBoxDruh);
            Controls.Add(textBoxJmeno);
            Name = "FormUpravitZvire";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxJmeno;
        private TextBox textBoxDruh;
        private ComboBox comboBoxVybeh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonUpravit;
        private Button button2;
    }
}