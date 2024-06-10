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
        public static void Daftar()
        {
            Console.WriteLine("==== Menu Daftar ====");
            Console.WriteLine("Masukkan Username : ");
            string Username = Console.ReadLine();
            Console.WriteLine("Masukkan Password : ");
            string Password = Console.ReadLine();

            if (akun.CekDaftar(Username, Password))
            {
                Console.WriteLine("Akun Berhasil Terdaftar!!");
            }
            else
            {
                Console.WriteLine("Akun Gagal Terdaftar!!");
            }
            Program.Main();
        }
        public static void Masuk()
        {
            Console.WriteLine("Masuk sebagai :");
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
                    Console.WriteLine("Berhasil Masuk");
                }
                else
                {
                    Console.WriteLine("Gagal Masuk");
                }

            }
            if(pilihan == "2")
            {
                Console.WriteLine("Masukkan Username :");
                string UsernameAdmin = Console.ReadLine();
                Console.WriteLine("Masukkan Password :");
                string PasswordAdmin = Console.ReadLine();
                if (UsernameAdmin == "user" && PasswordAdmin == "user")
                {
                    Console.WriteLine("Berhasil Masuk");
                }
                else
                {
                    Console.WriteLine(" Username / Password salah");
                }
            }
        }
    }
}
