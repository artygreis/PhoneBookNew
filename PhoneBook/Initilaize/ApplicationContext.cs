using Microsoft.EntityFrameworkCore;
using PhoneBook.Types;
using PhoneBook.Types.Settings;
using Microsoft.Data.Sqlite;

namespace PhoneBook
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<TypeStreet> TypeStreet { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<NumberPhone> NumberPhone { get; set; }
        public DbSet<NumberPhoneView> NumberPhoneView { get; set; }
        public DbSet<NotCall> NotCall { get; set; }
        public DbSet<NotDisturb> NotDisturb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<NumberPhoneView>((np =>
               {
                   np.HasNoKey();
                   np.ToView("NumberPhoneView");
               }));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(SqliteConnection());
        }
        private SqliteConnection SqliteConnection()
        {
            var settings = Settings.Load();
            var conn = new SqliteConnection($"Data Source={settings.UserSourceDb};");
            return conn;
        }
    }
}
