using System;
using System.Reflection.Metadata;

namespace Tugas1_PBO
{
    // Ini Super Class
    class Kendaraan
    {
        // Ini Atribut
        protected string merk;
        protected string jenis;
        protected int tahun;
        protected double harga;

        // Ini Konstruktor
        public Kendaraan(string merk, string jenis, int tahun, double harga)
        {
            this.merk = merk;
            this.jenis = jenis;
            this.tahun = tahun;
            this.harga = harga;
        }
        /* Method untuk menampilkan atribut dan output dari Class OtoMobil
             Virtual agar dapat digunakan juga oleh subclass nya*/
        public virtual void info()
        {
            Console.WriteLine($"> Jenis: {jenis}\n> Merek: {merk}\n> Tahun: {tahun}\n> Harga: {harga} Juta");
        }
    }
    // Ini SubClass
    class OtoMobil : Kendaraan
    {
        // Ini Atribut
        private int jumlah_kursi;
        private string tipe_transmisi;

        // Ini Konstruktor
        public OtoMobil(string merk, string jenis, int tahun, double harga, int jumlah_kursi, string tipe_transmisi)
            : base(merk, jenis, tahun, harga)
        {
            this.jumlah_kursi = jumlah_kursi;
            this.tipe_transmisi = tipe_transmisi;
        }
        /* Method untuk menampilkan atribut dan output dari SubClass Otomobil
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass Kendaraan*/
        public override void info()
        {
            Console.WriteLine();
            base.info();
            Console.WriteLine($"Dengan jumlah kursi sebanyak {jumlah_kursi} dan Tipe Transmisi {tipe_transmisi}");
        }
    }
    // Memulai Program
    class Program
    {
        public static void Main()
        {
            // Membuat Header buat hiasan doank kok :D
            Console.Write("############### Informasi OtoMobil ############### ");
            /* Membuat Instance dari Class RekeningBank
             Atau bisa disebut variable yang mereferensikan new object dari class tertera
             Atau lebih simple nya membuat object baru dari Class terte ntu
             Properti dan metode didefinisikan dari Class yang direferensikan*/
            OtoMobil sedan = new OtoMobil("Toyota", "Sedan", 2021, 350, 5, "Otomatis");
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            sedan.info();
        }
    }
}
