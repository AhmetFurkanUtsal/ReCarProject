using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstact
{
    // product ile db  operasyonları yapacağım interface. sil ekle filtrele
    // dal= data access layer
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAllByCateory(int categoryId);

    }
}
