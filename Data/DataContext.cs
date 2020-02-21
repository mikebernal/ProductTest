using Microsoft.EntityFrameworkCore;
using ProductTest.Models;

namespace ProductTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<SkuTest> Skus { get; set; }
        public DbSet<PatternTest> Patterns { get; set; }
    }
}