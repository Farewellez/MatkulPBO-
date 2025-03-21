using System;

namespace SistemPerbankan
{
    // SuperClass
    class RekeningBank
    {
        // field
        protected double saldo;
        // konstruktor
        public RekeningBank(double saldo)
        {
            this.saldo = saldo;
        }
        // method tarik
        public virtual void penarikan()
        {
            double tarik;
            Console.WriteLine("Masukkan Saldo yang ingin di tarik: ");
            tarik = Convert.ToDouble(Console.ReadLine());
            if (tarik <= saldo)
            {
                saldo -= tarik;
                Console.WriteLine($"Penarikan Berhasil\nSisa saldo anda{saldo}");
            }
            else
            {
                Console.WriteLine("Saldo tidak mencukupi");
            }
        }
        // method setor
        public virtual void setor()
        {
            double setor;
            Console.WriteLine("Masukkan nominal yang disetorkan: ");
            setor = Convert.ToDouble(Console.ReadLine());
            if (setor < 0)
            {
                Console.WriteLine("Saldo tidak mencukupi");
            }
            else
            {
                saldo += setor;
                Console.WriteLine("Saldo saat ini adalah" + saldo);
            }
        }
        // method cek saldo
        public virtual void cek_saldo()
        {
            Console.WriteLine($"Saldo anda: {saldo}");
        }
    }
    // SubClass Giro
    class Giro : RekeningBank
    {
        // konstruktor
        public Giro(double saldo) : base(saldo)
        {
        }
        // method tarik
        public override void penarikan()
        {
            double tarik;
            Console.WriteLine("----------------------- REKENING GIRO -----------------------");
            Console.WriteLine("-------------- Fasilitas OverSpending hingga 20% --------------");
            Console.WriteLine("Masukkan Saldo yang ingin di tarik: ");
            tarik = Convert.ToDouble(Console.ReadLine());
            if (tarik < 0)
            {
                Console.WriteLine("Input Tidak Valid");
                return;
            }
            else if (tarik <= saldo)
            {
                saldo -= tarik;
                Console.WriteLine($"Penarikan Berhasil\nSisa saldo anda adalah {saldo:N0}");
                return;
            }
            else
            {
                double batasOverspending = saldo * 1.2; // Maksimum saldo + 20%

                if (tarik > batasOverspending)
                {
                    Console.WriteLine("Penarikan melebihi batas overspending 20% dari saldo. Transaksi dibatalkan.");
                    return;
                }
                else
                {
                    saldo -= tarik;
                    double total = saldo + (0.2 * saldo);
                    Console.WriteLine($"Fasilitas Overspending 20% dari total saldo {total:N0} = {batasOverspending}");
                    Console.WriteLine("Bunga 2% per bulan apabila melebihi tenggat pembayaran yakni 7 hari.");
                    Console.WriteLine($"Sisa Saldo: {saldo:N0}");
                    return;
                }
            }
        }
         // method setor
        public override void setor()
        {
            double setor;
            Console.WriteLine("Masukkan nominal yang disetorkan: ");
            setor = Convert.ToDouble(Console.ReadLine());
            if (setor < 0)
            {
                Console.WriteLine("Saldo tidak mencukupi");
                return;
            }
            else
            {
                saldo += setor;
                Console.WriteLine($"Saldo saat ini adalah {saldo:N0}");
                return;
            }
        }
        // method cek saldo
        public override void cek_saldo()
        {
            Console.WriteLine($"Saldo anda: {saldo:N0}");
            return;
        }
    }
    // SubClass Tabungan
    class Tabungan : RekeningBank
    {
        // konstruktor
        public Tabungan(double saldo) : base(saldo)
        {
        }
        // method tarik
        public override void penarikan()
        {
            double tarik;
            Console.WriteLine("-------------- REKENING TABUNGAN --------------");
            Console.WriteLine("-------------- Fasilitas Bunga 2% per Bulan --------------");
            Console.WriteLine("Masukkan Saldo yang ingin di tarik: ");
            tarik = Convert.ToDouble(Console.ReadLine());
            if (tarik <= 0)
            {
                Console.WriteLine("Input Tidak Valid");
                return;
            }
            else if (tarik > saldo)
            {
                Console.WriteLine("Saldo Tidak Mencukupi");
                return;
            }
            else
            {
                saldo -= tarik;
                Console.WriteLine($"Penarikan Berhasil\nSisa saldo anda adalah {saldo:N0}");
                return;
            }
        }
        // method setor
        public override void setor()
        {
            double setor;
            Console.WriteLine("-------------- REKENING TABUNGAN --------------");
            Console.WriteLine("-------------- Fasilitas Bunga 2% per Bulan --------------");
            Console.WriteLine("Masukkan Saldo yang ingin di tarik: ");
            Console.WriteLine("Masukkan nominal yang disetorkan: ");
            setor = Convert.ToDouble(Console.ReadLine());
            if (setor <= 0)
            {
                Console.WriteLine("Input Tidak Valid");
                return;
            }
            else
            {
                saldo += setor;
                double total = saldo + (0.02 * saldo);
                Console.WriteLine($"Saldo saat ini adalah {total:N0} (Dikenakan Fasilitas bunga 2% perbulannya)");
                return;
            }
        }
        // method cek saldo
        public override void cek_saldo()
        {
            double total = saldo + (0.02 * saldo);
            Console.WriteLine($"Saldo anda: {total:N0} (Dikenakan Fasilitas bunga 2% perbulannya)");
            return;
        }
    }
    // program
    class Program
    {
        // Main 
        public static void Main()
        {
            // input user
            int user;
            Console.WriteLine("Pilih rekening:\n1. Rekening Giro\n2. Rekening Tabungan");
            user = Convert.ToInt16(Console.ReadLine());
            // Perkondisian pemilihan rekening
            if (user == 1)
            {
                // Rekening Giro
                Giro giro = new Giro(1000_000);
                int pilihan;
                // Pilihan tarik,setor atau cek saldo
                Console.WriteLine("1. Penarikan\n2. Setor Tunai\n3. Cek Saldo");
                pilihan = Convert.ToInt16(Console.ReadLine());
                // Case tertentu
                switch (pilihan)
                {
                    // tarik tunai
                    case 1:
                        giro.penarikan();
                        break;
                    // setor tunai
                    case 2:
                        giro.setor();
                        break;
                    // cek saldo
                    case 3:
                        giro.cek_saldo();
                        break;
                    // default
                    default:
                        Console.WriteLine("Input tidak valid");
                        break;
                }
            }
            else if (user == 2)
            {
                // Rekening Tabungan
                Tabungan tabung = new Tabungan(1000_000);
                int pilihan;
                // Pilihan tarik,setor atau cek saldo
                Console.WriteLine("1. Penarikan\n2. Setor Tunai\n3. Cek Saldo");
                pilihan = Convert.ToInt16(Console.ReadLine());
                // Case tertentu
                switch (pilihan)
                {
                    // tarik tunai
                    case 1:
                        tabung.penarikan();
                        break;
                    // setor tunai
                    case 2:
                        tabung.setor();
                        break;
                    // cek saldo
                    case 3:
                        tabung.cek_saldo();
                        break;
                    // default/else
                    default:
                        Console.WriteLine("Input tidak valid");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input Tidak Valid");
            }
        }
    }
}