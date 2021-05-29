using BTD.Ecommerce.Core.Model;
using BTD.Ecommerce.UI.WEB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTD.Ecommerce.UI.WEB.Controllers
{
    public class CategoryController : BTDControllerBase
    {
        // GET: Category
        [Route("Kategori/{isim}/{id}")]
        public ActionResult Index(string isim, int id)
        {
            var db = new BTDDB();
            var data = db.Products.Where(x => x.IsActive == true && x.CategoryID == id).ToList();
            ViewBag.category = db.Categories.Where(x => x.ID == id).FirstOrDefault();
            return View(data);
        }
    }
}