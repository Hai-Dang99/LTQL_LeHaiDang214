using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050214.Models;

namespace LTQL_1721050214.Controllers
{
    public class LopHoc214sController : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: LopHoc214s
        public ActionResult Index()
        {
            return View(db.LopHoc214s.ToList());
        }

        private ActionResult View(object p)
        {
            throw new NotImplementedException();
        }

        // GET: LopHoc214s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc214 lopHoc214 = db.LopHoc214s.Find(id);
            if (lopHoc214 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc214);
        }

        // GET: LopHoc214s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc214s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] LopHoc214 lopHoc214)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc214s.Add(lopHoc214);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc214);
        }

        // GET: LopHoc214s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc214 lopHoc214 = db.LopHoc214s.Find(id);
            if (lopHoc214 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc214);
        }

        // POST: LopHoc214s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] LopHoc214 lopHoc214)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc214).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc214);
        }

        // GET: LopHoc214s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc214 lopHoc214 = db.LopHoc214s.Find(id);
            if (lopHoc214 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc214);
        }

        // POST: LopHoc214s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc214 lopHoc214 = db.LopHoc214s.Find(id);
            db.LopHoc214s.Remove(lopHoc214);
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
