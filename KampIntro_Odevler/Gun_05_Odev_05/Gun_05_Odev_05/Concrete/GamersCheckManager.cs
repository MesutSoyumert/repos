using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class GamersCheckManager : IGamersCheckService
    {
        public bool CheckIfRealPerson(Gamers gamers)
        {
            return true;
        }
    }
}
