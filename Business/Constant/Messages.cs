using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class Messages
    {
        public static readonly string DescriptionLengthError = "Description: This error occurs when the description provided for the car is shorter than the required minimum length. It's essential for the description to provide sufficient information about the car's features, specifications, and condition, hence requiring a minimum length to ensure adequacy.";
        internal static readonly string CarsListed = "Ürünler Listelendi";
        internal static readonly string CarAdded = "Ürün eklendi.";
        internal static readonly string CarNameInvalide = "Ürün ismi geçersiz";
        internal static readonly string MaintenanceTime = "Sistem bakımda";
        internal static readonly string LowerThanMinimumPrice = "Lütfen minimum ücretten daha yüksek bir değer girdiniz.";
        internal static readonly string HigherThanMaximumPrice = "Lütfen maksimum fiyattan daha düşük bir değer girin.";
        internal static readonly string CarDeleted;
        internal static readonly string Updated;
        internal static readonly string Null;
        internal static readonly string ExMessage = "Bir hata oluştu. Detaylar için logları kontrol edin.";
        internal static readonly string UserAdded;
        internal static readonly string UsersAdded;
    }
}
