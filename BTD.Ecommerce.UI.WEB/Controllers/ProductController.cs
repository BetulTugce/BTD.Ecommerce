using BTD.Ecommerce.Core.Model;
using BTD.Ecommerce.UI.WEB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTD.Ecommerce.UI.WEB.Controllers
{
    public class ProductController : BTDControllerBase
    {
        // GET: Product
        [Route("Urun/{title}/{id}")]
        public ActionResult Detail(string title, int id)
        {
            var db = new BTDDB();
            var product = db.Products.Where(x => x.ID == id).FirstOrDefault();
            return View(product);
        }
    }
}