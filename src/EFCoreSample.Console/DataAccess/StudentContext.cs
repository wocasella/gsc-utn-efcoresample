using EFCoreSample.Console.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSample.Console.DataAccess
{
    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDb");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>()
                .Property(x => x.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<City>(x =>
            {
                x.Property(c => c.Name)
                    .HasMaxLength(50);

                x.HasOne<State>()
                    .WithMany(s => s.Cities)
                    .IsRequired();
            });

            modelBuilder.Entity<Student>(x =>
            {
                x.Property(s => s.Address)
                    .HasMaxLength(200);

                x.Property(s => s.Email)
                    .HasMaxLength(300);

                x.Property(s => s.FirstName)
                    .HasMaxLength(50);

                x.Property(s => s.LastName)
                    .HasMaxLength(50);

                x.Property(s => s.ZipCode)
                    .HasMaxLength(8);

                x.HasData(new Student()
                {
                    Id = 1,
                    Address = "asdf",
                    CreatedTimestamp = DateTime.UtcNow,
                    DateOfBirth = new DateOnly(1999, 10, 3),
                    Email = "asdf",
                    FirstName = "JJ",
                    LastName = "Simone",
                    RegistryNumber = 1111,
                    ZipCode = "2134"
                });
            });
        }
    }
}
