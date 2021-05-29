using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BTD.Ecommerce.UI.WEB.Areas.Admin
{
    public class AdminControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var IsLogin = false;
            if (requestContext.HttpContext.Session["AdminLoginUser"] == null)
            {
                //Admin girişi yapılmamış
                requestContext.HttpContext.Response.Redirect("Admin/AdminLogin"); //MVC devreye girmedi ezdiğimiz için aşağıdakini yazamıyoruz. Mvcyi ezdik.
                //Redirect("Admin/AdminLogin");
            }
            else
            {
                //Sorun yok admin içeride, sayfayı çalıştır.
            }
            base.Initialize(requestContext);
        }
    }
}