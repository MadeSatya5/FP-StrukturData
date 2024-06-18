using System;
using System.Security.Cryptography.X509Certificates;


namespace FP
{
    public class DashboardAdmin
    {
        private Hash hash;
        public LinkedlistMotor.Garasi garasi;
        public LinkedlistMotorTersewa.Tersewa tersewa;

        public DashboardAdmin(Hash hash, LinkedlistMotor.Garasi garasi, LinkedlistMotorTersewa.Tersewa tersewa)
        {
            this.hash = hash;
            this.garasi = garasi;
            this.tersewa = tersewa;
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

        //Menghapus akun yang terdaftar
        public void HapusAkun()
        {
            Console.Write("Masukkan Username yang ingin dihapus: ");
            string username = Console.ReadLine();

            if (hash.Remove(username))
            {
                Console.WriteLine("\nAkun berhasil dihapus!\n");
            }
            else
            {
                Console.WriteLine("\nAkun tidak ditemukan!\n");
            }
            TampilkanMenuAdmin();
        }

        // Menampilkan Motor (fitur admin)
        public void TampilkanMotor()
        {
            LinkedlistMotor.MotorNode current = garasi.Head;
            Console.Write("\n===== Daftar Motor =====");
            string hasil = "";
            if (current == null)
            {
                Console.WriteLine("\nMotor di Garasi Kosong!!\n");
                TampilkanMenuAdmin();
            }
            else
            {
                while (current != null)
                {
                    hasil += $"Merk : {current.Data.Merk}\nNomor Polisi : {current.Data.NomorPolisi}\nHarga : {current.Data.Harga}\n";
                    current = current.Next;
                }
                Console.WriteLine("\n" + hasil);
                TampilkanMenuAdmin();
            }
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

            LinkedlistMotor.Motor motor = new LinkedlistMotor.Motor(merk, nomorPolisi, harga);
            garasi.TambahMotor(motor);

            Console.WriteLine("\nMotor berhasil ditambahkan ke garasi!!\n");
            TampilkanMenuAdmin();
        }

        // Menambahkan Motor yang Tersewa (fitur admin)
        public void TambahkanMotorTersewa()
        {

            Console.Write("Masukkan Nama/Username Penyewa: ");
            string namaPenyewa = Console.ReadLine();
            Console.Write("Masukkan Merk Motor: ");
            string merk = Console.ReadLine();
            Console.Write("Masukkan Nomor Polisi: ");
            string nomorPolisi = Console.ReadLine();
            Console.Write("Masukkan Tanggal Awal Sewa [Ex : 11Nov2024] : ");
            string tanggalAwalSewa = Console.ReadLine();
            Console.Write("Masukkan Tanggal Akhir Sewa [Ex : 5Jan2024]: ");
            string tanggalAkhirSewa = Console.ReadLine();

            LinkedlistMotorTersewa.MotorTersewa motorTersewa = new LinkedlistMotorTersewa.MotorTersewa(merk, nomorPolisi, namaPenyewa, tanggalAwalSewa, tanggalAkhirSewa);
            tersewa.TambahMotorTersewa(motorTersewa);

            Console.WriteLine("\nMotor yang akan disewakan berhasil didata!!\n");
            TampilkanMenuAdmin();
        }

        // Menampilkan Motor (fitur admin)
        public void TampilkanMotorTersewa()
        {
            LinkedlistMotorTersewa.MotorTersewaNode current = tersewa.Head;
            Console.Write("\n===== Riwayat Motor yang Tersewa =====");
            string hasil = "";
            if (current == null)
            {
                Console.WriteLine("\nTidak ada motor yang tersewa!!\n");
                TampilkanMenuAdmin();
            }
            else
            {
                while (current != null)
                {
                    hasil += $"Nama/Usename Penyewa : {current.Data.NamaPenyewa}\nMerk : {current.Data.Merk}\nNomor Polisi : {current.Data.NomorPolisi}\nTanggal Awal Sewa : {current.Data.TanggalAwalSewa}\nTanggal Akhir Sewa : {current.Data.TanggalAkhirSewa}\n\n";
                    current = current.Next;
                }
                Console.WriteLine("\n" + hasil);
                TampilkanMenuAdmin();
            }
        }

        public void TampilkanMenuAdmin()
        {
            Console.WriteLine("== Menu Admin ==");
            Console.WriteLine("1. Lihat Daftar Akun");
            Console.WriteLine("2. Hapus Akun");
            Console.WriteLine("3. Lihat Daftar Motor");
            Console.WriteLine("4. Tambahkan Motor");
            Console.WriteLine("5. Kembalikan Motor");
            Console.WriteLine("6. Data Motor yang akan Disewa");
            Console.WriteLine("7. Lihat Riwayat Motor Yang Tersewa");
            Console.WriteLine("8. Keluar");
            Console.Write("Masukan Pilihan [1/2/3/4/5/6/7/8] : ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                TampilAkunAdmin();
                TampilkanMenuAdmin();
            }
            else if (pilihan == "2")
            {
                HapusAkun();
            }
            else if (pilihan == "3")
            {
                TampilkanMotor();
            }
            else if (pilihan == "4")
            {
                TambahkanMotor();
            }
            else if (pilihan == "5")
            {
                TambahkanMotor();
            }
            else if (pilihan == "6")
            {
                TambahkanMotorTersewa();
            }
            else if (pilihan == "7")
            {
                TampilkanMotorTersewa();
            }
            else if (pilihan == "8")
            {
                DashboardAwal.Masuk();
            }
        }

    }
}
