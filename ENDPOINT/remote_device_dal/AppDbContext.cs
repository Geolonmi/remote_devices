using Microsoft.EntityFrameworkCore;
using remote_device_dal.Maps;
using remote_device_services.Models;
using System;
using System.Linq;

namespace remote_device_dal{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<RemoteDevice> RemoteDevices { get; set; }
        public DbSet<LedStrip> LedStrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new RemoteDeviceMap(modelBuilder.Entity<RemoteDevice>());
            new LedStripMap(modelBuilder.Entity<LedStrip>());
        }

        public override int SaveChanges()
        {
            SetTimestamps();
            return base.SaveChanges();
        }

        private void SetTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && 
                (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}