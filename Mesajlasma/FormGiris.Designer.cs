namespace Mesajlasma
{
    partial class FormGiris
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
            label1 = new Label();
            mskNumara = new MaskedTextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Numara: ";
            // 
            // mskNumara
            // 
            mskNumara.Location = new Point(109, 23);
            mskNumara.Mask = "0000";
            mskNumara.Name = "mskNumara";
            mskNumara.Size = new Size(136, 29);
            mskNumara.TabIndex = 1;
            mskNumara.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(109, 58);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(136, 29);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 61);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "Şifre: ";
            // 
            // button1
            // 
            button1.Location = new Point(123, 103);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGiris
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(290, 154);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(mskNumara);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            FormClosed += FormGiris_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mskNumara;
        private TextBox txtSifre;
        private Label label2;
        private Button button1;
    }
}