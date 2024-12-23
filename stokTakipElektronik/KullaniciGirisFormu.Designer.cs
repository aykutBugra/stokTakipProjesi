namespace stokTakipElektronik
{
    partial class KullaniciGirisFormu
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1; // Dönen çark
        private PictureBox pictureBox2; // Logo
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnGirisYap;
   

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(674, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 454);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(300, 174);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 2;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(400, 174);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(134, 23);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(300, 224);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(400, 224);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(134, 23);
            txtSifre.TabIndex = 5;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.SteelBlue;
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(400, 274);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(85, 29);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(347, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(234, 125);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // KullaniciGirisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(btnGirisYap);
            Name = "KullaniciGirisFormu";
            Text = "Kullanıcı Giriş";
            Load += KullaniciGirisFormu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox3;
    }
}
