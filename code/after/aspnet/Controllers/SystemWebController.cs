using MyClassLibrary;
using System.Web;
using System.Web.Http;

namespace migrate_with_yarp.Controllers
{
    public class SystemWebController : ApiController
    {
        [Route("systemweb/useragent")]
        [HttpGet]
        public IHttpActionResult GetUserAgent()
        {
            return Ok(Helper.UserAgent);
        }
    }
}