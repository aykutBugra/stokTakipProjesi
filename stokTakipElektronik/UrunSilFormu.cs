using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class UrunSilFormu : Form
    {
        private int _urunId;
        private int _selectedKategoriId;

        public UrunSilFormu(int urunId, int kategoriId)
        {
            InitializeComponent();
            _urunId = urunId;
            _selectedKategoriId = kategoriId;

            LoadProductsByCategory();
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

                        // stok_log tablosunda kayıtlar varsa bunları da silmek istiyorsanız benzer sorgular yapabilirsiniz.
                        // Aşağıdaki örnek sadece urunler tablosundan siliyor.

                        string deleteProductQuery = "DELETE FROM urunler WHERE urunid = @urunId";
                        using (var deleteProductCommand = new NpgsqlCommand(deleteProductQuery, connection))
                        {
                            deleteProductCommand.Parameters.AddWithValue("@urunId", urunId);
                            deleteProductCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (DataGridViewRow row in dgvUrunler.SelectedRows)
                        {
                            dgvUrunler.Rows.Remove(row);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün silinemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadProductsByCategory()
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT urunid, urunadi, aciklama, kilif, fiyat, stokmiktari, kategoriid FROM urunler WHERE kategoriid = @kategoriId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kategoriId", _selectedKategoriId);

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable urunlerTable = new DataTable();
                            adapter.Fill(urunlerTable);
                            dgvUrunler.DataSource = urunlerTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategoriye ait ürünler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
