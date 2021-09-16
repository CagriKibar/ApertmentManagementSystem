using Manager.Core.Model;
using Manager.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Management.WEB.UI.Controllers
{
    public class CitizenListController : Controller
    {
        // GET: CitizenList
        DbContextArea db = new DbContextArea();
        [Authorize]
        public ActionResult Index()
        {
            var city = db.Citizens.ToList();
            return View(city);
        }
        
       public PartialViewResult GetData()
        {
            var data = db.Citizens.ToList();
            return PartialView(data);
        }
        [Authorize]
        public PartialViewResult GetName()
        {
            var data = db.Citizens.ToList();
            return PartialView(data);
        }
    }
       
}