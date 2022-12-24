using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Sisteme Eklendi!");
            }
            else
            {
                Console.WriteLine("Araç Eklenemedi!");
                Console.WriteLine("Araç İsmini ve Araç Günlük Fiyatını Kontrol Ediniz!");
            }
            
        
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
            Console.WriteLine(car.CarId + "ID 'li Araç Silinmiştir!");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice>0)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Araç Güncellenemedi!");
                Console.WriteLine("Araç İsmini ve Araç Günlük Fiyatını Kontrol Ediniz!");
            }
            
            
        }
    }
}
