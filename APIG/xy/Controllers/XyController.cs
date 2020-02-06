using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace xy.Controllers
{

    [Route("")]
    [Route("api/[controller]")]
    [ApiController]
    public class XyController : ControllerBase
    {
        IConfiguration c;
        public XyController(IConfiguration c)
        {
            this.c = c;
        }
        // GET api/values
        [Route("")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Enumerable.Range(0, 10).Select(a => "xy :" + a).ToList();

        }
        [Route("info")]
        [HttpGet]
        public ActionResult<string> GetInfo()
        {
            return "xy running instance" + c.GetSection("eureka").GetSection("instance").GetValue(typeof(string), "instanceId");
        }
    }
}
