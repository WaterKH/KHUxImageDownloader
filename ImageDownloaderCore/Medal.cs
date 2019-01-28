using System;
using Microsoft.EntityFrameworkCore;

namespace ImageDownloaderCore
{
    public class MedalContext : DbContext
    {
        public DbSet<KHMedal> Medal { get; set; }
        public DbSet<KHAttackMedal> KHAttackMedals { get; set; }
        public DbSet<KHMiscMedal> KHMiscMedals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite("Filename=./medals.sqlite");
        }
    }
}
