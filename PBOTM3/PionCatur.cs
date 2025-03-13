using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class PionCatur
    {
        // Ini Atribut
        protected string jenis;
        protected int jumlah;
        protected int max_gerakan;
        protected bool promosi_pion;

        // Ini Konstruktor
        public PionCatur(string jenis,int jumlah,int max_gerakan, bool promosi_pion)
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
    class PionHitam : PionCatur
    {
        // Ini Atribut
        private bool lemah;
        private string warna;

        // Ini Konstruktor
        public PionHitam(string jenis, int jumlah, int max_gerakan, bool promosi_pion,bool lemah,string warna)
            : base(jenis,jumlah,max_gerakan,promosi_pion)
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
    class PionPutih : PionCatur
    {
        // Ini Atribut
        private bool lemah;
        private string warna;

        // Ini Konstruktor
        public PionPutih(string jenis, int jumlah, int max_gerakan, bool promosi_pion, bool lemah, string warna)
            : base(jenis, jumlah, max_gerakan, promosi_pion)
        {
            this.lemah = lemah;
            this.warna = warna;
        }

        // Private method dari class PionPutih
        private string karakteristik_pion()
        {
            return $"Bersifat lemah = {lemah} dan berwarna default {warna}";
        }
        /* Method untuk menampilkan atribut dan output dari Class PionPutih
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
            PionCatur catur = new PionCatur("Bidak Pion",8,1,true);
            PionHitam hitam = new PionHitam("Pion Hitam",8,1,true,true,"Hitam");
            PionPutih putih = new PionPutih("Pion Putih", 8, 1, true,false, "Putih");
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            catur.informasi_pion();
            hitam.informasi_pion();
            putih.informasi_pion();
        }
    }
}
