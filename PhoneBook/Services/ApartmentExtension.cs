using System.Text.RegularExpressions;

namespace PhoneBook.Services
{
    public static class ApartmentExtension
    {
        public static int GetNumberApartment(this string apartment)
        {
            var regSymbol = new Regex(@"[\D]");
            return Convert.ToInt32(regSymbol.Replace(apartment, ""));
        }
    }
}
