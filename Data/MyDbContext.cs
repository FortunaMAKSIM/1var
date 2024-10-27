using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _1var.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<Applica> Applicas { get; set; }
        public DbSet<ApplicationComment> ApplicationComments { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applica>()
                .HasIndex(a => a.Number)
                .IsUnique();
        }

    }
}
