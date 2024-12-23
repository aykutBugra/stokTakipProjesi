using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stokTakipElektronik
{
    public partial class TumListedenAraForm : Form
    {
        public TumListedenAraForm()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();
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
                WHERE urunadi ILIKE @aramaMetni 
                   OR aciklama ILIKE @aramaMetni 
                   OR kilif ILIKE @aramaMetni 
                   OR CAST(stokmiktari AS TEXT) ILIKE @aramaMetni 
                   OR CAST(fiyat AS TEXT) ILIKE @aramaMetni";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@aramaMetni", "%" + aramaMetni + "%");

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable aramaSonuclari = new DataTable();
                            adapter.Fill(aramaSonuclari);

                            // Sonuçları kontrol etmek için:
                            if (aramaSonuclari.Rows.Count > 0)
                            {
                                dgvSonuc.DataSource = aramaSonuclari;
                                dgvSonuc.AutoGenerateColumns = true;
                            }
                            else
                            {
                                MessageBox.Show("Arama sonucunda eşleşme bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSonuc.DataSource = null; // Tabloyu temizle
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

    }
}
