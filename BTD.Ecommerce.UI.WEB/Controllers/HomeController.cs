using BTD.Ecommerce.Core.Model;
using BTD.Ecommerce.Core.Model.Entity;
using BTD.Ecommerce.UI.WEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTD.Ecommerce.UI.WEB.Controllers
{
    public class HomeController : BTDControllerBase
    {
        BTDDB db = new BTDDB();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.IsLogin = this.IsLogin;
            var data = db.Products.OrderByDescending(x => x.CreateDate).Take(5).ToList();
            return View(data);
        }

        //Data çekeceğim bir yer oluşturuyorum.
        public PartialViewResult GetMenu()
        {
            var menus = db.Categories.Where(x => x.ParentID == 0).ToList(); //Ana menüleri çekeceğim
            return PartialView(menus);
        }

        [Route("Uye-Giris")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Uye-Giris")]
        public ActionResult Login(string Email, string Password)
        {
            var users = db.Users.Where(x => x.Email == Email && x.Password == Password && x.IsActive == true && x.IsAdmin == false).ToList();
            if (users.Count == 1)
            {
                //Giriş ok
                Session["LoginUserID"] = users.FirstOrDefault().ID;
                Session["LoginUser"] = users.FirstOrDefault();
                return Redirect("/");
            }
            else
            {
                //Giriş yapılamadı. Olduğu sayfayı göster.
                //ViewBag controllerla sayfalar arası veri taşımak için kullanılıyor.
                ViewBag.Error = "E-posta ya da şifre hatalı! ";
                return View();
            }
        }

        [Route("Uye-Kayit")]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [Route("Uye-Kayit")]
        public ActionResult CreateUser(User entity)
        {
            try
            {
                entity.CreateDate = DateTime.Now;
                entity.CreateUserID = 1;
                entity.IsActive = true;
                entity.IsAdmin = false;

                db.Users.Add(entity);
                db.SaveChanges();
                return Redirect("/");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}