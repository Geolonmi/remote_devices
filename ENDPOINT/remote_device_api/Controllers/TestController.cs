using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using remote_device_dal;

namespace remote_device_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public TestController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            return _appDbContext.RemoteDevices.Select(s => s.Id);
        }
    }
}
