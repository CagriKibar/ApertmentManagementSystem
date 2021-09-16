using Manager.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace Management.WEB.UI.Controllers
{
    public class CitizenLoginController : Controller
    {
        // GET: CitizenLogin
        DbContextArea db = new DbContextArea();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string password)
        {
            var data = db.Citizens.FirstOrDefault(x => x.Email == Email && x.Password == password
              && x.IsActive == true);
            if (data !=null)
            {
                FormsAuthentication.SetAuthCookie(data.Email, false);
                Session["Email"] = data.Email;
                return RedirectToAction("Index", "CitizenList");
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