namespace PhoneBook.Types
{
    public class CityCollection
    {
        public int Id { get; set; }
        public string? CityData { get; set; }

        /// <summary>
        /// Получение списка городов страны
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        public static List<CityCollection> GetCityCollections(int countryId)
        {
            using (var db = new ApplicationContext())
            {
                return db.City
                    .Where(c => c.CountryId == Convert.ToInt32(countryId))
                    .Select(c => new CityCollection() { Id = c.Id, CityData = $"{c.CityName} ({c.CityCode})" })
                    .ToList() ?? new List<CityCollection>();
            }
        }
    }
}
