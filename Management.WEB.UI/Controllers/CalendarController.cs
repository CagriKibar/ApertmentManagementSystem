using Manager.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Management.WEB.UI.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        DbContextArea db = new DbContextArea();
        [Authorize]
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult GetEvents()
        {
            var data = db.Events.ToList();
            return PartialView(data);
        }
    }
}