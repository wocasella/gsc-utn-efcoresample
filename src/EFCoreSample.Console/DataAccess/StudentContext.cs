using EFCoreSample.Console.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSample.Console.DataAccess
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            this.Database.EnsureCreated(); // Asegurar que la base de datos exista, si no, crearla
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDb");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            });
        }
    }
}
