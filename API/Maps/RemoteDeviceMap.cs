using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace rmteapi.Maps
{
    public class RemoteDeviceMap
    {
        public RemoteDeviceMap(EntityTypeBuilder<RemoteDevice> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.ToTable("remote_devices");

            entityBuilder.HasDiscriminator<string>("device_type")
                .HasValue<LedStrip>(nameof(LedStrip));

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Name).HasColumnName("name");
            entityBuilder.Property(x => x.HostName).HasColumnName("hostname");
        }
    }
}