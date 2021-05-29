using BTD.Ecommerce.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTD.Ecommerce.UI.WEB.Controllers
{
    public class BasketController : BTDControllerBase
    {
        // GET: Basket
        [HttpPost]
        public JsonResult AddProduct(int productID, int quantity)
        {
            //Login olmayan buraya gelemeyecek, kullanıcı da bunu görmeyecek yani arka planda gidip gelecek.
            var db = new BTDDB();
            db.Baskets.Add(new Core.Model.Entity.Basket
            {
                CreateDate = DateTime.Now,
                CreateUserID = LoginUserID,
                ProductID = productID,
                Quantity = quantity,
                UserID = LoginUserID
            });
            var rt = db.SaveChanges();
            return Json(rt, JsonRequestBehavior.AllowGet);
        }
    }
}