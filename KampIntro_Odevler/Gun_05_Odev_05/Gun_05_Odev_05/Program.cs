using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Adapters;
using Gun_05_Odev_05.Concrete;
using System;

namespace Gun_05_Odev_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("_________________________________");
            Console.WriteLine("1. Oyuncu ekleme");
            Console.WriteLine("2. Oyuncu güncelleme");
            Console.WriteLine("3. Oyuncu silme");
            Console.WriteLine("");
            Console.WriteLine("Seçiminizi Giriniz : ");

            BaseGamersManager gamersManager = new GamersManager(new MernisServiceAdapter());

            switch (Console.ReadLine())
            {
                case "1":
                    gamersManager.Save(new Entities.Gamers
                    {
                        DateOfBirth = new DateTime(1960, 11, 29),
                        FirstName = "Mesut",
                        LastName = "Soyumert",
                        NationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;
                case "2":
                    gamersManager.Update(new Entities.Gamers
                    {
                        Id = 1,
                        DateOfBirth = new DateTime(1960, 11, 29),
                        FirstName = "Mesut",
                        LastName = "Soyumert",
                        NationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;
                case "3":
                    gamersManager.Delete(new Entities.Gamers
                    {
                        Id = 1,
                        DateOfBirth = new DateTime(1960, 11, 29),
                        FirstName = "Mesut",
                        LastName = "Soyumert",
                        NationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;

            }


        }
    }
}
