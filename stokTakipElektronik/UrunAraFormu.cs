using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class UrunAraFormu : Form
    {
        private readonly int _kategoriId;

        public UrunAraFormu(int kategoriId)
        {
            InitializeComponent();
            _kategoriId = kategoriId;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text;
            if (string.IsNullOrEmpty(aramaMetni))
            {
                MessageBox.Show("Arama metni boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT urunid, urunadi, kategoriid, aciklama, stokmiktari, fiyat, kilif 
                FROM urunler 
                WHERE kategoriid = @kategoriid 
                AND (
                    urunadi ILIKE @AramaMetni
                    OR aciklama ILIKE @AramaMetni
                    OR kilif ILIKE @AramaMetni
                    OR CAST(fiyat AS TEXT) ILIKE @AramaMetni
                    OR CAST(stokmiktari AS TEXT) ILIKE @AramaMetni)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kategoriid", _kategoriId);
                        command.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni.Trim() + "%");

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable aramaSonuclari = new DataTable();
                            adapter.Fill(aramaSonuclari);

                            if (aramaSonuclari.Rows.Count == 0)
                            {
                                MessageBox.Show("Aradığınız kriterlere uygun sonuç bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dgvAramaSonuclari.DataSource = aramaSonuclari;
                            dgvAramaSonuclari.AutoGenerateColumns = true;
                        }
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
