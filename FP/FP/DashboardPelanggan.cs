using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class DashboardPelanggan
    {
        public static void MainMenu()
        {
            Console.WriteLine("== Dashboard Pelanggan ==");
            Console.WriteLine("1. Lihat Daftar Motor");
            Console.WriteLine("2. Sewa Motor");
            Console.WriteLine("3. Kembalikan Motor");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("Masukkan pilihan [1/2/3/4]");

            string input = Console.ReadLine();

            if(input == "1")
            {
                Console.WriteLine("Menu Daftar Motor");
            }
            else if(input == "2")
            {
                Console.WriteLine("Menu Sewa Motor");
            }
            else if(input == "3")
            {
                Console.WriteLine("Menu Kembalikan Motor");
            }
            else if(input == "4")
            {
                DashboardAwal.Masuk();
            }
            else
            {
                Console.WriteLine("Input Tidak Valid!!");
            }

        }
    }
}
