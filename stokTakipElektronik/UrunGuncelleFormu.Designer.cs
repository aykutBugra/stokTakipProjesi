namespace stokTakipElektronik
{
    partial class UrunGuncelleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKilif;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKilif;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.PictureBox logoPictureBox;

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
            txtUrunAdi = new System.Windows.Forms.TextBox();
            txtAciklama = new System.Windows.Forms.TextBox();
            txtFiyat = new System.Windows.Forms.TextBox();
            txtKilif = new System.Windows.Forms.TextBox();
            txtStokMiktari = new System.Windows.Forms.TextBox();
            btnGuncelle = new System.Windows.Forms.Button();
            lblUrunAdi = new System.Windows.Forms.Label();
            lblAciklama = new System.Windows.Forms.Label();
            lblFiyat = new System.Windows.Forms.Label();
            lblKilif = new System.Windows.Forms.Label();
            lblStokMiktari = new System.Windows.Forms.Label();
            logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(logoPictureBox)).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Font = new System.Drawing.Font("Arial", 12F);
            txtUrunAdi.Location = new System.Drawing.Point(37, 39);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new System.Drawing.Size(263, 26);
            txtUrunAdi.TabIndex = 0;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new System.Drawing.Font("Arial", 12F);
            txtAciklama.Location = new System.Drawing.Point(36, 98);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new System.Drawing.Size(263, 26);
            txtAciklama.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new System.Drawing.Font("Arial", 12F);
            txtFiyat.Location = new System.Drawing.Point(36, 157);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new System.Drawing.Size(263, 26);
            txtFiyat.TabIndex = 2;
            // 
            // txtKilif
            // 
            txtKilif.Font = new System.Drawing.Font("Arial", 12F);
            txtKilif.Location = new System.Drawing.Point(36, 219);
            txtKilif.Name = "txtKilif";
            txtKilif.Size = new System.Drawing.Size(263, 26);
            txtKilif.TabIndex = 3;
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Font = new System.Drawing.Font("Arial", 12F);
            txtStokMiktari.Location = new System.Drawing.Point(37, 282);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new System.Drawing.Size(263, 26);
            txtStokMiktari.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new System.Drawing.Font("Arial", 12F);
            btnGuncelle.Location = new System.Drawing.Point(36, 338);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(262, 38);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += new System.EventHandler(btnGuncelle_Click);
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Font = new System.Drawing.Font("Arial", 12F);
            lblUrunAdi.Location = new System.Drawing.Point(37, 20);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new System.Drawing.Size(70, 18);
            lblUrunAdi.TabIndex = 4;
            lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new System.Drawing.Font("Arial", 12F);
            lblAciklama.Location = new System.Drawing.Point(36, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new System.Drawing.Size(76, 18);
            lblAciklama.TabIndex = 3;
            lblAciklama.Text = "Açıklama:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new System.Drawing.Font("Arial", 12F);
            lblFiyat.Location = new System.Drawing.Point(36, 138);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new System.Drawing.Size(41, 18);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "Fiyat:";
            // 
            // lblKilif
            // 
            lblKilif.AutoSize = true;
            lblKilif.Font = new System.Drawing.Font("Arial", 12F);
            lblKilif.Location = new System.Drawing.Point(36, 200);
            lblKilif.Name = "lblKilif";
            lblKilif.Size = new System.Drawing.Size(36, 18);
            lblKilif.TabIndex = 1;
            lblKilif.Text = "Kılıf:";
            // 
            // lblStokMiktari
            // 
            lblStokMiktari.AutoSize = true;
            lblStokMiktari.Font = new System.Drawing.Font("Arial", 12F);
            lblStokMiktari.Location = new System.Drawing.Point(37, 263);
            lblStokMiktari.Name = "lblStokMiktari";
            lblStokMiktari.Size = new System.Drawing.Size(94, 18);
            lblStokMiktari.TabIndex = 0;
            lblStokMiktari.Text = "Stok Miktarı:";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            logoPictureBox.Image = global::stokTakipElektronik.Properties.Resources.logo3;
            logoPictureBox.Location = new System.Drawing.Point(340, 38);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new System.Drawing.Size(350, 356);
            logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 6;
            logoPictureBox.TabStop = false;
            // 
            // UrunGuncelleFormu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(684, 469);
            Controls.Add(lblStokMiktari);
            Controls.Add(lblKilif);
            Controls.Add(lblFiyat);
            Controls.Add(lblAciklama);
            Controls.Add(lblUrunAdi);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtAciklama);
            Controls.Add(txtFiyat);
            Controls.Add(txtKilif);
            Controls.Add(txtStokMiktari);
            Controls.Add(btnGuncelle);
            Controls.Add(logoPictureBox);
            Name = "UrunGuncelleFormu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ürün Güncelle";
            ((System.ComponentModel.ISupportInitialize)(logoPictureBox)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
