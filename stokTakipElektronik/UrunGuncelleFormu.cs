using System;
using System.Windows.Forms;
using Npgsql;
using System.Drawing;

namespace stokTakipElektronik
{
    public partial class UrunGuncelleFormu : Form
    {
        private int _urunId;
        private UrunIslemleriFormu _urunIslemleriFormu;

        public UrunGuncelleFormu(int urunId, UrunIslemleriFormu urunIslemleriFormu, int kategoriId)
        {
            InitializeComponent();
            _urunId = urunId;
            _urunIslemleriFormu = urunIslemleriFormu;
            LoadUrunBilgileri();
            LoadCategoryImage(kategoriId);
        }

        private void LoadUrunBilgileri()
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT urunadi, aciklama, fiyat, kilif, stokmiktari FROM urunler WHERE urunid = @urunId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@urunId", _urunId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUrunAdi.Text = reader.GetString(0);
                                txtAciklama.Text = reader.GetString(1);
                                txtFiyat.Text = reader.GetDecimal(2).ToString();
                                txtKilif.Text = reader.GetString(3);
                                txtStokMiktari.Text = reader.GetInt32(4).ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCategoryImage(int kategoriId)
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

            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    logoPictureBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE urunler SET urunadi = @urunAdi, aciklama = @aciklama, fiyat = @fiyat, kilif = @kilif, stokmiktari = @stokMiktari WHERE urunid = @urunId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                        command.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                        command.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
                        command.Parameters.AddWithValue("@kilif", txtKilif.Text);
                        command.Parameters.AddWithValue("@stokMiktari", int.Parse(txtStokMiktari.Text));
                        command.Parameters.AddWithValue("@urunId", _urunId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _urunIslemleriFormu.LoadSingleProduct(_urunId);
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
