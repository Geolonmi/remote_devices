
using remote_device_dal;

namespace remote_device_services
{
   public class DevicesService
    {
        private readonly DevicesDal _devicesDal;
        public DevicesService(DevicesDal devicesDal)
        {
            _devicesDal = devicesDal;
        }
    }
}
