using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ComponentsLife.Models;

namespace ComponentsLife.Controllers
{
    public class DrivetrainsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Drivetrains
        public ActionResult Index()
        {
            return View(db.Drivetrains.ToList());
        }

        // GET: Drivetrains/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drivetrain drivetrain = db.Drivetrains.Find(id);
            if (drivetrain == null)
            {
                return HttpNotFound();
            }
            return View(drivetrain);
        }

        // GET: Drivetrains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drivetrains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,notes,currentKilometers,maxKilometers")] Drivetrain drivetrain)
        {
            if (ModelState.IsValid)
            {
                db.Drivetrains.Add(drivetrain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drivetrain);
        }

        // GET: Drivetrains/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drivetrain drivetrain = db.Drivetrains.Find(id);
            if (drivetrain == null)
            {
                return HttpNotFound();
            }
            return View(drivetrain);
        }

        // POST: Drivetrains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,notes,currentKilometers,maxKilometers")] Drivetrain drivetrain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drivetrain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drivetrain);
        }

        // GET: Drivetrains/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drivetrain drivetrain = db.Drivetrains.Find(id);
            if (drivetrain == null)
            {
                return HttpNotFound();
            }
            return View(drivetrain);
        }

        // POST: Drivetrains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drivetrain drivetrain = db.Drivetrains.Find(id);
            db.Drivetrains.Remove(drivetrain);
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
