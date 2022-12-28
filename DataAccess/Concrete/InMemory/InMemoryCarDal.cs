using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2022,Description="Mercedes - Benz C Serisi",DailyPrice=3000},
                new Car{CarId=2,BrandId=8,ColorId=5,ModelYear=2016,Description="Hyundai - i20",DailyPrice=300},
                new Car{CarId=3,BrandId=3,ColorId=1,ModelYear=2016,Description="Audi - A3",DailyPrice=100},
                new Car{CarId=4,BrandId=4,ColorId=2,ModelYear=2018,Description="Volkswagen - Passat",DailyPrice=700},
                new Car{CarId=5,BrandId=5,ColorId=2,ModelYear=2019,Description="Renault - Megane",DailyPrice=500},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        // GetAll = Hepsini Getir
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
