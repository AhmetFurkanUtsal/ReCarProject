using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //veritabanı tablolarımız
    public class Car:IEntity
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public long ColorId { get; set; }

        public short ModelYear { get; set; }

        public float DailyPrice { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
