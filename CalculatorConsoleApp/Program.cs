using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    
   
namespace CalculatorConsoleApp
{
    class program
    {
        static void main(string[] args)
        {

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
        static void Main(string[] args)
        {
            char pilihan;
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("\n1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine(" \nMasukan Pilihan Menu : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" ");

            if (pilihan == '1')
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                
            }
            else if(pilihan == '2')
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if(pilihan == '3')
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));

            }
            else if(pilihan =='4')
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf Menu yang anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        
    }
}

