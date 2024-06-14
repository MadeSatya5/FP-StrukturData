using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class DashboardAdmin
    {
        private Hash hash;
        private HashTableEntry[] akun;


        //menampilan akun-akun pelanggan yang terdaftar (fitur Admin)
        public void TampilAkunAdmin(int i = 0, int jumlahAkun = 0)
        {
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
            else // Jika sudah mencapai panjang array
            {
                Console.WriteLine();
                Console.WriteLine($"Akun yang terdaftar : {jumlahAkun}");
            }
        }

        public void TampilkanMenuAdmin()
        {
            Console.WriteLine("== Menu Admin ==");
            Console.WriteLine("1. Lihat Daftar Akun");
            Console.WriteLine("2. Lihat Daftar Motor");
            Console.WriteLine("3. Hapus Akun");
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
        }
    }
}
