
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Console.WriteLine("********** Araç Listeleme **********");
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("********** Marka ID'sine Göre Araç Listeleme **********");
foreach (var car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("********** Renk ID'sine Göre Araç Listeleme **********");
foreach (var car in carManager.GetCarsByColorId(2))
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("********** Araç ID'sine Göre Araç Listeleme **********");
foreach (var car in carManager.GetById(1))
{
    Console.WriteLine(car.Description);
}

//Console.WriteLine("********** Araç Ekleme **********");
//carManager.Add(new Car{ BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 550, Description = "Hatasız Boyasız Peugeto" });

Console.WriteLine("********** Marka ID'sine Göre Marka İsmi Gösterme **********");
BrandManager brandManager = new BrandManager(new EfBrandDal());
foreach (var brand in brandManager.GetByBrandId(2))
{
    Console.WriteLine(brand.BrandName);
}

Console.WriteLine("********** Renk ID'sine Göre Renk İsmi Gösterme **********");
ColorManager colorManager = new ColorManager(new EfColorDal());
foreach (var color in colorManager.GetByColorId(2))
{
    Console.WriteLine(color.ColorName);
}

//Console.WriteLine("********** Renk Ekleme **********");
//colorManager.Add(new Color {ColorName = "Siyah" });

//Console.WriteLine("********** Marka Ekleme **********");
brandManager.Add(new Brand { BrandName = "Toyota" });