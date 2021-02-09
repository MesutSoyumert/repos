using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Musteri:IEntity
    {
        public int MusteriId { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public string MusteriAdresi { get; set; }
        public string MusteriSehir { get; set; }
    }
}
