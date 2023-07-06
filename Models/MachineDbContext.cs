using Microsoft.EntityFrameworkCore;
using System;

namespace FarmEquipmentTracker.Models
{
    public class MachineDbContext : DbContext
    {
        public MachineDbContext(DbContextOptions<MachineDbContext> options) : base(options) 
        {
        }
        public DbSet<Machine> Machine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Toms-Lappy;Initial Catalog=FarmTracker; Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
