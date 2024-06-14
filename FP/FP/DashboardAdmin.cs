using System;
using System.Security.Cryptography.X509Certificates;


namespace FP
{
    public class DashboardAdmin
    {
        private Hash hash;
        private LinkedlistTambahMotor.Garasi garasi;

        public DashboardAdmin(Hash hash)
        {
            this.hash = hash;
            this.garasi = new LinkedlistTambahMotor.Garasi();
        }

        // Menampilkan akun-akun pelanggan yang terdaftar (fitur Admin)
        public void TampilAkunAdmin(int i = 0, int jumlahAkun = 0)
        {
            HashTableEntry[] akun = hash.GetAllAccounts();

            if (i < akun.Length)
            {
                Console.WriteLine("===============================");
                if (akun[i] != null && !string.IsNullOrEmpty(akun[i].Username))
                {
                    Console.WriteLine($"{i + 1}. Nama       : {akun[i].Username}");
                    Console.WriteLine($"   Password   : {akun[i].Password}");
                    jumlahAkun++;
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Nama       : ");
                    Console.WriteLine($"   Password   : ");
                }
                TampilAkunAdmin(i + 1, jumlahAkun);
            }

            if (i == akun.Length - 1)
            {
                Console.WriteLine();
                Console.WriteLine($"Akun yang terdaftar : {jumlahAkun}");
            }

        }
        public void TampilkanMotor()
        {
            LinkedlistTambahMotor.MotorNode current = garasi.Head;
            string hasil = "";

            while (current != null)
            {
                hasil += $"Merk : {current.Data.Merk}\nNomor Polisi : {current.Data.NomorPolisi}\nHarga : {current.Data.Harga}\n";
                current = current.Next;
            }
            Console.WriteLine(hasil);
            TampilkanMenuAdmin();
        }

        // Menambahkan Motor (fitur admin)
        public void TambahkanMotor()
        {
            Console.Write("Masukkan Merk Motor: ");
            string merk = Console.ReadLine();
            Console.Write("Masukkan Nomor Polisi: ");
            string nomorPolisi = Console.ReadLine();
            Console.Write("Masukkan Harga Sewa: ");
            double harga = Convert.ToDouble(Console.ReadLine());

            LinkedlistTambahMotor.Motor motor = new LinkedlistTambahMotor.Motor(merk, nomorPolisi, harga);
            garasi.TambahMotor(motor);

            Console.WriteLine("Motor berhasil ditambahkan ke garasi.\n");
            TampilkanMenuAdmin();
        }

        public void TampilkanMenuAdmin()
        {
            Console.WriteLine("== Menu Admin ==");
            Console.WriteLine("1. Lihat Daftar Akun");
            Console.WriteLine("2. Hapus Akun");
            Console.WriteLine("3. Lihat Daftar Motor");
            Console.WriteLine("4. Tambahkan Motor");
            Console.WriteLine("5. Kembalikan Motor");
            Console.WriteLine("6. Lihat Motor Yang Dipinjam");
            Console.WriteLine("7. Keluar");
            Console.Write("Masukan Pilihan [1/2/3/4/5/6/7] : ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                TampilAkunAdmin();
                TampilkanMenuAdmin();
            }
            else if(pilihan  == "2")
            {
                Console.WriteLine("p");
            }
            else if(pilihan == "3") 
            {
                TampilkanMotor();
            }
            else if(pilihan == "4")
            {
                TambahkanMotor();
            }
        }

    }
}
