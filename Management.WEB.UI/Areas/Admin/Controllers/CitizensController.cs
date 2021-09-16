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
    public class CitizensController : Controller
    {
        private DbContextArea db = new DbContextArea();

        // GET: Admin/Citizens
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Citizens.ToList());
        }

        // GET: Admin/Citizens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // GET: Admin/Citizens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Citizens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CitizenName,CitizenLastName,Number,Telephone,Email,Password,Payment,PaymentDate,IsActive,IsManager,EventID,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] Citizen citizen)
        {
            if (ModelState.IsValid)
            {
                db.Citizens.Add(citizen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(citizen);
        }

        // GET: Admin/Citizens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // POST: Admin/Citizens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CitizenName,CitizenLastName,Number,Telephone,Email,Password,Payment,PaymentDate,IsActive,IsManager,EventID,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] Citizen citizen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citizen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(citizen);
        }

        // GET: Admin/Citizens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // POST: Admin/Citizens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Citizen citizen = db.Citizens.Find(id);
            db.Citizens.Remove(citizen);
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
