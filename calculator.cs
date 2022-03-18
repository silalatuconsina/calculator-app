using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int a = 0; // declarasi variabel a, dg ilai awal 10;
            int b = 0; //decalrasi variabel b, dg nilai awal 6;
            int menu;

            int total = 0; // declarasi variabel total;

            Console.WriteLine("Pilih menu calculator:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine(); // tambahan baris kosong

            Console.Write("Input nomor menu [1..4]: ");
            menu = int.Parse(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahan baris kosong

            if (menu == 1)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting

                total = a + b;

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + total);
            }

            else if (menu == 2)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting

                total = a - b;

                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + total);
            }

            else if (menu == 3)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting

                total = a * b;

                Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + total);
            }

            else if (menu == 4)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting 
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting

                total = a / b;

                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + total);
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine(); // tambahan baris kosong

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}