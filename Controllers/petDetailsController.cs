using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gb538515Mis4200.DAL;
using gb538515Mis4200.Models;

namespace gb538515Mis4200.Controllers
{
    public class petDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: petDetails
        public ActionResult Index()
        {
            var petDetails = db.petDetails.Include(p => p.Pet).Include(p => p.Visit);
            return View(petDetails.ToList());
        }

        // GET: petDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            petDetail petDetail = db.petDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            return View(petDetail);
        }

        // GET: petDetails/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName");
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description");
            return View();
        }

        // POST: petDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petdetailID,numberVisits,accumulatedBill,medicineOrdered,ownerEmail,petID,visitID")] petDetail petDetail)
        {
            if (ModelState.IsValid)
            {
                db.petDetails.Add(petDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", petDetail.petID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", petDetail.visitID);
            return View(petDetail);
        }

        // GET: petDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            petDetail petDetail = db.petDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", petDetail.petID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", petDetail.visitID);
            return View(petDetail);
        }

        // POST: petDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petdetailID,numberVisits,accumulatedBill,medicineOrdered,ownerEmail,petID,visitID")] petDetail petDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", petDetail.petID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", petDetail.visitID);
            return View(petDetail);
        }

        // GET: petDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            petDetail petDetail = db.petDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            return View(petDetail);
        }

        // POST: petDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            petDetail petDetail = db.petDetails.Find(id);
            db.petDetails.Remove(petDetail);
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
