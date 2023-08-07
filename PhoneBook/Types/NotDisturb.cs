using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NotDisturb
    {
        public int Id { get; set; }
        public bool NotCall { get; set; } = false;
        public bool NotEnter { get; set; } = false;
        [Display(Name = "Примечания")]
        public string? Notes { get; set; }
        public int NumberPhoneId { get; set; }
        public NumberPhone? NumberPhone { get; set; }
    }
}
