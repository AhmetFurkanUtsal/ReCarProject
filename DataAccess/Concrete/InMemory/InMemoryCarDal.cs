using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //ctor new lendiğinde çalışan blok
        public InMemoryCarDal()
        {
            // db den geliyormuş gibi
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1 , ColorId=1, DailyPrice=10000,Description="Bmw",ModelYear=2023},
                new Car { Id = 2, BrandId = 1 , ColorId=1, DailyPrice=20000,Description="Volvo",ModelYear=2024},
                new Car { Id = 3, BrandId = 1 , ColorId=1, DailyPrice=30000,Description="Audi",ModelYear=2025},
            };

            
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCateory(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            // gönderdiğimiz car id sine sahip listedeki car ı bulup günceller
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice; 
            carToUpdate.Description = car.Description;
            

        }
    }
}
