using IntegradorBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace IntegradorBackend.Data
{
    public class IntegradorContext : DbContext
    {
        public IntegradorContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=IntegradorDB.db");
        }

        public IntegradorContext(DbContextOptions<IntegradorContext> options) :base(){}

        public DbSet<Locatario> Locatarios {  get; set; }

    }
}
