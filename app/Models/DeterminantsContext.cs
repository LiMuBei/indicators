using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace app
{
    public class DeterminantsContext : DbContext
    {
        public DeterminantsContext() {}
        
        public DeterminantsContext(DbContextOptions<DeterminantsContext> options)
        : base(options)
        { }

        public DbSet<Determinant> Determinants { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=indicators.db");
        }
    }

    public class Determinant
    {
        public int DeterminantId { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Name { get; set; }
        public string Technology { get; set; }
        [Required]
        public double Value { get; set; }
    }
}