using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace ab.Controllers
{
    [Route("")]
    [Route("api/[controller]")]
    [ApiController]
    public class AbController : ControllerBase
    {

        IConfiguration c;
        public AbController(IConfiguration c)
        {
            this.c = c;
        }
        // GET api/values
        [Route("")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Enumerable.Range(0, 10).Select(a => "ab :" + a).ToList();
        }
        [Route("info")]
        [HttpGet]
        public ActionResult<string> GetInfo()
        {
            return "ab running instance" + c.GetSection("eureka").GetSection("instance").GetValue(typeof(string),"instanceId");
        }
    }
}
