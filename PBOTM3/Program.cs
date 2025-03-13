using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class Ikan
    {
        // Ini Atribut
        protected string nama_ikan;
        protected string habitat;
        protected string jenis_makanan;
        protected string cara_berkembangbiak;

        // Ini Konstruktor
        public Ikan(string nama_ikan,string habitat, string jenis_makanan, string cara_berkembangbiak)
        {
            this.nama_ikan = nama_ikan;
            this.habitat = habitat;
            this.jenis_makanan = jenis_makanan;
            this.cara_berkembangbiak = cara_berkembangbiak;
        }
        /* Method untuk menampilkan atribut dan output dari Class Ikan
             Virtual agar dapat digunakan juga oleh subclass nya*/
        public virtual void informasi_ikan()
        {
            Console.WriteLine($"> Nama Ikan: {nama_ikan}\n> Habitat: {habitat}\n> Jenis_Makanan: {jenis_makanan}\n> Cara_berkembangbiak: {cara_berkembangbiak}");
        }
    }
    // Ini SubClass
    class Hiu : Ikan
    {
        // Ini Atribut
        private bool berbahaya;
        private string jenis_hiu;

        // Ini Konstruktor
        public Hiu(string nama_ikan, string habitat, string jenis_makanan, string cara_berkembangbiak,
            bool berbahaya,string jenis_hiu) : base(nama_ikan,habitat,jenis_makanan,cara_berkembangbiak)
        {
            this.berbahaya = berbahaya;
            this.jenis_hiu = jenis_hiu;
        }

        // Private method dari class Hiu
        private string check_hiu()
        {
            return $"Hiu ini berbahaya = {berbahaya} dari jenis hiu {jenis_hiu}";
        }
        /* Method untuk menampilkan atribut dan output dari Class Hiu
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass Ikan*/
        public override void informasi_ikan()
        {
            Console.WriteLine();
            base.informasi_ikan();
            Console.WriteLine(check_hiu());
        }
    }
    class Paus : Ikan
    {
        // Ini Atribut
        private bool berbahaya;
        private string jenis_paus;

        // Ini Konstruktor
        public Paus(string nama_ikan, string habitat, string jenis_makanan, string cara_berkembangbiak, 
            bool berbahaya, string jenis_paus) : base(nama_ikan,habitat,jenis_makanan,cara_berkembangbiak)
        {
            this.berbahaya = berbahaya;
            this.jenis_paus = jenis_paus;
        }

        // Private Class Paus
        private string check_paus()
        {
            return $"Paus ini berbahaya = {berbahaya} dari jenis paus {jenis_paus}";
        }

        /* Method untuk menampilkan atribut dan output dari Class Hiu
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass Ikan*/
        public override void informasi_ikan()
        {
            Console.WriteLine();
            base.informasi_ikan();
            Console.WriteLine(check_paus());
        }
    }
    // Memulai Program
    class Program
    {
        public static void Main()
        {
            // Membuat Header buat hiasan doank kok :D
            Console.WriteLine("############### Informasi Iwak ############### ");
            /* Membuat Instance dari Class Ikan
             Atau bisa disebut variable yang mereferensikan new object dari class tertera
             Atau lebih simple nya membuat object baru dari Class tertentu
             Properti dan metode didefinisikan dari Class yang direferensikan*/
            Ikan iwak = new Ikan("Lele","Air Tawar","Omnivora","Ovipar");
            Hiu hiu = new Hiu("Hiu", "Perairan Dingin", "Karnivora", "Ovovivipar", true, "Great White");
            Paus paus = new Paus("Paus", "Perairan Terbuka", "Plankton", "Vivipar", false, "Blue Whale");
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            iwak.informasi_ikan();
            hiu.informasi_ikan();
            paus.informasi_ikan();
        }
    }
}
