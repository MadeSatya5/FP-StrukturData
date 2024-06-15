using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class DashboardAwal
    {
        public static Hash akun = new Hash();
        public static LinkedlistTambahMotor.Garasi garasi = new LinkedlistTambahMotor.Garasi();
        public static DashboardAdmin da = new DashboardAdmin(akun, garasi);
        public static DashboardPelanggan dp = new DashboardPelanggan(garasi);
        public static void Daftar()
        {
            Console.WriteLine("\n==== Menu Daftar ====");
            Console.WriteLine("Masukkan Username : ");
            string Username = Console.ReadLine();
            Console.WriteLine("Masukkan Password : ");
            string Password = Console.ReadLine();

            if (akun.CekDaftar(Username, Password))
            {
                Console.WriteLine("\nAkun Berhasil Terdaftar!!\n");
            }
            else
            {
                Console.WriteLine("\nAkun Gagal Terdaftar!!\n");
            }
            Program.Main();
        }
        public static void Masuk()
        {
            Console.WriteLine("\nMasuk sebagai :");
            Console.WriteLine("1. Pelanggan");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("Masukkan Pilihan [1/2/3]");
            string pilihan = Console.ReadLine();
            if(pilihan == "1")
            {
                Console.WriteLine("Masukkan Username :");
                string Username = Console.ReadLine();
                Console.WriteLine("Masukkan Password :");
                string Password = Console.ReadLine();
                
                if(akun.searchMasukPelanggan(Username, Password))
                {
                    Console.WriteLine("\nBerhasil Masuk!!\n");
                    dp.TampilkanMenuPelanggan();
                }
                else
                {
                    Console.WriteLine("\nGagal Masuk!! Username atau Password salah!!\n");
                    Masuk();
                }

            }
            else if(pilihan == "2")
            {
                Console.WriteLine("Masukkan Username :");
                string UsernameAdmin = Console.ReadLine();
                Console.WriteLine("Masukkan Password :");
                string PasswordAdmin = Console.ReadLine();
                if (UsernameAdmin == "user" && PasswordAdmin == "user")
                {
                    Console.WriteLine("\nBerhasil Masuk!!\n");
                    da.TampilkanMenuAdmin();
                }
                else
                {
                    Console.WriteLine("\nGagal Masuk!! Username atau Password salah!!\n");
                    Masuk();
                }
            }
            else if(pilihan == "3")
            {
                Program.Main();
            }
        }
    }
}
