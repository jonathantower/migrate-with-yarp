using eShopLegacy.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace eShopLegacyMVC.Controllers
{
    public class SystemWebController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: SystemWeb
        public Microsoft.AspNetCore.Mvc.ActionResult Index()
        {
            ViewBag.UserAgent = SomeClass.GetHeader(System.Web.HttpContext.Current);
            return View();
        }
    }
}