using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class DashboardAdmin
    {
        public void TampilkanMenuAdmin()
        {
            Console.WriteLine("== Menu Admin ==");
            Console.WriteLine("1. Lihat Daftar Akun");
            Console.WriteLine("2. Lihat Daftar Buku");
            Console.WriteLine("3. Hapus Akun");
            Console.WriteLine("4. Tambahkan Buku");
            Console.WriteLine("5. Kembalikan Buku");
            Console.WriteLine("6. Lihat Buku Yang Dipinjam");
            Console.WriteLine("7. Keluar");
            Console.Write("Masukan Pilihan [1/2/3/4/5/6/7] : ");
            string pilihan = Console.ReadLine();
        }
    }
}
