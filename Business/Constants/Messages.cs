using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CheckCarNameAndPrice = "Araç İsmi ve Fiyatını Kontrol Ediniz";

        public static string MaintenanceTime = "Sistem Bakımda";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandListed = "Markalar Listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";

        public static string CustomerAdded  = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomersListed = "Müşteriler Listelendi";

        public static string RentalSuccessful = "Kiralama Başarılı";
        public static string RentalFailed = "Kiralama Başarısız";


        public static string ImageAdded = "Resim Eklendi";
        public static string ImageDeleted = "Resim Silindi";
        public static string ImageUpdated = "Resim Güncellendi";
        public static string CarImageLimitError = "Araba resmi en fazla 5 tane olabilir";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
