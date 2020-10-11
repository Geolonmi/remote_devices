using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using remote_device_dal;
using remote_device_data.Models;

namespace remote_device_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly IDevicesDal _devicesDal;
        public DevicesController(IDevicesDal devicesDal)
        {
            _devicesDal = devicesDal;
        }

        [HttpGet]
        public IEnumerable<RemoteDevice> Get()
        {
            return _devicesDal.GetAll();
        }

        [HttpPost]
        public async Task<int> Add([FromBody] LedStrip device)
        {
            await _devicesDal.Add(device);

            return device.Id;
        }

    }
}
