using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NotDisturbCollection
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }
        [Display(AutoGenerateField = false)]
        public int CityId { get; set; }
        [Display(AutoGenerateField = false)]
        public int AddressId { get; set; }
        [Display(AutoGenerateField = false)]
        public int NumberPhoneId { get; set; }
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
        [Display(Name = "Не звонить")]
        public bool NotCall { get; set; }
        [Display(Name = "Не заходить")]
        public bool NotEnter { get; set; }
        [Display(Name = "Примечание", AutoGenerateField = false)]
        public string? Notes { get; set; }


        /// <summary>
        /// Список всех записей "Не беспокоить"
        /// </summary>
        /// <returns></returns>
        private static List<NotDisturbCollection> GetNotDisturbCollections()
        {
            using (var db = new ApplicationContext())
            {
                var typeStreets = db.TypeStreet.ToList();

                return db.NotDisturb
                    .Include(n => n.NumberPhone)
                    .ThenInclude(a => a.Address)
                    .ThenInclude(c => c.City)
                    .ToList()
                    .Select(d => new NotDisturbCollection()
                    {
                        Id = d.Id,
                        CityId = Convert.ToInt32(d.NumberPhone?.Address?.CityId),
                        AddressId = Convert.ToInt32(d.NumberPhone?.AddressId),
                        NumberPhoneId = d.NumberPhoneId,
                        Locality = d.NumberPhone?.Address?.Locality,
                        TypeName = typeStreets.Where(t => t.Id == Convert.ToInt32(d.NumberPhone?.Address?.TypeStreetId)).Select(t => t.TypeName).FirstOrDefault(),
                        StreetName = d.NumberPhone?.Address?.StreetName,
                        House = d.NumberPhone?.Address?.House,
                        Apartment = d.NumberPhone?.Apartment,
                        Number = d.NumberPhone?.Number,
                        NotCall = d.NotCall,
                        NotEnter = d.NotEnter,
                        Notes = d.Notes
                    })
                    .ToList() ?? new List<NotDisturbCollection>();
            }
        }

        /// <summary>
        /// Список всех записей "Не беспокоить" для определенного города
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public static List<NotDisturbCollection> GetNotDisturbCollections(int cityId)
        {
            var notDisturbCollection = GetNotDisturbCollections();

            return notDisturbCollection
                .Where(c => c.CityId == cityId)
                .ToList() ?? new List<NotDisturbCollection>();
        }

        /// <summary>
        /// Список всех записей "Не беспокоить" для определенного адреса
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public static List<NotDisturbCollection> GetNotDisturbCollections(int cityId, int addressId)
        {
            var notDisturbCollection = GetNotDisturbCollections(cityId);

            return notDisturbCollection
                .Where(c => c.AddressId == addressId)
                .ToList() ?? new List<NotDisturbCollection>();
        }
    }
}
