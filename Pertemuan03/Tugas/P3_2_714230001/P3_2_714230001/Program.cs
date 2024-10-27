using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                pilihan = Console.ReadLine();

                if (pilihan == "1")
                {
                    HitungLuas();
                }
                else if (pilihan == "2")
                {
                    HitungKeliling();
                }
                else if (pilihan == "3")
                {
                    goto selesai;
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia. Silahkan pilih menu yang valid.");
                    Console.WriteLine("coba lagi aja ya beb.");
                }

                Console.Write("\nIngin mengulang kembali? (Y/T): ");
                pilihan = Console.ReadLine();
            } while (pilihan?.ToUpper() == "Y");
            selesai:
            Console.WriteLine("Program Selesai Yaa :*");
            Console.WriteLine("Terima kasih!");
            Console.ReadKey();
        }

        static void HitungLuas()
        {
            Console.Write("Masukkan panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());
            int luas = panjang * lebar;
            Console.WriteLine($"Luas persegi panjang adalah: {luas}");
        }

        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());
            int keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling persegi panjang adalah: {keliling}");
        }
    }
}
