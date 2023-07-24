namespace PhoneBook.Types.Settings
{
    public class Settings : AppSettings<Settings>
    {
        public string? UserSourceDb { get; set; }
        public string? ColorNotCall { get; set; }
        public string? ColorNotDoor { get; set; }
    }
}
