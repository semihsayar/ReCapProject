﻿using Core.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                       join brand in context.Brands on car.BrandId equals brand.BrandId
                       join color in context.Colors on car.ColorId equals color.ColorId
                       select new CarDetailDto
                       {
                           BrandName = brand.BrandName,
                           ColorName = color.ColorName,
                           DailyPrice = car.DailyPrice,
                           Description = car.Description
                           
                       };
                return result.ToList();
            }
        }
    }
}
