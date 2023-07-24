namespace PhoneBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc4OTgwN0AzMjMxMmUzMTJlMzMzNUFrQnBYTVlYeDhMbkRNN3pkOVA3NGZXZ0l2TFRPY0g2MUxMcnpzUEIwemc9");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}