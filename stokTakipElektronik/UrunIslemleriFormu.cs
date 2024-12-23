using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class UrunIslemleriFormu : Form
    {
        private string _kullaniciTipi;
        private int _selectedKategoriId;
        private static UrunSecimFormu urunSecimFormInstance = null;

        public UrunIslemleriFormu(int selectedKategoriId, string kullaniciTipi)
        {
            InitializeComponent();
            _kullaniciTipi = kullaniciTipi;
            _selectedKategoriId = selectedKategoriId;
            ConfigureButtons();
            LoadUrunListesi(_selectedKategoriId);
        }

        private void ConfigureButtons()
        {
            if (_kullaniciTipi == "kullanici")
            {
                btnUrunEkle.Visible = false;
                btnUrunSil.Visible = false;
                btnUrunGuncelle.Visible = false;
                btnUrunGecmisi.Visible = false;
                lblKullaniciTipi.Text = "Kullanıcı İşlemleri";
                // Fiyat Güncelle butonu her iki kullanıcı tipine de açık
            }
            else if (_kullaniciTipi == "admin")
            {
                lblKullaniciTipi.Text = "Admin İşlemleri";
            }

            lblKullaniciTipi.Visible = true;
        }

        public void LoadUrunListesi(int kategoriId = -1)
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query;

                    if (kategoriId > -1)
                    {
                        query = "SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid FROM urunler WHERE kategoriid = @kategoriId";
                    }
                    else
                    {
                        query = "SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid FROM urunler";
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (kategoriId > -1)
                        {
                            command.Parameters.AddWithValue("@kategoriId", kategoriId);
                        }

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable urunlerTable = new DataTable();
                            adapter.Fill(urunlerTable);
                            dgvUrunler.DataSource = urunlerTable;
                            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün listesi yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtAra.Text.Trim(); // Kullanıcının girdiği arama metni
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Sadece seçilen kategoriye göre arama yapacak sorgu
                        string query = @"
                SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid
                FROM urunler
                WHERE kategoriid = @kategoriId AND 
                (
                    urunadi ILIKE @keyword OR 
                    aciklama ILIKE @keyword OR 
                    kilif ILIKE @keyword OR 
                    CAST(fiyat AS TEXT) ILIKE @keyword OR 
                    CAST(stokmiktari AS TEXT) ILIKE @keyword
                )";

                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            // Seçilen kategori ID'sini filtre olarak ekliyoruz
                            command.Parameters.AddWithValue("@kategoriId", _selectedKategoriId);
                            command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");

                            using (var adapter = new NpgsqlDataAdapter(command))
                            {
                                DataTable searchResults = new DataTable();
                                adapter.Fill(searchResults); // Arama sonuçlarını doldur
                                dgvUrunler.DataSource = searchResults; // Sonuçları DataGrid'e bağla
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Arama işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arama metni boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btnTumListe_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtAra.Text.Trim(); // Arama kutusundan gelen değer
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid
                FROM urunler";

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += @"
                    WHERE 
                        urunadi ILIKE @keyword OR 
                        aciklama ILIKE @keyword OR 
                        kilif ILIKE @keyword OR 
                        CAST(fiyat AS TEXT) ILIKE @keyword OR 
                        CAST(stokmiktari AS TEXT) ILIKE @keyword";
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchKeyword))
                        {
                            command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");
                        }

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable tumUrunler = new DataTable();
                            adapter.Fill(tumUrunler);
                            dgvUrunler.DataSource = tumUrunler;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (_selectedKategoriId > 0)
            {
                UrunEkleFormu urunEkleFormu = new UrunEkleFormu(_selectedKategoriId);
                urunEkleFormu.ShowDialog();
                LoadUrunListesi(_selectedKategoriId);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir kategori seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urunid"].Value);
                using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM urunler WHERE urunid = @urunId";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@urunId", urunId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Ürün silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUrunListesi(_selectedKategoriId);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün silinemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urunid"].Value);
                int kategoriId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["kategoriid"].Value);
                UrunGuncelleFormu urunGuncelleFormu = new UrunGuncelleFormu(urunId, this, kategoriId);
                urunGuncelleFormu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStokArtir_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urunid"].Value);
                UpdateStok(urunId, 1);
            }
        }

        private void btnStokAzalt_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urunid"].Value);
                UpdateStok(urunId, -1);
            }
        }

        private void UpdateStok(int urunId, int miktar)
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE urunler SET stokmiktari = stokmiktari + @miktar WHERE urunid = @urunId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@miktar", miktar);
                        command.Parameters.AddWithValue("@urunId", urunId);
                        command.ExecuteNonQuery();
                    }
                    LoadUrunListesi(_selectedKategoriId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok güncellenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadSingleProduct(int urunId)
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid FROM urunler WHERE urunid = @urunId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@urunId", urunId);
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable urunTable = new DataTable();
                            adapter.Fill(urunTable);
                            dgvUrunler.DataSource = urunTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün bilgisi yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUrunGecmisi_Click(object sender, EventArgs e)
        {
            UrunGecmisiFormu urunGecmisiFormu = new UrunGecmisiFormu();
            urunGecmisiFormu.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            if (urunSecimFormInstance == null || urunSecimFormInstance.IsDisposed)
            {
                urunSecimFormInstance = new UrunSecimFormu(_kullaniciTipi);
            }
        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urunid"].Value);
                string yeniFiyatStr = Microsoft.VisualBasic.Interaction.InputBox("Yeni fiyatı giriniz:", "Fiyat Güncelle", "0.00");
                if (!string.IsNullOrEmpty(yeniFiyatStr))
                {
                    decimal yeniFiyat = decimal.Parse(yeniFiyatStr);
                    using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
                    {
                        connection.Open();
                        string query = "UPDATE urunler SET fiyat = @fiyat WHERE urunid = @urunId";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@fiyat", yeniFiyat);
                            command.Parameters.AddWithValue("@urunId", urunId);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadSingleProduct(urunId);
                }
            }
            else
            {
                MessageBox.Show("Fiyat güncellemek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
