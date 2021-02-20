using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Abstract
{
    public abstract class BaseGamersManager : IGamersService
    {
        public virtual void Save(Gamers gamers)
        {
            Console.WriteLine("Oyuncu veri tabanına eklendi : " + gamers.FirstName + " " + gamers.LastName);
        }
        public virtual void Update(Gamers gamers)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi : " + gamers.FirstName + " " + gamers.LastName);
        }
        public virtual void Delete(Gamers gamers)
        {
            Console.WriteLine("Oyuncu silindi : " + gamers.FirstName + " " + gamers.LastName);
        }

    }
}
