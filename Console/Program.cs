using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());

//                      CAR

// CarGetAll(carManager);
// GetCarsByBrandId(carManager);
// GetCarsByColorId(carManager);
// GetByDailyPrice(carManager);
// GetCarDetailDtos(carManager);
// GetById(carManager);
// CarAdded(carManager);
// CarDeleted(carManager);
// CarUpdated(carManager);

//                     BRAND

// BrandGetAll(brandManager);
// BrandGetById(brandManager);
// BrandAdded(brandManager);
// BrandDeleted(brandManager);
// BrandUpdated(brandManager);

//                     COLOR

// ColorGetAll(colorManager);
// ColorGetById(colorManager);
// ColorAdded(colorManager);
// ColorDeleted(colorManager);
// ColorUpdated(colorManager);

static void CarGetAll(CarManager carManager)
{
    var result = carManager.GetAll();
    foreach (var car in result.Data)
    {
        Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
    }
    Console.WriteLine(result.Message);
}

static void GetCarsByBrandId(CarManager carManager)
{
    foreach (var car in carManager.GetCarsByBrandId(1).Data)
    {
        Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
    }
}

static void GetCarsByColorId(CarManager carManager)
{
    foreach (var car in carManager.GetCarsByColorId(2).Data)
    {
        Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
    }
}

static void GetByDailyPrice(CarManager carManager)
{
    foreach (var car in carManager.GetByDailyPrice(10, 800).Data)
    {
        Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
    }
}

static void GetCarDetailDtos(CarManager carManager)
{
    foreach (var car in carManager.GetCarDetailDtos().Data)
    {
        Console.WriteLine("Marka: {0}", car.BrandName);
        Console.WriteLine("Renk: {0}", car.ColorName);
        Console.WriteLine("Günlük Fiyat: {0}", car.DailyPrice);
        Console.WriteLine("Açıklama: {0}", car.Description);
        Console.WriteLine();
    }
}

static void GetById(CarManager carManager)
{
    foreach (var car in carManager.GetById(1).Data)
    {
        Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
    }
}

static void CarAdded(CarManager carManager)
{
    var result = carManager.Add(new Car { BrandId = 2, ColorId = 1002, ModelYear = 2018, DailyPrice = 350, Description = "2018 Model Peugeot" });
    Console.WriteLine(result.Message);
}

static void CarDeleted(CarManager carManager)
{
    var result = carManager.Delete(new Car { CarId = 3004 });
    Console.WriteLine(result.Message);
}

static void CarUpdated(CarManager carManager)
{
    var result = carManager.Update(new Car { CarId = 2003, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 550, Description = "2019 Model Peugeot" });
    Console.WriteLine(result.Message);
}

static void BrandGetAll(BrandManager brandManager)
{
    var result = brandManager.GetAll();
    foreach (var brand in result.Data)
    {
        Console.WriteLine("{0} / {1}", brand.BrandId, brand.BrandName);
    }
    Console.WriteLine(result.Message);
}

static void BrandGetById(BrandManager brandManager)
{
    foreach (var brand in brandManager.GetById(1).Data)
    {
        Console.WriteLine("{0} / {1}", brand.BrandId, brand.BrandName);
    }
}

static void BrandDeleted(BrandManager brandManager)
{
    var result = brandManager.Delete(new Brand { BrandId = 4002 });
    Console.WriteLine(result.Message);
}

static void BrandAdded(BrandManager brandManager)
{
    var result = brandManager.Add(new Brand { BrandName = "Mercedes" });
    Console.WriteLine(result.Message);
}

static void BrandUpdated(BrandManager brandManager)
{
    var result = brandManager.Update(new Brand { BrandId = 4003, BrandName = "Toyota" });
    Console.WriteLine(result.Message);
}

static void ColorGetAll(ColorManager colorManager)
{
    var result = colorManager.GetAll();
    foreach (var color in result.Data)
    {
        Console.WriteLine("{0} / {1}", color.ColorId, color.ColorName);
    }
    Console.WriteLine(result.Message);
}

static void ColorGetById(ColorManager colorManager)
{
    foreach (var color in colorManager.GetById(2).Data)
    {
        Console.WriteLine("{0} / {1}", color.ColorId, color.ColorName);
    }
}

static void ColorAdded(ColorManager colorManager)
{
    var result = colorManager.Add(new Color { ColorName = "Siyah" });
    Console.WriteLine(result.Message);
}

static void ColorDeleted(ColorManager colorManager)
{
    var result = colorManager.Delete(new Color { ColorId = 1 });
    Console.WriteLine(result.Message);
}

static void ColorUpdated(ColorManager colorManager)
{
    var result = colorManager.Update(new Color { ColorId = 2, ColorName = "Beyaz" });
    Console.WriteLine(result.Message);
}