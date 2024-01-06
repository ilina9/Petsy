using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Petsy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.Person)
                .WithMany(o => o.Pets)
                .HasForeignKey(p => p.PersonId);

            modelBuilder.Entity<Pet>()
                .HasMany(p => p.Vaccines)
                .WithMany(v => v.Pets);

        }
    }
}
