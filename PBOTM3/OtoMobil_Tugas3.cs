using System;
using System.Reflection.Metadata;

namespace Tugas1_PBO
{
    // Ini Super Class
    class OtoMobil
    {
        // Ini Atribut
        protected string merk;
        protected string jenis;
        protected int tahun;
        protected double harga;

        // Ini Konstruktor
        public OtoMobil(string merk,string jenis,int tahun,double harga)
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
    class Sedan : OtoMobil
    {
        // Ini Atribut
        private int jumlah_kursi;
        private string tipe_transmisi;

        // Ini Konstruktor
        public Sedan(string merk, string jenis, int tahun, double harga,int jumlah_kursi,string tipe_transmisi)
            : base(merk,jenis,tahun,harga)
        {
            this.jumlah_kursi = jumlah_kursi;
            this.tipe_transmisi = tipe_transmisi;
        }
        /* Method untuk menampilkan atribut dan output dari SubClass Sedan
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass OtoMobil*/
        public override void info()
        {
            Console.WriteLine();
            base.info();
            Console.WriteLine($"Dengan jumlah kursi sebanyak {jumlah_kursi} dan Tipe Transmisi {tipe_transmisi}");
        }
    }
    class Truk : OtoMobil
    {
        // Ini Atribut
        private double kapasitas_muatan;
        private int jumlah_roda;

        // Ini Konstruktor
        public Truk(string merk, string jenis, int tahun, double harga, double kapasitas_muatan, int jumlah_roda)
            : base(merk, jenis, tahun, harga)
        {
            this.kapasitas_muatan = kapasitas_muatan;
            this.jumlah_roda = jumlah_roda;
        }
        /* Method untuk menampilkan atribut dan output dari SubClass Truk
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass OtoMobil*/
        public override void info()
        {
            Console.WriteLine();
            base.info();
            Console.WriteLine($"Dengan Kapasitas Muatan sebanyak {kapasitas_muatan} ton dan Jumlah Roda {jumlah_roda}");
        }
    }
    class SepedaMotor : OtoMobil
    {
        // Ini Atribut
        private string jenis_motor;
        private double kapasitas_tangki;

        // Ini Konstruktor
        public SepedaMotor(string merk, string jenis, int tahun, double harga, string jenis_motor, double kapasitas_tangki)
            : base(merk, jenis, tahun, harga)
        {
            this.jenis_motor = jenis_motor;
            this.kapasitas_tangki = kapasitas_tangki;
        }
        /* Method untuk menampilkan atribut dan output dari SubClass SepedaMotor
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass OtoMobil*/
        public override void info()
        {
            Console.WriteLine();
            base.info();
            Console.WriteLine($"Jenis Motornya adalah {jenis_motor} dengan Kapasitas Tangki {kapasitas_tangki} liter");
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
            Sedan sedan = new Sedan("Toyota", "Sedan", 2021, 350, 5, "Otomatis");
            Truk truk = new Truk("Hino", "Truk", 2018, 700, 10, 6);
            SepedaMotor motor = new SepedaMotor("Honda", "Sepeda Motor", 2023, 25, "Matic", 5);
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            sedan.info();
            truk.info();
            motor.info();
        }
    }
}
