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
    public class BanksController : Controller
    {
        private DbContextArea db = new DbContextArea();

        // GET: Admin/Banks
        [Authorize]
        public ActionResult Index()
        {
            var banks = db.Banks.Include(b => b.Citizen).Include(b => b.Manager);
            return View(banks.ToList());
        }

        // GET: Admin/Banks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            return View(bank);
        }

        // GET: Admin/Banks/Create
        public ActionResult Create()
        {
            ViewBag.CitizenID = new SelectList(db.Citizens, "ID", "CitizenName");
            ViewBag.ManagerID = new SelectList(db.AppManagers, "ID", "ManagerName");
            return View();
        }

        // POST: Admin/Banks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CitizenID,ManagerID,Date,Expenses,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] Bank bank)
        {
            if (ModelState.IsValid)
            {
                db.Banks.Add(bank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CitizenID = new SelectList(db.Citizens, "ID", "CitizenName", bank.CitizenID);
            ViewBag.ManagerID = new SelectList(db.AppManagers, "ID", "ManagerName", bank.ManagerID);
            return View(bank);
        }

        // GET: Admin/Banks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            ViewBag.CitizenID = new SelectList(db.Citizens, "ID", "CitizenName", bank.CitizenID);
            ViewBag.ManagerID = new SelectList(db.AppManagers, "ID", "ManagerName", bank.ManagerID);
            return View(bank);
        }

        // POST: Admin/Banks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CitizenID,ManagerID,Date,Expenses,CreateDate,UpdateDate,CreateManagerID,UpdateManagerID")] Bank bank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CitizenID = new SelectList(db.Citizens, "ID", "CitizenName", bank.CitizenID);
            ViewBag.ManagerID = new SelectList(db.AppManagers, "ID", "ManagerName", bank.ManagerID);
            return View(bank);
        }

        // GET: Admin/Banks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            return View(bank);
        }

        // POST: Admin/Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bank bank = db.Banks.Find(id);
            db.Banks.Remove(bank);
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
