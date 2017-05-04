using Microsoft.EntityFrameworkCore;
using FisherInsuranceAPI.Models;

namespace FisherInsuranceAPI.Data
{
    public class FisherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "User ID=fisher-user;Password=password;Host=localhost;Port=5432;Database=fisher-insurance;Pooling=true;";
            optionsBuilder.UseNpgsql(connection);
        }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }
    } 
}