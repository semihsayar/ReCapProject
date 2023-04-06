
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<Car>GetById(int carId);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<List<CarDetailDto>> GetCarDetailByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailByCar(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car); 
    }
}
