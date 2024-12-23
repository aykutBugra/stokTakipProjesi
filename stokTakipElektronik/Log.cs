namespace stokTakipElektronik
{
    public class Log
    {
        public int logid { get; set; }
        public int urunid { get; set; }
        public string urunadi { get; set; }
        public string kategoriadi { get; set; }
        public string islem_tipi { get; set; }
        public DateTime islem_tarihi { get; set; }
        public int? degisim_miktari { get; set; } // Stok değişimi olmadığında null olabilir

        public Log(int logid, int urunid, string urunadi, string kategoriadi, string islem_tipi, DateTime islem_tarihi, int? degisim_miktari)
        {
            this.logid = logid;
            this.urunid = urunid;
            this.urunadi = urunadi;
            this.kategoriadi = kategoriadi;
            this.islem_tipi = islem_tipi;
            this.islem_tarihi = islem_tarihi;
            this.degisim_miktari = degisim_miktari;
        }
    }
}
