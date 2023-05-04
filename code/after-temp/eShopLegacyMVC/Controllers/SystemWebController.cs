using eShopLegacy.Utilities;

namespace eShopLegacyMVC.Controllers
{
    public class SystemWebController : System.Web.Mvc.Controller
    {
        // GET: SystemWeb
        public System.Web.Mvc.ActionResult Index()
        {
            ViewBag.UserAgent = SomeClass.GetHeader(System.Web.HttpContext.Current);
            return View();
        }
    }
}