namespace stokTakipElektronik
{
    partial class UrunSilFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUrunBilgisi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvUrunler;

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
            lblUrunBilgisi = new System.Windows.Forms.Label();
            btnSil = new System.Windows.Forms.Button();
            dgvUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // lblUrunBilgisi
            // 
            lblUrunBilgisi.AutoSize = true;
            lblUrunBilgisi.Location = new System.Drawing.Point(20, 20);
            lblUrunBilgisi.Name = "lblUrunBilgisi";
            lblUrunBilgisi.Size = new System.Drawing.Size(123, 15);
            lblUrunBilgisi.TabIndex = 0;
            lblUrunBilgisi.Text = "Seçilen ürün silinecek.";
            // 
            // btnSil
            // 
            btnSil.Location = new System.Drawing.Point(20, 50);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(100, 30);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += new System.EventHandler(btnUrunSil_Click);
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new System.Drawing.Point(20, 100);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new System.Drawing.Size(600, 300);
            dgvUrunler.TabIndex = 3;
            // 
            // UrunSilFormu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 450);
            Controls.Add(dgvUrunler);
            Controls.Add(btnSil);
            Controls.Add(lblUrunBilgisi);
            Name = "UrunSilFormu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ürün Sil";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
