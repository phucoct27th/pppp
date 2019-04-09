using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using kiemtra.Models;

namespace kiemtra.Controllers
{
    public class dmsanphamsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: dmsanphams
        public ActionResult Index()
        {
            return View(db.dmsanphams.ToList());
        }

        // GET: dmsanphams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dmsanpham dmsanpham = db.dmsanphams.Find(id);
            if (dmsanpham == null)
            {
                return HttpNotFound();
            }
            return View(dmsanpham);
        }

        // GET: dmsanphams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dmsanphams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maDM,tenDM")] dmsanpham dmsanpham)
        {
            if (ModelState.IsValid)
            {
                db.dmsanphams.Add(dmsanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dmsanpham);
        }

        // GET: dmsanphams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dmsanpham dmsanpham = db.dmsanphams.Find(id);
            if (dmsanpham == null)
            {
                return HttpNotFound();
            }
            return View(dmsanpham);
        }

        // POST: dmsanphams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maDM,tenDM")] dmsanpham dmsanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dmsanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dmsanpham);
        }

        // GET: dmsanphams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dmsanpham dmsanpham = db.dmsanphams.Find(id);
            if (dmsanpham == null)
            {
                return HttpNotFound();
            }
            return View(dmsanpham);
        }

        // POST: dmsanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dmsanpham dmsanpham = db.dmsanphams.Find(id);
            db.dmsanphams.Remove(dmsanpham);
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
