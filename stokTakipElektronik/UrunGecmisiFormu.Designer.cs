namespace stokTakipElektronik
{
    partial class UrunGecmisiFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUrunGecmisi; // Logların gösterileceği DataGridView

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
            this.dgvUrunGecmisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunGecmisi
            // 
            this.dgvUrunGecmisi.AllowUserToAddRows = false;
            this.dgvUrunGecmisi.AllowUserToDeleteRows = false;
            this.dgvUrunGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunGecmisi.Location = new System.Drawing.Point(12, 12);
            this.dgvUrunGecmisi.Name = "dgvUrunGecmisi";
            this.dgvUrunGecmisi.ReadOnly = true;
            this.dgvUrunGecmisi.Size = new System.Drawing.Size(760, 437);
            this.dgvUrunGecmisi.TabIndex = 0;
            // 
            // UrunGecmisiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvUrunGecmisi);
            this.Name = "UrunGecmisiFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Geçmişi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGecmisi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
