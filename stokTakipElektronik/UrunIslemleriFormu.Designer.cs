namespace stokTakipElektronik
{
    partial class UrunIslemleriFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnStokArtir;
        private System.Windows.Forms.Button btnStokAzalt;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunGecmisi;
        private System.Windows.Forms.Label lblKullaniciTipi;
        private System.Windows.Forms.Button btnFiyatGuncelle;

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
            pictureBoxLogo = new PictureBox();
            dgvUrunler = new DataGridView();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
            btnStokArtir = new Button();
            btnStokAzalt = new Button();
            txtAra = new TextBox();
            btnAra = new Button();
            btnTumListe = new Button();
            btnGeri = new Button();
            btnCikis = new Button();
            btnUrunGecmisi = new Button();
            lblKullaniciTipi = new Label();
            btnFiyatGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo3;
            pictureBoxLogo.Location = new Point(20, 20);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(180, 124);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(250, 70);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(920, 350);
            dgvUrunler.TabIndex = 0;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(20, 150);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(180, 40);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(20, 196);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(180, 40);
            btnUrunSil.TabIndex = 2;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(20, 242);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(180, 40);
            btnUrunGuncelle.TabIndex = 3;
            btnUrunGuncelle.Text = "Ürün Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnStokArtir
            // 
            btnStokArtir.Location = new Point(22, 288);
            btnStokArtir.Name = "btnStokArtir";
            btnStokArtir.Size = new Size(180, 40);
            btnStokArtir.TabIndex = 4;
            btnStokArtir.Text = "Stok Artır";
            btnStokArtir.UseVisualStyleBackColor = true;
            btnStokArtir.Click += btnStokArtir_Click;
            // 
            // btnStokAzalt
            // 
            btnStokAzalt.Location = new Point(20, 334);
            btnStokAzalt.Name = "btnStokAzalt";
            btnStokAzalt.Size = new Size(180, 40);
            btnStokAzalt.TabIndex = 5;
            btnStokAzalt.Text = "Stok Azalt";
            btnStokAzalt.UseVisualStyleBackColor = true;
            btnStokAzalt.Click += btnStokAzalt_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(250, 30);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(240, 23);
            txtAra.TabIndex = 6;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(500, 28);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(100, 30);
            btnAra.TabIndex = 7;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnTumListe
            // 
            btnTumListe.Location = new Point(610, 28);
            btnTumListe.Name = "btnTumListe";
            btnTumListe.Size = new Size(150, 30);
            btnTumListe.TabIndex = 8;
            btnTumListe.Text = "Tüm Listeden Ara";
            btnTumListe.UseVisualStyleBackColor = true;
            btnTumListe.Click += btnTumListe_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(22, 380);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(180, 40);
            btnGeri.TabIndex = 9;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(990, 426);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(180, 40);
            btnCikis.TabIndex = 10;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnUrunGecmisi
            // 
            btnUrunGecmisi.Location = new Point(436, 426);
            btnUrunGecmisi.Name = "btnUrunGecmisi";
            btnUrunGecmisi.Size = new Size(240, 40);
            btnUrunGecmisi.TabIndex = 11;
            btnUrunGecmisi.Text = "Ürün Geçmişi";
            btnUrunGecmisi.UseVisualStyleBackColor = true;
            btnUrunGecmisi.Click += btnUrunGecmisi_Click;
            // 
            // lblKullaniciTipi
            // 
            lblKullaniciTipi.AutoSize = true;
            lblKullaniciTipi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKullaniciTipi.Location = new Point(950, 20);
            lblKullaniciTipi.Name = "lblKullaniciTipi";
            lblKullaniciTipi.Size = new Size(61, 21);
            lblKullaniciTipi.TabIndex = 12;
            lblKullaniciTipi.Text = "Admin";
            // 
            // btnFiyatGuncelle
            // 
            btnFiyatGuncelle.Location = new Point(250, 426);
            btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            btnFiyatGuncelle.Size = new Size(180, 40);
            btnFiyatGuncelle.TabIndex = 13;
            btnFiyatGuncelle.Text = "Fiyat Güncelle";
            btnFiyatGuncelle.UseVisualStyleBackColor = true;
            btnFiyatGuncelle.Click += btnFiyatGuncelle_Click;
            // 
            // UrunIslemleriFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1200, 500);
            Controls.Add(pictureBoxLogo);
            Controls.Add(dgvUrunler);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnStokArtir);
            Controls.Add(btnStokAzalt);
            Controls.Add(txtAra);
            Controls.Add(btnAra);
            Controls.Add(btnTumListe);
            Controls.Add(btnGeri);
            Controls.Add(btnCikis);
            Controls.Add(btnUrunGecmisi);
            Controls.Add(lblKullaniciTipi);
            Controls.Add(btnFiyatGuncelle);
            Name = "UrunIslemleriFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün İşlemleri";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
