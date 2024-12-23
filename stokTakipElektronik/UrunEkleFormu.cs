using System;
using System.Windows.Forms;
using Npgsql;
using System.Drawing;

namespace stokTakipElektronik
{
    public partial class UrunEkleFormu : Form
    {
        private int _kategoriId;

        public UrunEkleFormu(int kategoriId)
        {
            InitializeComponent();
            _kategoriId = kategoriId;
            this.Load += new EventHandler(UrunEkleFormu_Load);
        }

        private void UrunEkleFormu_Load(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "Ürün adı giriniz";
            txtAciklama.Text = "Açıklama giriniz";
            txtFiyat.Text = "0.00";
            txtKilif.Text = "Kılıf giriniz";
            txtStokMiktari.Text = "0";
            LoadKategoriResmi(_kategoriId);
        }

        private void LoadKategoriResmi(int kategoriId)
        {
            string imagePath = string.Empty;
            switch (kategoriId)
            {
                case 1:
                    imagePath = "images/opto.png";
                    break;
                case 2:
                    imagePath = "images/kondansatör.png";
                    break;
                case 3:
                    imagePath = "images/direnç.png";
                    break;
                case 4:
                    imagePath = "images/bobin.png";
                    break;
                case 5:
                    imagePath = "images/transistör.png";
                    break;
                case 6:
                    imagePath = "images/mosfet.png";
                    break;
                case 7:
                    imagePath = "images/regülatör.png";
                    break;
                case 8:
                    imagePath = "images/diğer komponentler.png";
                    break;
                default:
                    imagePath = "images/default.png";
                    break;
            }

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                logoPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO urunler (urunadi, aciklama, fiyat, kilif, stokmiktari, kategoriid) " +
                                   "VALUES (@urunadi, @aciklama, @fiyat, @kilif, @stokmiktari, @kategoriid)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text.Trim());
                        command.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());
                        command.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text.Trim()));
                        command.Parameters.AddWithValue("@kilif", txtKilif.Text.Trim());
                        command.Parameters.AddWithValue("@stokmiktari", int.Parse(txtStokMiktari.Text.Trim()));
                        command.Parameters.AddWithValue("@kategoriid", _kategoriId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
