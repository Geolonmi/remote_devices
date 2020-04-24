using Microsoft.EntityFrameworkCore;
using remote_device_api.Maps;

namespace remote_device_api.Models{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

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