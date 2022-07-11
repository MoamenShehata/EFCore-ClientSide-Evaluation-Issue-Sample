using Microsoft.EntityFrameworkCore;
using Moamen.Training.EFCore.Models;

namespace Moamen.Training.EFCore
{
    public class DataContext : DbContext
    {
        public DbSet<Moamen.Training.EFCore.Models.Employee> Employees { get; set; }
        public DbSet<Moamen.Training.EFCore.Models.Department> Departments { get; set; }
        public DbSet<Moamen.Training.EFCore.Models.FamilyMember> FamilyMembers { get; set; }
        public DbSet<Moamen.Training.EFCore.Models.Car> Cars { get; set; }

        public DbSet<Moamen.Training.EFCore.Models.Person> Persons { get; set; }
        public DbSet<Moamen.Training.EFCore.Models.Cat> Cats { get; set; }
        public DbSet<Moamen.Training.EFCore.Models.Dog> Dogs { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;Database=Test2-DB;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moamen.Training.EFCore.Models.Employee>()
                .HasOne(e => e.Car)
                .WithOne(c => c.Employee)
                .HasForeignKey<Car>(c => c.EmployeeId);

            modelBuilder.Entity<Moamen.Training.EFCore.Models.Employee>()
                .HasMany(e => e.Kids)
                .WithOne(k => k.Employee);

            modelBuilder.Entity<Moamen.Training.EFCore.Models.Employee>()
                .HasMany(e => e.Departments)
                .WithMany(d => d.Employees)
                .UsingEntity(j => j.ToTable("DepartmentEmployees"));

            modelBuilder.Entity<Moamen.Training.EFCore.Models.Department>()
                .HasData(
                new Models.Department { Id = 2, Title = "Civil Engineering" },
                new Models.Department { Id = 3, Title = "E-Learning" }
                );

        }
    }
}
