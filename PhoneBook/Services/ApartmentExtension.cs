namespace PhoneBook.Services
{
    public static class ApartmentExtension
    {
        public static int GetNumberApartment(this string apartment)
        {
            for (int i = 0; i < apartment.Length - 1; i++)
            {
                if (!char.IsNumber(apartment[i]))
                    return Convert.ToInt32(apartment.Substring(0, apartment.Length - 1 - i));
            }
            return 0;
            //foreach (var sym in apartment)
            //{
                
            //}
            //var regSymbol = new Regex(@"[\D]");
            //apartment.IndexOf()
            //return Convert.ToInt32(regSymbol.Replace(apartment, ""));
        }
    }
}
