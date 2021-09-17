
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
    public class PlutoContext:DbContext
    {
       
        public PlutoContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().ToTable("Person");
        }
        public DbSet<Person> people { get; set; }
    }
}
