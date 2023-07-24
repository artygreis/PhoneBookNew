using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PhoneBook.Types
{
    public class NumberPhoneView : IComparable<NumberPhoneView>
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }
        [Display(AutoGenerateField = false)]
        public int AddressId { get; set; }
        [Display(Name = "Населенный пункт")]
        public string? Locality { get; set; }
        [Display(Name = "Тип")]
        public string? TypeName { get; set; }
        [Display(Name = "Название улицы")]
        public string? StreetName { get; set; }
        [Display(Name = "Дом")]
        public string? House { get; set; }
        [Display(Name = "Кв.(дом)")]
        public string? Apartment { get; set; }
        [Display(Name = "Номер телефона")]
        public string? Number { get; set; }

        int IComparable<NumberPhoneView>.CompareTo(NumberPhoneView? other)
        {
            var regCheckNumber = new Regex(@"^\d$");
            var regNumber = new Regex(@"[\d]");
            var regSymbol = new Regex(@"[\D]");

            int first = 0;
            int second = 0;

            if (regCheckNumber.IsMatch(Apartment!) && regCheckNumber.IsMatch(other!.Apartment!))
            {
                int.TryParse(Apartment, out first);
                int.TryParse(other.Apartment, out second);
            }
            else
            {
                if (Convert.ToInt32(regSymbol.Replace(Apartment!, "")) ==
                    Convert.ToInt32(regSymbol.Replace(other!.Apartment!, "")))
                {
                    return
                        regNumber.Replace(Apartment!, "").CompareTo(regNumber.Replace(other!.Apartment!, ""));
                }
                else
                {
                    int.TryParse(regSymbol.Replace(Apartment!, ""), out first);
                    int.TryParse(regSymbol.Replace(other!.Apartment!, ""), out second);
                }
            }

            return first.CompareTo(second);
        }

        /// <summary>
        /// Получение списка номеров по адресу
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public static List<NumberPhoneView> GetNumberPhonesByAddressId(int addressId)
        {
            using (var db = new ApplicationContext())
            {
                return db.NumberPhoneView
                    .Where(n => n.AddressId == addressId)
                    .ToList();
            }
        }
    }
}
