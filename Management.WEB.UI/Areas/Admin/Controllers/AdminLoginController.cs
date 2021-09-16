using Manager.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Management.WEB.UI.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        DbContextArea db = new DbContextArea();
        // GET: Admin/AdminLogin
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string password)
        {
            var data = db.AppManagers.FirstOrDefault(x => x.Email == Email && x.Password == password
              && x.IsActive == true && x.IsAdmin==true);
            if (data != null)
            {
                FormsAuthentication.SetAuthCookie(data.Email, false);
                Session["Email"] = data.Email;
                return RedirectToAction("Index", "AppManagers");
                //True Login
            }
            else
            {
                //failed
                ViewBag.Error = "Hatalı Kullanıcı veya Şifre";
                return RedirectToAction("Index");//hatalı ise geri anasayfa dön
            }
        }
    }
}