using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app
{
    public class SqliteContext : DbContext
    {
        public SqliteContext() {}
        
        public SqliteContext(DbContextOptions<SqliteContext> options)
        : base(options)
        { }

        public DbSet<Determinant> Determinants { get; set; }
        public DbSet<Country> Countries { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=indicators.db");
        }
    }
}