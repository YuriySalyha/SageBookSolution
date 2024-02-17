using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Sage> Sages  { get; set; }

        string connectionString = @"DATA SOURCE=DESKTOP-1LHBQ4A\MSSQLSERVERYURA; DATABASE=SageBookDBMysaas; UID=sa; PWD=123456789; TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString);
        }

    }
}
