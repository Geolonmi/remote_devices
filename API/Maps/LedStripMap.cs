using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace rmteapi.Maps
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