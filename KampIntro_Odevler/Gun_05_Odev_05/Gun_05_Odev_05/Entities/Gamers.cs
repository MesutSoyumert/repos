using Gun_05_Odev_05.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Entities
{
    public class Gamers:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
