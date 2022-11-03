using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyClassLibrary
{
    public static class Helper
    {
        public static string UserAgent => HttpContext.Current.Request.UserAgent;
    }
}
