using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        private decimal CalculateQuote(Insuree insuree)
        {
            //giving quote the starting base rate
            decimal baseQuote = 50m;
            decimal quote = baseQuote;

            //calculates quote based off of insuree's age
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
            {
                quote += 100m;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
            {
                quote += 50m;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 26)
            {
                quote += 25m;
            }

            //calculates quote based off of car's year
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }
            if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            //calculates quote based off of car's make and model
            if (insuree.CarMake == "Porsche")
            {
                quote += 25m;
                if (insuree.CarModel == "911 Carrera")
                {
                    quote += 25m;
                }
            }

            //adds additional $10 to quote for every ticket insuree has
            quote += insuree.SpeedingTickets * 10;

            if (insuree.DUI == true)
            {
                quote = quote * 1.25m;
            }

            if (insuree.ConverageType == true)
            {
                quote = quote * 1.5m;
            }

            return quote;
        }

        public ActionResult Admin()
        {
            var allInsurees = db.Insurees.ToList();

            return View(allInsurees);
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,ConverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //calculates quote using CalculateQuote based off of data given
                insuree.Quote = CalculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,ConverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
