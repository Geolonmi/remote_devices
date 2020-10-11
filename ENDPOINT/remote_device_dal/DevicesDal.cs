using remote_device_data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remote_device_dal
{
    public class DevicesDal: IDevicesDal
    {
        private readonly AppDbContext _appDbContext;

        public DevicesDal(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<RemoteDevice> GetAll()
        {
            return _appDbContext.RemoteDevices.Select(s => new LedStrip()
            {
                Id = s.Id,
                HostName = s.HostName,
                Name = s.Name,
                CreatedAt = s.CreatedAt
            });
        }

        public async Task Add(RemoteDevice device)
        {
            _appDbContext.Add(device);

            await _appDbContext.SaveChangesAsync();
        }
    }
}
