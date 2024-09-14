using EasyBuy.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EasyBuy
{
    public class EasyBuyContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Bill> Bill { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EasyBuy"].ConnectionString);
        }        
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        
    }
}
