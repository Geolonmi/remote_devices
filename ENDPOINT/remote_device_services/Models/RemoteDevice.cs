using System.ComponentModel.DataAnnotations;

namespace remote_device_services.Models
{
    public abstract class RemoteDevice
    {
        public RemoteDevice() { }
        public RemoteDevice(RemoteDevice remoteDevice)
        {
            Id = remoteDevice.Id;
            Name = remoteDevice.Name;
            HostName = remoteDevice.HostName;
        }
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string HostName { get; set; }
    }
}
