
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Console.WriteLine("********** Araç Listeleme **********");
foreach (var car in carManager.GetCarDetailDtos())
{
    Console.WriteLine("Marka : " + car.BrandName);
    Console.WriteLine("Renk : " + car.ColorName);
    Console.WriteLine("Günlük Fiyat : " + car.DailyPrice);
    Console.WriteLine("Açıklama : " + car.Description);
}

//Console.WriteLine("********** Marka ID'sine Göre Araç Listeleme **********");
//foreach (var car in carManager.GetCarsByBrandId(1))
//{
//    Console.WriteLine(car.Description);
//}

//Console.WriteLine("********** Renk ID'sine Göre Araç Listeleme **********");
//foreach (var car in carManager.GetCarsByColorId(2))
//{
//    Console.WriteLine(car.Description);
//}

//Console.WriteLine("********** Araç ID'sine Göre Araç Listeleme **********");
//foreach (var car in carManager.GetById(1))
//{
//    Console.WriteLine(car.Description);
//}

//Console.WriteLine("********** Araç Ekleme **********");
//carManager.Add(new Car{ BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 550, Description = "Hatasız Boyasız Peugeto" });

//Console.WriteLine("********** Araç Güncelle **********");
//carManager.Update(new Car{CarId=1, BrandId = 1, ColorId = 1002, ModelYear = 2020, DailyPrice = 1200, Description = "2020 Bmw 5 Serisi" });

//Console.WriteLine("********** Araç Silme **********");
//carManager.Delete(new Car { CarId = 2,});


//Console.WriteLine("********** Renk ID'sine Göre Renk İsmi Gösterme **********");
//ColorManager colorManager = new ColorManager(new EfColorDal());
//foreach (var color in colorManager.GetByColorId(1002))
//{
//    Console.WriteLine(color.ColorName);
//}

//Console.WriteLine("********** Renk Ekleme **********");
//colorManager.Add(new Color { ColorName = "Turuncu" });

//Console.WriteLine("********** Renk Silme **********");
//colorManager.Delete(new Color { ColorId=2002, ColorName = "Turuncu" });

//Console.WriteLine("********** Renk Güncelleme **********");
//colorManager.Update(new Color { ColorId=1002, ColorName = "Mavi" });



//BrandManager brandManager = GetByBrandId();

//Update(brandManager);

//Delete(brandManager);

//Add(brandManager);


static BrandManager GetByBrandId()
{
    Console.WriteLine("********** Marka ID'sine Göre Marka İsmi Gösterme **********");
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var brand in brandManager.GetByBrandId(2))
    {
        Console.WriteLine(brand.BrandName);
    }

    return brandManager;
}

static void Update(BrandManager brandManager)
{
    Console.WriteLine("********** Marka Güncelleme **********");
    brandManager.Update(new Brand { BrandId = 3004, BrandName = "Honda" });
}

static void Delete(BrandManager brandManager)
{
    Console.WriteLine("********** Marka Silme **********");
    brandManager.Delete(new Brand { BrandId = 3003 });
}

static void Add(BrandManager brandManager)
{
    Console.WriteLine("********** Marka Ekleme **********");
    brandManager.Add(new Brand { BrandName = "Toyota" });
}