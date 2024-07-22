using Microsoft.EntityFrameworkCore;
using MvcTask01.Models;

namespace MvcTask01.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder=new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").Build();
            var connection = builder.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connection);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           var doctors = new List<Doctor>
            {
            new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
            new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
            new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
            new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
            new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
            };
            modelBuilder.Entity<Doctor>().HasData(doctors);
        }

    }
}
