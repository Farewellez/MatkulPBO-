using System;

namespace OnlineShop
{
    // Super Class
    class Produk
    {
        // field
        protected string nama;
        protected double harga;
        protected double ongkir;
        // konstruktor
        public Produk(string nama,double harga, double ongkir)
        {
            this.nama = nama;
            this.harga = harga;
            this.ongkir = ongkir;
        }
        // public method harga
        public double harga_produk()
        {
            return harga;
        }
        // method
        public double ongkos_kirim()
        {
            return ongkir;
        }
        // virtual method
        public virtual void informasi_produk()
        {
            Console.WriteLine($"Nama Produk: {nama}\nHarga Produk: {harga}");
        }
    }
    // Sub Class Barang Elektronik
    class BarangElektronik : Produk
    {
        // field
        private double berat;
        // konstruktor
        public BarangElektronik(string nama, double harga, double ongkir, double berat) : base(nama, harga, ongkir)
        {
            this.berat = berat;
        }
        // overriding
        public double ongkos_kirim()
        {
            return ongkir *= berat;
        }
        // overriding
        public override void informasi_produk()
        {
            base.informasi_produk();
            Console.WriteLine($"Dengan ongkos kirim: {ongkos_kirim()}\n");
        }
    }
    // Sub Class BajudanPakaian
    class BajudanPakaian : Produk
    {
        public BajudanPakaian(string nama, double harga, double ongkir) : base(nama, harga, ongkir)
        {
        }
        public double ongkos_kirim()
        {
            return ongkir;
        }
        public override void informasi_produk()
        {
            base.informasi_produk();
            Console.WriteLine($"Dengan ongkos kirim: {ongkos_kirim()}\n");
        }
    }
    // Sub Class BajudanPakaian
    class Buku : Produk
    {
        public Buku(string nama, double harga, double ongkir) : base(nama, harga, ongkir)
        {
        }
        public double ongkos_kirim()
        {
            return ongkir;
        }
        public override void informasi_produk()
        {
            base.informasi_produk();
            Console.WriteLine($"Dengan ongkos kirim: {ongkos_kirim()}\n");
        }
    }
    // program start/keranjang
    class Keranjang
    {
        // method daftar produk
        public void daftar_produk()
        {
            // pembuatan object dari class
            BarangElektronik elektro = new BarangElektronik("TV",12_0000_000,37_000,5);
            BajudanPakaian baju = new BajudanPakaian("Kemeja", 58_000, 12_0000);
            Buku buku = new Buku("Buku Harian Herta", 1000_000, 50_0000);
            // output
            Console.WriteLine("Informasi Produk:");
            elektro.informasi_produk();
            baju.informasi_produk();
            buku.informasi_produk();
        }
        // method total harga
        public void total_harga()
        {
            // pembuatan object dari class
            BarangElektronik elektro = new BarangElektronik("TV", 12_0000_000, 37_000, 5);
            BajudanPakaian baju = new BajudanPakaian("Kemeja", 58_000, 12_0000);
            Buku buku = new Buku("Buku Harian Herta", 1000_000, 50_0000);
            // membuat variabel untuk menyimpan nilai yang di return dari method class Barang Elektronik
            double harga_elektronik = elektro.harga_produk();
            double ongkir_elektronik = elektro.ongkos_kirim();
            double total_elektronik = harga_elektronik + ongkir_elektronik;
            // membuat variabel untuk menyimpan nilai yang di return dari method class Baju dan Pakaian
            double harga_pakaian = baju.harga_produk();
            double ongkir_pakaian = baju.ongkos_kirim();
            double total_pakaian = harga_pakaian + ongkir_pakaian;
            // membuat variabel untuk menyimpan nilai yang di return dari method class Buku
            double harga_buku = buku.harga_produk();
            double ongkir_buku = buku.ongkos_kirim();
            double total_buku = harga_buku + ongkir_buku;
            // output akhir
            Console.WriteLine($"---------------- Total Harga ----------------");
            Console.WriteLine($"Barang Elektronik:\nHarga + Ongkir = Rp.{total_elektronik}");
            Console.WriteLine($"Baju dan Pakaian:\nHarga + Ongkir = Rp.{total_pakaian}");
            Console.WriteLine($"Buku:\nHarga + Ongkir = Rp.{total_buku}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"Total Harga Produk: Rp.{total_elektronik + total_buku + total_pakaian}");
        }
    }
    class Program
    {
        static void Main()
        {
            Keranjang keranjang = new Keranjang();
            keranjang.daftar_produk();
            keranjang.total_harga();
        }
    }
}
