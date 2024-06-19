using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class DashboardPelanggan
    {
        private LinkedlistMotor.Garasi garasi;

        public DashboardPelanggan(LinkedlistMotor.Garasi garasi)
        {
            this.garasi = garasi; // menggunakan objek garasi yang sama di lain kelas
        }
        // Lihat Daftar Motor (fitur pelanggan)
        public void LihatDaftarMotor()
        {
            LinkedlistMotor.MotorNode current = garasi.Head;
            Console.WriteLine("\n===== Daftar Motor =====");
            string hasil = "";
            if(current == null) 
            {
                Console.WriteLine("Motor di Garasi Kosong!!\n");
                TampilkanMenuPelanggan();
            }
            else
            {
                while (current != null)
                {
                    hasil += $"Merk : {current.Data.Merk}\nNomor Polisi : {current.Data.NomorPolisi}\nHarga : {current.Data.Harga}\n";
                    current = current.Next;
                }
                Console.WriteLine("\n" + hasil);
                TampilkanMenuPelanggan();
            }
        }

        // Sewa Motor (fitur Pelanggan)
        public void SewaMotor()
        {
            LinkedlistMotor.MotorNode current = garasi.Head;
            LinkedlistMotor.MotorNode previous = null;

            Console.WriteLine("\n============== Sewa Motor ==============");
            Console.WriteLine("Masukkan merk motor yang ingin disewa : ");
            string inputSewa = Console.ReadLine();

            if(current == null) // jika Head kosong maka garasi kosong
            {
                Console.WriteLine("Motor di Garasi Kosong!!\n");
                TampilkanMenuPelanggan();
            }
            else if (string.Compare(current.Data.Merk, inputSewa) == 0) // jika motor ada di Head
            {
                garasi.Head = current.Next;
                Console.WriteLine($"Menyewa motor dengan Merk: { current.Data.Merk}\nNomor Polisi : { current.Data.NomorPolisi}\nHarga: { current.Data.Harga}\n");
                TampilkanMenuPelanggan();
            }
            while (current != null)
            {
                if (string.Compare(current.Data.Merk, inputSewa) == 0)
                {
                    if(previous != null) // Memastikan agar previous tidak null sebelum mengubah preferensi next
                    {
                        previous.Next = current.Next;
                    }
                    Console.WriteLine($"Menyewa motor dengan Merk: {current.Data.Merk}\nNomor Polisi : {current.Data.NomorPolisi}\nHarga: {current.Data.Harga}\n");
                    TampilkanMenuPelanggan();
                }
                previous = current;
                current = current.Next;
            }
            Console.WriteLine("Motor Tidak Tersedia!!\n");
            TampilkanMenuPelanggan();
        }

        // Menampilkan Menu Pelanggan
        public void TampilkanMenuPelanggan()
        {
            Console.WriteLine("== Dashboard Pelanggan ==");
            Console.WriteLine("1. Lihat Daftar Motor");
            Console.WriteLine("2. Sewa Motor");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("Masukkan pilihan [1/2/3]");

            string input = Console.ReadLine();

            if(input == "1")
            {
                LihatDaftarMotor();
            }
            else if(input == "2")
            {
               SewaMotor();
            }
            else if(input == "3")
            {
                DashboardAwal.Masuk();
            }
            else
            {
                Console.WriteLine("\nInput Tidak Valid!!\n");
                TampilkanMenuPelanggan();
            }

        }
    }
}
