using System;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            string orjinal_sifre = "t1234", sifre;
            Console.Write("Şifre Giriniz: ");
            sifre = Console.ReadLine();
            if (sifre == orjinal_sifre)
            {
                Console.WriteLine("Giriş yapıldı!");
                Console.ReadKey();
                goto baslangic;
            }
            else
            {
                Console.WriteLine("Şifre Yanlış!");
                Console.ReadKey();
                goto baslangic;
            }
            
        }
    }
}