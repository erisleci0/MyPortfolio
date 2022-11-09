using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Socials> Socials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=MyPortfolio;password=erisleci1;port=3306;");
        }
    }
}
