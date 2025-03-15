using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class Mobil
    {
        // Ini Atribut
        protected string merk;
        protected int tahun;
        protected double harga;

        // Ini Konstruktor
        public Mobil(string merk, int tahun, double harga)
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
    class MobilSedan : Mobil
    {
        // Ini Atribut
        private bool turbo;

        // Ini Konstruktor
        public MobilSedan(string merk, int tahun, double harga, bool turbo)
            : base(merk, tahun, harga)
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
    // Class untuk memanggil keseluruhan class dalam diagram class Mobil
    class Program
    {
        // Method yang dijalankan terlebih dahulu
        public static void Main()
        {
            Console.WriteLine("------------Informasi Mobil Sedan------------");
            MobilSedan mobil = new MobilSedan("Toyota Corolla", 2015, 250,false);
            mobil.informasi_mobil();
        }
    }
}
