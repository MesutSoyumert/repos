using System;

namespace Ders3._3
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            string name = "Frank";
            // Ternary operator
            Console.WriteLine(name == "Frank" ? "The name is Frank": "The name is not Frank");
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
