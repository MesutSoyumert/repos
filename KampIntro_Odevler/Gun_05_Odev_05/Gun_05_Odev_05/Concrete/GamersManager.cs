using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class GamersManager:BaseGamersManager
    {
        private IGamersCheckService _gamersCheckService;

        public GamersManager(IGamersCheckService gamersCheckService) 
        {
            _gamersCheckService = gamersCheckService;
        }
        public override void Save(Gamers gamers)
        {
            if (_gamersCheckService.CheckIfRealPerson(gamers))
            {
                base.Save(gamers);
            }
            else
            {
                Console.WriteLine ("Kayıt olmak isteyen oyuncu geçerli kimlik bilgilerine sahip değil");
                Console.ReadLine();
            }
        }
        public override void Update(Gamers gamers)
        {
            if (_gamersCheckService.CheckIfRealPerson(gamers))
            {
                base.Update(gamers);
            }
            else
            {
                Console.WriteLine ("Güncellenmek istenen oyuncu geçerli kimlik bilgilerine sahip değil");
                Console.ReadLine();
            }
        }
        public override void Delete(Gamers gamers)
        {
            if (_gamersCheckService.CheckIfRealPerson(gamers))
            {
                base.Delete(gamers);
            }
            else
            {
                Console.WriteLine ("Silinmek istenen oyuncu geçerli kimlik bilgilerine sahip değil");
                Console.ReadLine();
            }
        }
    }
}
