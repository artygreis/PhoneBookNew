using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NotCall
    {
        public int Id { get; set; }
        [Display(Name = "Квартира, №")]
        public string? Apartment { get; set; }
        [Display(Name = "Номер телефона")]
        public string? Number { get; set; }
        [Display(Name = "Примечания")]
        public string? Notes { get; set; }
        public int CityId { get; set; }
        public int AddressId { get; set; }
    }
}
