using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Manager.Core.Model;
using Manager.Core.Model.Entity;

namespace Management.WEB.UI.Areas.Admin.Controllers
{
    public class AppManagersController : Controller
    {
        private DbContextArea db = new DbContextArea();

        // GET: Admin/AppManagers
        [Authorize]
        public ActionResult Index()
        {
            return View(db.AppManagers.ToList());
        }

        // GET: Admin/AppManagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppManager appManager = db.AppManagers.Find(id);
            if (appManager == null)
            {
                return HttpNotFound();
            }
            return View(appManager);
        }

        // GET: Admin/AppManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AppManagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ManagerName,ManagerLastName,Email,Password,IsActive,IsAdmin,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] AppManager appManager)
        {
            if (ModelState.IsValid)
            {
                db.AppManagers.Add(appManager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appManager);
        }

        // GET: Admin/AppManagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppManager appManager = db.AppManagers.Find(id);
            if (appManager == null)
            {
                return HttpNotFound();
            }
            return View(appManager);
        }

        // POST: Admin/AppManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ManagerName,ManagerLastName,Email,Password,IsActive,IsAdmin,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] AppManager appManager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appManager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appManager);
        }

        // GET: Admin/AppManagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppManager appManager = db.AppManagers.Find(id);
            if (appManager == null)
            {
                return HttpNotFound();
            }
            return View(appManager);
        }

        // POST: Admin/AppManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppManager appManager = db.AppManagers.Find(id);
            db.AppManagers.Remove(appManager);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
