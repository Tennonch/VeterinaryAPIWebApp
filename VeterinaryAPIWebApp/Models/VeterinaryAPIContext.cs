using Microsoft.EntityFrameworkCore;
using VeterinaryAPIWebApp.Models;

namespace VeterinaryAPIWebApp.Models
{
    public class VeterinaryApiContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<Visit> Visits { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }

        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<VisitService> VisitServices { get; set; }

        public VeterinaryApiContext(DbContextOptions<VeterinaryApiContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}