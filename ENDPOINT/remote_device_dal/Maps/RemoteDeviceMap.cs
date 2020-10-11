using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using remote_device_data.Models;

namespace remote_device_dal.Maps
{
    public class RemoteDeviceMap : BaseEntityMap<RemoteDevice>
    {
        public RemoteDeviceMap(EntityTypeBuilder<RemoteDevice> entityBuilder)
        {
            base.Configure(entityBuilder);

            entityBuilder.ToTable("remote_devices");

            entityBuilder.HasDiscriminator<string>("device_type")
                .HasValue<LedStrip>(nameof(LedStrip));

            entityBuilder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50);

            entityBuilder.Property(x => x.HostName)
                .HasColumnName("hostname")
                .HasMaxLength(100);
        }
    }
}