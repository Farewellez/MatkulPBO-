using System;

namespace Tugas1_PBO
{
    // Superclass baru
    class Rekening
    {
        protected long nomor_rekening;
        protected string pemilik;
        protected double saldo;

        public Rekening(long nomor_rekening, string pemilik, double saldo)
        {
            this.nomor_rekening = nomor_rekening;
            this.pemilik = pemilik;
            this.saldo = saldo;
        }

        public virtual void InformasiRekening()
        {
            Console.WriteLine($"> Pemilik: {pemilik}\n> No. Rekening: {nomor_rekening}\n> Saldo: {saldo}");
        }
    }

    // Subclass dari Rekening
    class RekeningBank : Rekening
    {
        private string bank;
        private int pin;

        public RekeningBank(string bank, long nomor_rekening, string pemilik, double saldo, int pin)
            : base(nomor_rekening, pemilik, saldo)
        {
            this.bank = bank;
            this.pin = pin;
        }

        public void Setor(double jumlah)
        {
            saldo += jumlah;
            Console.WriteLine($"Setoran sebesar {jumlah} berhasil! Saldo sekarang: {saldo}");
        }

        public void Tarik(double jumlah, int inputPin)
        {
            if (inputPin != pin)
            {
                Console.WriteLine("PIN salah! Transaksi gagal.");
                return;
            }
            if (jumlah > saldo)
            {
                Console.WriteLine("Saldo tidak cukup!");
                return;
            }
            saldo -= jumlah;
            Console.WriteLine($"Penarikan sebesar {jumlah} berhasil! Saldo sekarang: {saldo}");
        }

        public override void InformasiRekening()
        {
            base.InformasiRekening();
            Console.WriteLine($"> Bank: {bank}\n> PIN: ****");
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("############### Informasi Rekening ############### ");

            RekeningBank rekening1 = new RekeningBank("Mandiri", 123456789, "Farell", 5000000, 1234);
            rekening1.InformasiRekening();

            rekening1.Setor(1000000);
            rekening1.Tarik(2000000, 1234);
            rekening1.Tarik(5000000, 1111);
        }
    }
}
