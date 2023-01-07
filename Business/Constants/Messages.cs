using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listesi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olmalıdır!";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductNameAlreadyExist = "Aynı isimde başka bir ürün mevcuttur.";

        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied = "Yetkiniz bulunmamaktadır!";
        internal static string UserRegistered = "Kayıt işlemi başarılıdır.";
        internal static string UserNotFound = "Kullanıcı bulunamadı.";
        internal static string PasswordError = "Şifre hatalıdır.";
        internal static string SuccessfulLogin = "Giriş başarılı...";
        internal static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        internal static string AccessTokenCreated = "Giriş için token oluşturuldu.";
    }
}
