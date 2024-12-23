using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class UrunGecmisiFormu : Form
    {
        public UrunGecmisiFormu()
        {
            InitializeComponent();
            LoadUrunGecmisi();
        }

        private void LoadUrunGecmisi()
        {
            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
            SELECT 
                genel_log.logid AS ""Log ID"",
                genel_log.urunid AS ""Ürün ID"",
                urunler.urunadi AS ""Ürün Adı"",
                kategoriler.kategoriadi AS ""Kategori Adı"",
                genel_log.islem_tipi AS ""İşlem Tipi"",
                genel_log.islem_tarihi AS ""İşlem Tarihi"",
                genel_log.degisim_miktari AS ""Değişim Miktarı""
            FROM genel_log
            LEFT JOIN urunler ON genel_log.urunid = urunler.urunid
            LEFT JOIN kategoriler ON genel_log.kategoriid = kategoriler.kategoriid
            ORDER BY genel_log.islem_tarihi DESC;
        ";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        var dataAdapter = new NpgsqlDataAdapter(command);
                        var dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgvUrunGecmisi.DataSource = dataTable;
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
