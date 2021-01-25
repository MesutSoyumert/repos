using System;

namespace Ders3._1
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            int a, b;
            Console.Write("A Değerini Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B Değerini Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A, B'den büyüktür!");
                goto baslangic;
            }
            else
            if ( a == b )
            {
                Console.WriteLine("A, ile B eşittir!");
                goto baslangic;
            }
            {
                Console.WriteLine("A, B'den küçüktür!");
                goto baslangic;
            }
        }
    }
}
