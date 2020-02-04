using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("")]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [Route("")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Getwww()
        {
            return new string[] { "foo123 value1", "foo123 value2",Process.GetCurrentProcess().ProcessName };
        }
        [Route("[action]")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetIndex()
        {
            return new string[] { "Index value1", "Index value2" };
        }
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Getwww()
        //{
        //    return new string[] { "www value1", "www value2" };
        //}
    }
}
