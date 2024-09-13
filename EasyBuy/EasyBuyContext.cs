using EasyBuy.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy
{
    public class EasyBuyContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Sale> Sale { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EasyBuy"].ConnectionString);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RR0HP8G\\SQLEXPRESS;Database=Keels_SuperMarket_Database;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        
    }
}
