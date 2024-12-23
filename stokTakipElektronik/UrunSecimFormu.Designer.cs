namespace stokTakipElektronik
{
    partial class UrunSecimFormu
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox2; // Sol taraftaki logo
        private Panel kategoriPanel; // ComboBox ve buton için panel
        private Label lblKategoriSecim; // Panel üstündeki başlık
        private ComboBox comboBoxKategoriler;
        private Button btnSec;
        private PictureBox pictureBox3; // Kategori görselleri

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
            pictureBox2 = new PictureBox();
            kategoriPanel = new Panel();
            lblKategoriSecim = new Label();
            comboBoxKategoriler = new ComboBox();
            btnSec = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            kategoriPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo32;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 506);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // kategoriPanel
            // 
            kategoriPanel.BackColor = Color.LightSteelBlue;
            kategoriPanel.Controls.Add(lblKategoriSecim);
            kategoriPanel.Controls.Add(comboBoxKategoriler);
            kategoriPanel.Controls.Add(btnSec);
            kategoriPanel.Controls.Add(pictureBox3);
            kategoriPanel.Location = new Point(319, 0);
            kategoriPanel.Name = "kategoriPanel";
            kategoriPanel.Size = new Size(400, 506);
            kategoriPanel.TabIndex = 1;
            // 
            // lblKategoriSecim
            // 
            lblKategoriSecim.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblKategoriSecim.Location = new Point(27, 64);
            lblKategoriSecim.Name = "lblKategoriSecim";
            lblKategoriSecim.Size = new Size(200, 30);
            lblKategoriSecim.TabIndex = 0;
            lblKategoriSecim.Text = "Kategori Seçimi";
            // 
            // comboBoxKategoriler
            // 
            comboBoxKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKategoriler.FormattingEnabled = true;
            comboBoxKategoriler.Location = new Point(27, 104);
            comboBoxKategoriler.Name = "comboBoxKategoriler";
            comboBoxKategoriler.Size = new Size(250, 23);
            comboBoxKategoriler.TabIndex = 1;
            comboBoxKategoriler.SelectedIndexChanged += comboBoxKategoriler_SelectedIndexChanged;
            // 
            // btnSec
            // 
            btnSec.BackColor = Color.SteelBlue;
            btnSec.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSec.ForeColor = Color.White;
            btnSec.Location = new Point(287, 98);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(100, 30);
            btnSec.TabIndex = 2;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(27, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(360, 260);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // UrunSecimFormu
            // 
            ClientSize = new Size(718, 503);
            Controls.Add(pictureBox2);
            Controls.Add(kategoriPanel);
            Name = "UrunSecimFormu";
            Text = "Kategori Seçimi";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            kategoriPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }
    }
}
