using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class KullaniciGirisFormu : Form
    {
        public KullaniciGirisFormu()
        {
            InitializeComponent();
        }

        private void KullaniciGirisFormu_Load(object sender, EventArgs e)
        {
            // Dönen Çark GIF Yükleme
            string gifPath = Path.Combine(Application.StartupPath, "images", "donenCark.gif");
            if (File.Exists(gifPath))
            {
                pictureBox1.Image = Image.FromFile(gifPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent; // Arka plan şeffaf
            }

            // Logo Yükleme
            string logoPath = Path.Combine(Application.StartupPath, "images", "logo3.png");
            if (File.Exists(logoPath))
            {
                pictureBox2.Image = Image.FromFile(logoPath);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // Resim tam sığsın
                pictureBox2.Size = new Size(228, 454); // Boyut ayarı
                pictureBox2.Location = new Point(0, 0); // Konum ayarı
                pictureBox2.BackColor = Color.Transparent; // Arka plan şeffaf
            }
            else
            {
                MessageBox.Show("Logo dosyası bulunamadı: " + logoPath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kullanıcı Icon Yükleme
            string loginIconPath = Path.Combine(Application.StartupPath, "images", "login_22.png");
            if (File.Exists(loginIconPath))
            {
                pictureBox3.Image = Image.FromFile(loginIconPath);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom; // Resim tam sığsın
                pictureBox3.BackColor = Color.Transparent; // Arka plan şeffaf
            }
            else
            {
                MessageBox.Show("Login dosyası bulunamadı: " + loginIconPath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT kullanicitipi FROM kullanicilar WHERE kullaniciadi = @kullaniciAdi AND sifre = @sifre";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string kullaniciTipi = result.ToString();
                            if (kullaniciTipi == "admin")
                            {
                                var urunSecimForm = new UrunSecimFormu("admin");
                                this.Hide();
                                urunSecimForm.ShowDialog();
                                this.Show();
                            }
                            else if (kullaniciTipi == "kullanici")
                            {
                                var urunSecimForm = new UrunSecimFormu("kullanici");
                                this.Hide();
                                urunSecimForm.ShowDialog();
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(240, 248, 255), // Açık pastel mavi
                                                                       Color.FromArgb(210, 228, 255), // Daha koyu pastel mavi
                                                                       LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
