using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Населенный пункт")]
        public string? Locality { get; set; }
        [Display(Name = "Название")]
        public string? StreetName { get; set; }
        [Display(Name = "Дом")]
        public string? House { get; set; }
        [Display(Name = "Частный дом")]
        public bool PrivateHouse { get; set; } = false;

        public int TypeStreetId { get; set; }
        public TypeStreet? TypeStreet { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }

        public List<NumberPhone> NumberPhones { get; set; } = new List<NumberPhone>();
    }
}
