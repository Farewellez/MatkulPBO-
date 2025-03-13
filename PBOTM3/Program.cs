using System;

namespace Tugas1_PBO
{
    // Ini Super Class
    class RekeningBank
    {
        // Ini Atribut
        protected string bank;
        protected long nomor_rekening;
        protected int pin_atm;
        protected double jumlah_saldo;

        // Ini Konstruktor
        public RekeningBank(string bank,long nomor_rekening,int pin_atm,double jumlah_saldo)
        {
            this.bank = bank;
            this.nomor_rekening = nomor_rekening;
            this.pin_atm = pin_atm;
            this.jumlah_saldo = jumlah_saldo;
        }
        /* Method untuk menampilkan atribut dan output dari Class RekeningBank
             Virtual agar dapat digunakan juga oleh subclass nya*/
        public virtual void informasi_rekening()
        {
            Console.WriteLine($"> Nama Bank: {bank}\n> No.Rekening: {nomor_rekening}\n> PIN: {pin_atm}\n> Total Saldo: {jumlah_saldo}");
        }
    }
    // Ini SubClass
    class BRI : RekeningBank
    {
        // Ini Atribut
        private string id_nasabah;
        private bool bunga;

        // Ini Konstruktor
        public BRI(string bank, long nomor_rekening, int pin_atm, double jumlah_saldo,string id_nasabah,bool bunga)
            : base(bank,nomor_rekening,pin_atm,jumlah_saldo)
        {
            this.id_nasabah = id_nasabah;
            this.bunga = bunga;
        }

        // Private method dari class BRI
        private string about_BRI()
        {
            return $"ID nasabah dari bang {bank} adalah {id_nasabah}. Menerapkan sistem bunga = {bunga}";
        }
        /* Method untuk menampilkan atribut dan output dari Class BRI
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass RekeningBank*/
        public override void informasi_rekening()
        {
            Console.WriteLine();
            base.informasi_rekening();
            Console.WriteLine(about_BRI());
        }
    }
    class BSI : RekeningBank
    {
        // Ini Atribut
        private string id_nasabah;
        private bool bunga;

        // Ini Konstruktor
        public BSI(string bank, long nomor_rekening, int pin_atm, double jumlah_saldo, string id_nasabah, bool bunga)
            : base(bank, nomor_rekening, pin_atm, jumlah_saldo)
        {
            this.id_nasabah = id_nasabah;
            this.bunga = bunga;
        }

        // Private method dari class BRI
        private string about_BSI()
        {
            return $"ID nasabah dari bang {bank} adalah {id_nasabah}. Menerapkan sistem bunga = {bunga}";
        }
        /* Method untuk menampilkan atribut dan output dari Class BSI
           Override agar subclass bisa mengubah output dari method yang ada di SuperClass RekeningBank*/
        public override void informasi_rekening()
        {
            Console.WriteLine();
            base.informasi_rekening();
            Console.WriteLine(about_BSI());
        }
    }
    // Memulai Program
    class Program
    {
        public static void Main()
        {
            // Membuat Header buat hiasan doank kok :D
            Console.WriteLine("############### Informasi Rekening Bank ############### ");
            /* Membuat Instance dari Class RekeningBank
             Atau bisa disebut variable yang mereferensikan new object dari class tertera
             Atau lebih simple nya membuat object baru dari Class tertentu
             Properti dan metode didefinisikan dari Class yang direferensikan*/
            BRI bri = new BRI("BRI",242410103041,1945,0,"BRI1357",true);
            BSI bsi = new BSI("BSI",140301014242,1945,0,"BSI2468",false);
            // Menampilkan Output dengan cara mengakses method dari Class menggunakan instance yang dibuat
            bri.informasi_rekening();
            bsi.informasi_rekening();
        }
    }
}
