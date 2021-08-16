using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using crud_dotnet.DataContext;
using crud_dotnet.Models;
using ApplicationDbContext = crud_dotnet.DataContext.ApplicationDbContext;

namespace crud_dotnet.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.CustomerObj.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerClass customerClass = db.CustomerObj.Find(id);
            if (customerClass == null)
            {
                return HttpNotFound();
            }
            return View(customerClass);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "customerid,customername,email,salary")] CustomerClass customerClass)
        {
            if (ModelState.IsValid)
            {
                db.CustomerObj.Add(customerClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerClass);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerClass customerClass = db.CustomerObj.Find(id);
            if (customerClass == null)
            {
                return HttpNotFound();
            }
            return View(customerClass);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "customerid,customername,email,salary")] CustomerClass customerClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerClass);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerClass customerClass = db.CustomerObj.Find(id);
            if (customerClass == null)
            {
                return HttpNotFound();
            }
            return View(customerClass);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerClass customerClass = db.CustomerObj.Find(id);
            db.CustomerObj.Remove(customerClass);
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
