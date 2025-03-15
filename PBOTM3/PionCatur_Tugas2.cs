using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class Catur
    {
        // Ini Atribut
        protected string jenis;
        protected int jumlah;
        protected int max_gerakan;
        protected bool promosi_pion;

        // Ini Konstruktor
        public Catur(string jenis, int jumlah, int max_gerakan, bool promosi_pion)
        {
            this.jenis = jenis;
            this.jumlah = jumlah;
            this.max_gerakan = max_gerakan;
            this.promosi_pion = promosi_pion;
        }
        /* Method untuk menampilkan atribut dan output dari Class PionCatur
             Virtual agar dapat digunakan juga oleh subclass nya*/
        public virtual void informasi_pion()
        {
            Console.WriteLine($"> Jenis: {jenis}\n> Jumlah: {jumlah}\n> Maximal Gerakan: {max_gerakan}\n> Promosi Pion: {promosi_pion}");
        }
    }
    // Ini SubClass
    class PionCaturHitam : Catur
    {
        // Ini Atribut
        private bool lemah;
        private string warna;

        // Ini Konstruktor
        public PionCaturHitam(string jenis, int jumlah, int max_gerakan, bool promosi_pion, bool lemah, string warna)
            : base(jenis, jumlah, max_gerakan, promosi_pion)
        {
            this.lemah = lemah;
            this.warna = warna;
        }

        // Private method dari class PionHitam
        private string karakteristik_pion()
        {
            return $"Bersifat lemah = {lemah} dan berwarna default {warna}";
        }
        /* Method untuk menampilkan atribut dan output dari Class PionHitam
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass PionCatur*/
        public override void informasi_pion()
        {
            Console.WriteLine();
            base.informasi_pion();
            Console.WriteLine(karakteristik_pion());
        }
    }
    // Memulai Program
    class Program
    {
        public static void Main()
        {
            // Membuat Header buat hiasan doank kok :D
            Console.WriteLine("############### Informasi Pion Catur ############### ");
            /* Membuat Instance dari Class Ikan
             Atau bisa disebut variable yang mereferensikan new object dari class tertera
             Atau lebih simple nya membuat object baru dari Class tertentu
             Properti dan metode didefinisikan dari Class yang direferensikan*/
            Catur catur = new Catur("Bidak Pion", 8, 1, true);
            PionCaturHitam hitam = new PionCaturHitam("Pion Hitam", 8, 1, true, true, "Hitam");
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            catur.informasi_pion();
            hitam.informasi_pion();
        }
    }
}
