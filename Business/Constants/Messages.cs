using Core.Entities.Concretes;
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
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün adı geçersiz";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProcessFailed = "İşlem başarısız";
        public static string ProductDeleted = "Ürn silindi";
        public static string ProductUpdate = "Ürün güncellendi";
        public static string CannotBeLessThanZero = "Sıfıra eşit veya küçük olamaz!";
        public static string ProductNameAlreadyExists = "Ürün adı zaten var";
        public static string CategoryLimitExceed = "Kategori limiti aşıldı";
        public static string ProcessSuccessful = "İşlem Başarılı";
        public static string AuthorizationDenied = "Doğrulama Başarısız";
        public static string UserRegistered = "Kayıt oluşturuldu";
        public static string UserNotFound = "Kullanıcı yok";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim kodu oluşturldu";
    }
}
