using System;


namespace Calculator
{
    class Program
    {
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

        static int modulos(int a, int b)
        {
            return a % b;
        }


        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int bil1, bil2;
            char pilihan;

            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Sisa Bagi\n");
            Console.Write("Masukan Pilihan [1..5] : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == '1')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua    : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write(" Hasil Penambahan         : {0} + {1} = {2}", bil1, bil2, Penambahan(bil1, bil2));
            }
            else if (pilihan == '2')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilang Kedua      : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pengurangan         : {0} - {1} = {2}", bil1, bil2, Pengurangan(bil1, bil2));
            }
            else if (pilihan == '3')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua    : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Perkalian           : {0} * {1} = {2}", bil1, bil2, Perkalian(bil1, bil2));
            }
            else if (pilihan == '4')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua    : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pembagian           : {0} / {1} = {2}", bil1, bil2, Pembagian(bil1, bil2));
            }
           
            else if (pilihan == '5')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua    : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Sisa Bagi           : {0} % {1} = {2}", bil1, bil2, modulos(bil1, bil2));
            }
            
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }


    }

   
}
