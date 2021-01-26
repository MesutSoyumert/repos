using System;

namespace Ders3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            bool birinci = true;
            bool ikinci = true;
            if (birinci && ikinci)
            {
                Console.WriteLine("&& and demek");
                goto baslangic;
            }
if (birinci || ikinci)
            {
                Console.WriteLine("|| or demek");
                goto baslangic;
                    }
        }
    }
}
