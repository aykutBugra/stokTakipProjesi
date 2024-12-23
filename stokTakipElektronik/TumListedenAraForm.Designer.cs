namespace stokTakipElektronik
{
    partial class TumListedenAraForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvSonuc;

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
            txtArama = new TextBox();
            btnAra = new Button();
            dgvSonuc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.Location = new Point(20, 20);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(250, 23);
            txtArama.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(280, 20);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += BtnAra_Click;
            // 
            // dgvSonuc
            // 
            dgvSonuc.AllowUserToAddRows = false;
            dgvSonuc.AllowUserToDeleteRows = false;
            dgvSonuc.AllowUserToOrderColumns = true;
            dgvSonuc.AllowUserToResizeColumns = false;
            dgvSonuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonuc.Location = new Point(20, 60);
            dgvSonuc.Name = "dgvSonuc";
            dgvSonuc.ReadOnly = true;
            dgvSonuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonuc.Size = new Size(600, 400);
            dgvSonuc.TabIndex = 2;
            // 
            // TumListedenAraForm
            // 
            ClientSize = new Size(634, 511);
            Controls.Add(txtArama);
            Controls.Add(btnAra);
            Controls.Add(dgvSonuc);
            Name = "TumListedenAraForm";
            Text = "Tüm Listeden Arama";
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
