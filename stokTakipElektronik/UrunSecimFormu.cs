using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class UrunSecimFormu : Form
    {
        private string _kullaniciTipi;

        public UrunSecimFormu(string kullaniciTipi)
        {
            InitializeComponent();
            _kullaniciTipi = kullaniciTipi;
            LoadKategoriler();
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

        private void LoadKategoriler()
        {
            comboBoxKategoriler.Items.Clear();
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT kategoriid, kategoriadi FROM kategoriler";
                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        var kategoriListesi = new List<KeyValuePair<int, string>>();
                        while (reader.Read())
                        {
                            kategoriListesi.Add(new KeyValuePair<int, string>(
                                reader.GetInt32(0), reader.GetString(1)));
                        }

                        comboBoxKategoriler.DataSource = kategoriListesi;
                        comboBoxKategoriler.DisplayMember = "Value";  // Görüntülenecek kısım
                        comboBoxKategoriler.ValueMember = "Key";      // Arka planda tutulan değer
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategoriler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKategoriler.SelectedItem is KeyValuePair<int, string> selectedCategory)
            {
                // Seçilen kategoriye uygun görseli yükle
                string imagePath = Path.Combine(Application.StartupPath, "images", $"{selectedCategory.Value.ToLower()}.png");
                if (File.Exists(imagePath))
                {
                    pictureBox3.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox3.Image = null;
                    MessageBox.Show($"Bu kategoriye ait görsel bulunamadı. Beklenen dosya: {selectedCategory.Value.ToLower()}.png", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoriler.SelectedItem is KeyValuePair<int, string> selectedCategory)
            {
                UrunIslemleriFormu urunIslemleriFormu = new UrunIslemleriFormu(selectedCategory.Key, _kullaniciTipi);
                this.Hide();
                urunIslemleriFormu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}