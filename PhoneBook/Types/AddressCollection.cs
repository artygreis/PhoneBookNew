using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PhoneBook.Types
{
    public class AddressCollection
    {
        public int AddressId { get; set; }
        public string? DataAddress { get; set; }
        public bool PrivateHouse { get; set; }

        /// <summary>
        /// Получение списка адресов указанного города и частные дома или нет
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="privateHouse"></param>
        /// <returns></returns>
        public static List<AddressCollection> GetAddressCollections(int cityId, bool privateHouse)
        {
            using (var db = new ApplicationContext())
            {
                return db.City?
                        .Include(c => c.Addresses)
                        .ThenInclude(t => t.TypeStreet)
                        .Where(c => c.Id == Convert.ToInt32(cityId))
                    .FirstOrDefault()?
                        .Addresses
                        .Select(a => new AddressCollection()
                        {
                            AddressId = a.Id,
                            DataAddress = $"{(string.IsNullOrEmpty(a.Locality) ? "" : a.Locality + ", ")}{a.TypeStreet?.TypeName} {a.StreetName}{(string.IsNullOrEmpty(a.House) ? "" : ", " + a.House)}",
                            PrivateHouse = a.PrivateHouse
                        })
                        .Where(p => p.PrivateHouse == privateHouse)
                        .ToList() ?? new List<AddressCollection>();
            }
        }
    }
    
}
