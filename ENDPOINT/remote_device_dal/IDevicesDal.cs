using remote_device_data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace remote_device_dal
{
    public interface IDevicesDal
    {
        IEnumerable<RemoteDevice> GetAll();

        Task Add(RemoteDevice device);
    }
}
