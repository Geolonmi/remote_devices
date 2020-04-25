using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using remote_device_services.Models;

namespace remote_device_dal.Maps
{
    public class LedStripMap
    {
        public LedStripMap(EntityTypeBuilder<LedStrip> entityBuilder)
        {
            entityBuilder.Property(x => x.MinBrightness).HasColumnName("min_brightness");
            entityBuilder.Property(x => x.MaxBrightness).HasColumnName("max_brightness");
        }
    }
}