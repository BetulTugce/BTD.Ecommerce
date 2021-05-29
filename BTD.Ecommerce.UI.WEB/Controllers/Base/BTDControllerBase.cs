using BTD.Ecommerce.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BTD.Ecommerce.UI.WEB
{
    public class BTDControllerBase : Controller
    {
        //Kullanıcı login olduysa bu property set olacak ve herhangi bi yerden değiştirilmesin sadece bu controller içerisinden değiştirilebilsin. 
        //Dışardan buna veri atanamaması lazım

        /// <summary>
        /// Kullanıcı Login Kontrolü
        /// </summary>       
        public bool IsLogin { get; private set; }
        /// <summary>
        /// Giriş yapmış kişinin IDsi
        /// </summary>
        public int LoginUserID { get; private set; }
        /// <summary>
        /// Login User Entity
        /// </summary>
        public User LoginUserEntity { get; private set; }
        protected override void Initialize(RequestContext requestContext)
        {
            //TODO: Üye Giriş işlemleri sonrası değişecek
            //Session["LoginUserID"]
            //Session["LoginUser"]
            if (requestContext.HttpContext.Session["LoginUserID"] != null) 
            {
                //Kullanıcı giriş yapmış
                IsLogin = true;
                LoginUserID = (int)requestContext.HttpContext.Session["LoginUserID"];
                LoginUserEntity = (Core.Model.Entity.User)requestContext.HttpContext.Session["LoginUser"];
            }
            base.Initialize(requestContext);
        }
    }
}