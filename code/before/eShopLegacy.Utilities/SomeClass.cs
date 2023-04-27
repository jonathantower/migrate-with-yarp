using System.Web;

namespace eShopLegacy.Utilities
{
    public class SomeClass
    {
        public static string GetHeader(HttpContext context)
        {
            return context.Request.Headers["User-Agent"];
        }
    }
}
