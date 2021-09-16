using Manager.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Management.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DbContextArea db = new DbContextArea();
        public ActionResult Index()
        {
            return View();

        }
        
    }
}