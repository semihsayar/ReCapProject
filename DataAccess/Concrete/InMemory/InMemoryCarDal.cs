using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        // Global
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { 
                new Car{Id=1,BrandId=1,ColordId=1,ModelYear=2022,Description="Mercedes - Benz C Serisi",DailyPrice=3000},
                new Car{Id=2,BrandId=8,ColordId=5,ModelYear=2016,Description="Hyundai - i20",DailyPrice=300},
                new Car{Id=3,BrandId=3,ColordId=1,ModelYear=2016,Description="Audi - A3",DailyPrice=100},
                new Car{Id=4,BrandId=4,ColordId=2,ModelYear=2018,Description="Volkswagen - Passat",DailyPrice=700},
                new Car{Id=5,BrandId=5,ColordId=2,ModelYear=2019,Description="Renault - Megane",DailyPrice=500},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        // GetAll = Hepsini Getir
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == c.Id).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id );
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColordId = car.ColordId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
