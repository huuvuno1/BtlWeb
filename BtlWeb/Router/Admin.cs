using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace BtlWeb.Router
{
    public class Admin
    {
        public static void routerAdmin(RouteCollection routes)
        {
            routes.MapPageRoute("admin", "admin", "~/Views/Admin/home.aspx");
        }
    }
}