namespace OkulAppProjectSube1
{
    partial class Form1
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
            grpOgrenci = new GroupBox();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            btnKaydet = new Button();
            btnBul = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            grpOgrenci.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenci
            // 
            grpOgrenci.Controls.Add(comboBox1);
            grpOgrenci.Controls.Add(label2);
            grpOgrenci.Controls.Add(lblNumara);
            grpOgrenci.Controls.Add(lblSoyad);
            grpOgrenci.Controls.Add(lblAd);
            grpOgrenci.Controls.Add(txtNumara);
            grpOgrenci.Controls.Add(txtSoyad);
            grpOgrenci.Controls.Add(txtAd);
            grpOgrenci.Location = new Point(4, 14);
            grpOgrenci.Margin = new Padding(4, 3, 4, 3);
            grpOgrenci.Name = "grpOgrenci";
            grpOgrenci.Padding = new Padding(4, 3, 4, 3);
            grpOgrenci.Size = new Size(324, 195);
            grpOgrenci.TabIndex = 0;
            grpOgrenci.TabStop = false;
            grpOgrenci.Text = "Öğrenci Ekleme";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(59, 115);
            lblNumara.Margin = new Padding(4, 0, 4, 0);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(50, 15);
            lblNumara.TabIndex = 5;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(59, 87);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(59, 58);
            lblAd.Margin = new Padding(4, 0, 4, 0);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 3;
            lblAd.Text = "Ad";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(117, 110);
            txtNumara.Margin = new Padding(4, 3, 4, 3);
            txtNumara.MaxLength = 10;
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(116, 23);
            txtNumara.TabIndex = 2;
            txtNumara.TextChanged += txt_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(117, 80);
            txtSoyad.Margin = new Padding(4, 3, 4, 3);
            txtSoyad.MaxLength = 30;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(116, 23);
            txtSoyad.TabIndex = 1;
            txtSoyad.TextChanged += txt_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(117, 50);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.MaxLength = 20;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(116, 23);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txt_TextChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(120, 216);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(117, 27);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(240, 216);
            btnBul.Margin = new Padding(4, 3, 4, 3);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(88, 27);
            btnBul.TabIndex = 7;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(26, 216);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(121, 263);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(116, 27);
            button1.TabIndex = 9;
            button1.Text = "Ders Seçimi";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 10;
            label2.Text = "Sınıf Seçiniz";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 312);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(grpOgrenci);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bul";
            grpOgrenci.ResumeLayout(false);
            grpOgrenci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenci;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnUpdate;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
    }
}

