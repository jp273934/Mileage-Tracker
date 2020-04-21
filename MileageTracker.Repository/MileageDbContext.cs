using Microsoft.EntityFrameworkCore;
using MileageTracker.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MileageTracker.Repository
{
    public class MileageDbContext : DbContext
    {
        public DbSet<Mileage> Mileage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MileageDb;Trusted_Connection=True;");
        }
    }
}
