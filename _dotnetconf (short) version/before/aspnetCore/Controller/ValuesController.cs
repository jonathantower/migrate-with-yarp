using Microsoft.AspNetCore.Mvc;

namespace aspnetCore.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1-core", "value2-core" };
        }
    }
}
