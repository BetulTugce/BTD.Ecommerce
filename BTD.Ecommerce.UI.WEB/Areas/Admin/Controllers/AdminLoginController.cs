using BTD.Ecommerce.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTD.Ecommerce.UI.WEB.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        BTDDB db = new BTDDB();
        public ActionResult Index()
        {
            //Buraya view eklerken masterpagee dahil etmicem. Yani layout kullanmicam. Çünkü masterpageimi görmemesi lazım.
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string Password)
        {
            var data = db.Users.Where(x => x.Email == Email && x.Password == Password && x.IsActive == true && x.IsAdmin == true).ToList();
            if (data.Count==1)
            {
                //Doğru giriş
                Session["AdminLoginUser"] = data.FirstOrDefault(); //Tüm tabloyu, tüm verileri içine attım
                return Redirect("/admin");
            }
            else
            {
                //Hatalı giriş. Aynı sayfaya dönecek
                return View();
            }           
        }
    }
}