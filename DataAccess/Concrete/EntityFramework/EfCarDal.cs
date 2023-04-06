using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailByBrand(int brandId)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                             where car.BrandId == brandId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId into Images
                             from image in Images.DefaultIfEmpty()
                             group new { car, brand, color, image } by car.CarId
                into carGroup
                             select new CarDetailDto
                             {
                                 CarId = carGroup.First().car.CarId,
                                 BrandName = carGroup.First().brand.BrandName,
                                 ColorName = carGroup.First().color.ColorName,
                                 Description = carGroup.First().car.Description,
                                 DailyPrice = carGroup.First().car.DailyPrice,
                                 ModelYear = carGroup.First().car.ModelYear,
                                 ImagePath = carGroup.Select(c => c.image == null ? "DefaultImage.jpg" : c.image.ImagePath).ToList()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailByCar(int carId)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                             where car.CarId == carId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId into Images
                             from image in Images.DefaultIfEmpty()
                             group new { car, brand, color, image } by car.CarId
                into carGroup
                             select new CarDetailDto
                             {
                                 CarId = carGroup.First().car.CarId,
                                 BrandName = carGroup.First().brand.BrandName,
                                 ColorName = carGroup.First().color.ColorName,
                                 Description = carGroup.First().car.Description,
                                 DailyPrice = carGroup.First().car.DailyPrice,
                                 ModelYear = carGroup.First().car.ModelYear,
                                 ImagePath = carGroup.Select(c => c.image == null ? "DefaultImage.jpg" : c.image.ImagePath).ToList()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailByColor(int colorId)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                             where car.ColorId == colorId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId into Images
                             from image in Images.DefaultIfEmpty()
                             group new { car, brand, color, image } by car.CarId
                into carGroup
                             select new CarDetailDto
                             {
                                 CarId = carGroup.First().car.CarId,
                                 BrandName = carGroup.First().brand.BrandName,
                                 ColorName = carGroup.First().color.ColorName,
                                 Description = carGroup.First().car.Description,
                                 DailyPrice = carGroup.First().car.DailyPrice,
                                 ModelYear = carGroup.First().car.ModelYear,
                                 ImagePath = carGroup.Select(c => c.image == null ? "DefaultImage.jpg" : c.image.ImagePath).ToList()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId into Images
                             from image in Images.DefaultIfEmpty()
                             group new { car, brand, color, image } by car.CarId
                into carGroup
                             select new CarDetailDto
                             {
                                 CarId = carGroup.First().car.CarId,
                                 BrandName = carGroup.First().brand.BrandName,
                                 ColorName = carGroup.First().color.ColorName,
                                 Description = carGroup.First().car.Description,
                                 DailyPrice = carGroup.First().car.DailyPrice,
                                 ModelYear = carGroup.First().car.ModelYear,
                                 ImagePath = carGroup.Select(c => c.image == null ? "DefaultImage.jpg" : c.image.ImagePath).ToList()
                             };
                return result.ToList();
            }
        }
    }
       
    }
