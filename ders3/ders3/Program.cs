using System;

namespace ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sayiGen = new Random();
            int sayi = sayiGen.Next(1, 101);
            bool bildi = false;
            int denemesayisi = 0;

            while (bildi == false)
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sayi)
                {
                    bildi = true;
                    denemesayisi++;
                    Console.WriteLine("Tebrikler tahmininiz dogru {0} denemede buldun", denemesayisi);

                }
                else
                {
                    denemesayisi++;

                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Tahmininizi kucultunuz ");
                    }
                    else
                    {
                        Console.WriteLine("Tahmininizi buyultunuz ");
                    }
                }
             }
        }
        
    }
}






