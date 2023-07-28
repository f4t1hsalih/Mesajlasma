namespace Mesajlasma
{
    partial class FormMesajlar
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
            label1 = new Label();
            lblNumara = new Label();
            label3 = new Label();
            lblAdSoyad = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            rchMesaj = new RichTextBox();
            txtBaslik = new TextBox();
            mskAlici = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Numara: ";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(98, 20);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(41, 20);
            lblNumara.TabIndex = 1;
            lblNumara.Text = "0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 20);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(260, 20);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(67, 20);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "Null Null";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(366, 322);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 348);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelen Kutusu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(390, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 348);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giden Kutusu";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(324, 322);
            dataGridView2.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(rchMesaj);
            groupBox3.Controls.Add(txtBaslik);
            groupBox3.Controls.Add(mskAlici);
            groupBox3.Location = new Point(12, 413);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(708, 144);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mesaj Paneli";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 29);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 6;
            label7.Text = "Mesaj: ";
            // 
            // button1
            // 
            button1.Location = new Point(46, 99);
            button1.Name = "button1";
            button1.Size = new Size(104, 32);
            button1.TabIndex = 5;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 62);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 4;
            label6.Text = "Başlık: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Alıcı: ";
            // 
            // rchMesaj
            // 
            rchMesaj.Location = new Point(258, 26);
            rchMesaj.Name = "rchMesaj";
            rchMesaj.Size = new Size(444, 112);
            rchMesaj.TabIndex = 2;
            rchMesaj.Text = "";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(71, 59);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(100, 27);
            txtBaslik.TabIndex = 1;
            // 
            // mskAlici
            // 
            mskAlici.Location = new Point(71, 26);
            mskAlici.Mask = "0000";
            mskAlici.Name = "mskAlici";
            mskAlici.Size = new Size(100, 27);
            mskAlici.TabIndex = 0;
            mskAlici.ValidatingType = typeof(int);
            // 
            // FormMesajlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(732, 569);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAdSoyad);
            Controls.Add(label3);
            Controls.Add(lblNumara);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMesajlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesajlar";
            FormClosed += FormMesajlar_FormClosed;
            Load += FormMesajlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumara;
        private Label label3;
        private Label lblAdSoyad;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private RichTextBox rchMesaj;
        private TextBox txtBaslik;
        private MaskedTextBox mskAlici;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
    }
}