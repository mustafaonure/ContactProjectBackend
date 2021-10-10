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
        public static string PersonAdded = "Kişi rehbere kaydedildi.";
        public static string PersonName = "Kişi ismi geçersiz";
        internal static string PersonListed="Kişiler listelendi.";
        internal static string PhoneNumberAlreadyExists= "Bu numara mevcut.";
        internal static string PersonDeleted="Seçtiğiniz kişi rehberden silindi.";
        internal static string PersonUpdated="Seçtiğiniz kişi güncellendi.";

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır.";

        public static string UserRegistered = "Kullanıcı kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string Favorites = "Favori kişiler getirildi.";
        public static string Blocked = "Engellenen kişiler getirildi";
    }
}
