using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class MobilSedan
    {
        // Ini Atribut
        protected string merk;
        protected int tahun;
        protected double harga;

        // Ini Konstruktor
        public MobilSedan(string merk, int tahun, double harga)
        {
            this.merk = merk;
            this.tahun = tahun;
            this.harga = harga;
        }
        /* Ini Method untuk menampilkan output dari atribut
            Virtual untuk diturunkan ke Sub Class*/
        public virtual void informasi_mobil()
        {
            Console.WriteLine($"> Merek: {merk}\n> Tahun keluaran: {tahun}\n> Harga Jual: {harga} Juta");
        }
    }
    // Ini Sub Class
    class MobilSport : MobilSedan
    {
        // Ini Atribut
        private bool turbo;

        // Ini Konstruktor
        public MobilSport(string merk,int tahun,double harga,bool turbo)
            : base(merk,tahun,harga)
        {
            this.turbo = turbo;
        }
        /* Ini Method untuk menampilkan atribut
            override untuk mengubah method dari Super Class di dalam Sub Class*/
        public override void informasi_mobil()
        {
            Console.WriteLine();
            base.informasi_mobil();
            Console.WriteLine("Mobil mempunyai fitur turbo = " + turbo);
        }
    }
    // Ini Sub Class Kedua
    class MobilListrik : MobilSedan
    {
        // Ini atribut
        private double kapasitas_baterai;

        // Ini Konstruktor
        public MobilListrik(string merk, int tahun, double harga,double kapasitas_baterai)
            : base(merk,tahun,harga)
        {
            this.kapasitas_baterai = kapasitas_baterai;
        }
        // Method Local
        private string battery()
        {
            return $"Kapasitas baterai = {kapasitas_baterai} kWh";
        }
        // Menampilkan output dari attribut
        public override void informasi_mobil()
        {
            Console.WriteLine();
            Console.WriteLine($"> Merek: {merk}\n> Tahun keluaran: {tahun}\n> Harga Jual: {harga} M");
            Console.WriteLine(battery());
        }
    }
    // Class untuk memanggil keseluruhan class dalam diagram class MobilSedan
    class Program
    {
        // Method yang dijalankan terlebih dahulu
        public static void Main()
        {
            Console.WriteLine("------------Informasi Mobil Sedan------------");
            MobilSedan mobil = new MobilSedan("Toyota Corolla",2015,250);
            MobilSport mobil2 = new MobilSport("BMW 320i",2020,900,true);
            MobilListrik mobil3 = new MobilListrik("Tesla",2022,1,100);

            mobil.informasi_mobil();
            mobil2.informasi_mobil();
            mobil3.informasi_mobil();
        }
    }
}
