using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace migrate_with_yarp.Controllers
{
    [ApiController]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "core1", "core2" };
        }
    }
}
