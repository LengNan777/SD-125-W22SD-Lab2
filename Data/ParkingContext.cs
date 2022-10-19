using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_125_W22SD_Lab2.Models;

namespace SD_125_W22SD_Lab2.Data
{
    public class ParkingContext : DbContext
    {
        public ParkingContext (DbContextOptions<ParkingContext> options)
            : base(options)
        {
        }

        public DbSet<SD_125_W22SD_Lab2.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<SD_125_W22SD_Lab2.Models.Pass> Passes { get; set; } = default!;
        public DbSet<SD_125_W22SD_Lab2.Models.ParkingSpot> ParkingSpots { get; set; } = default!;
        public DbSet<SD_125_W22SD_Lab2.Models.Reservation> Reservations { get; set; } = default!;
    }
}
