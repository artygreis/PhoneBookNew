namespace PhoneBook.Types
{
    public class ApartmentCollection
    {
        public int ApartmentId { get; set; }
        public string? NumberApartment { get; set; }

        /// <summary>
        /// Получение списка квартир по адресу
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public static List<ApartmentCollection> GetApartmentCollections(int addressId)
        {
            using (var db = new ApplicationContext())
            {
                return db.NumberPhone
                    .Where(a => a.AddressId == addressId)
                    .Select(ap => new ApartmentCollection()
                    {
                        ApartmentId = ap.Id,
                        NumberApartment = ap.Apartment
                    }).ToList() ?? new List<ApartmentCollection>();
            }
        }
    }
}
