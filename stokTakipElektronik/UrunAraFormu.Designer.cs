namespace stokTakipElektronik
{
    partial class UrunAraFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvAramaSonuclari;

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
            txtArama = new System.Windows.Forms.TextBox();
            btnAra = new System.Windows.Forms.Button();
            dgvAramaSonuclari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAramaSonuclari).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.Location = new System.Drawing.Point(20, 20);
            txtArama.Name = "txtArama";
            txtArama.Size = new System.Drawing.Size(250, 23);
            txtArama.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.Location = new System.Drawing.Point(280, 20);
            btnAra.Name = "btnAra";
            btnAra.Size = new System.Drawing.Size(75, 23);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += new System.EventHandler(btnAra_Click);
            // 
            // dgvAramaSonuclari
            // 
            dgvAramaSonuclari.Location = new System.Drawing.Point(20, 60);
            dgvAramaSonuclari.Name = "dgvAramaSonuclari";
            dgvAramaSonuclari.ReadOnly = true;
            dgvAramaSonuclari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAramaSonuclari.Size = new System.Drawing.Size(600, 400);
            dgvAramaSonuclari.TabIndex = 2;
            dgvAramaSonuclari.AutoGenerateColumns = true;
            // 
            // UrunAraFormu
            // 
            ClientSize = new System.Drawing.Size(634, 511);
            Controls.Add(txtArama);
            Controls.Add(btnAra);
            Controls.Add(dgvAramaSonuclari);
            Name = "UrunAraFormu";
            Text = "Ürün Arama";
            ((System.ComponentModel.ISupportInitialize)dgvAramaSonuclari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
