using Microsoft.EntityFrameworkCore;
using remote_device_dal.Maps;
using remote_device_services.Models;

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
    }
}