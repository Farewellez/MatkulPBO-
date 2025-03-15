using System;

namespace Tugas1_PBO
{
    // Superclass baru
    class HewanAir
    {
        protected string nama;
        protected string habitat;
        protected string jenisMakanan;
        protected string caraBerkembangBiak;

        public HewanAir(string nama, string habitat, string jenisMakanan, string caraBerkembangBiak)
        {
            this.nama = nama;
            this.habitat = habitat;
            this.jenisMakanan = jenisMakanan;
            this.caraBerkembangBiak = caraBerkembangBiak;
        }

        public virtual void Informasi()
        {
            Console.WriteLine($"> Nama: {nama}\n> Habitat: {habitat}\n> Jenis Makanan: {jenisMakanan}\n> Cara Berkembang Biak: {caraBerkembangBiak}");
        }
    }

    // Subclass dari HewanAir
    class Ikan : HewanAir
    {
        private bool berbahaya;
        private string jenisIkan;

        public Ikan(string nama, string habitat, string jenisMakanan, string caraBerkembangBiak, bool berbahaya, string jenisIkan)
            : base(nama, habitat, jenisMakanan, caraBerkembangBiak)
        {
            this.berbahaya = berbahaya;
            this.jenisIkan = jenisIkan;
        }

        private string CekBahaya()
        {
            return $"Ikan ini berbahaya = {berbahaya}, jenis: {jenisIkan}";
        }

        public override void Informasi()
        {
            base.Informasi();
            Console.WriteLine(CekBahaya());
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("############### Informasi Hewan Air ############### ");

            HewanAir hewan1 = new HewanAir("Lele", "Air Tawar", "Omnivora", "Ovipar");
            Ikan ikan1 = new Ikan("Hiu", "Laut", "Karnivora", "Ovovivipar", true, "Great White");

            hewan1.Informasi();
            ikan1.Informasi();
        }
    }
}
