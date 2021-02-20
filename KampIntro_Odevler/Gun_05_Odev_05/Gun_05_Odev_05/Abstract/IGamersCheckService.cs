using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Abstract
{
    public interface IGamersCheckService
    {
        bool CheckIfRealPerson(Gamers gamers);
    }
}
