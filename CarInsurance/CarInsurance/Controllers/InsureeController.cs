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

        

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Admin
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<Insuree>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new Insuree(); 
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                ViewBag.Message = insureeVms;
                return View(insureeVms);
            }
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                
                int ageRate = (DateTime.Now.Year - insuree.DateOfBirth.Year) < 26 ? (((DateTime.Now.Year - insuree.DateOfBirth.Year) < 19) ? 100 : 50) : 25; 
                int carYearRate = (insuree.CarYear < 2000 ^ insuree.CarYear > 2015) ? 25 : 0;
                int carMakeModelRate = insuree.CarMake.ToUpper() == "PORSCHE" ? ((insuree.CarModel.ToUpper().Contains("911") && insuree.CarModel.ToUpper().Contains("CARRERA") == true) ? 50 : 25) : 0;
                int ticketRate = insuree.SpeedingTickets * 10;
                int duiRate = insuree.DUI == true ? 25 : 0;
                int coverageRate = insuree.CoverageType == true ? 50 : 0;
                double multiplier = (1 + (0.01 * (duiRate + coverageRate)));
                double q = (50 + ageRate + carYearRate + carMakeModelRate + ticketRate) * (multiplier);
                insuree.Quote = Convert.ToDecimal(q);
                
                if (ModelState.IsValid)
                {
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(insuree);
            }
            
            
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                
                int ageRate = (DateTime.Now.Year - insuree.DateOfBirth.Year) < 26 ? (((DateTime.Now.Year - insuree.DateOfBirth.Year) < 19) ? 100 : 50) : 25;
                int carYearRate = (insuree.CarYear < 2000 ^ insuree.CarYear > 2015) ? 25 : 0;
                int carMakeModelRate = insuree.CarMake.ToUpper() == "PORSCHE" ? ((insuree.CarModel.ToUpper().Contains("911") && insuree.CarModel.ToUpper().Contains("CARRERA") == true) ? 50 : 25) : 0;
                int ticketRate = insuree.SpeedingTickets * 10;
                int duiRate = insuree.DUI == true ? 25 : 0;
                int coverageRate = insuree.CoverageType == true ? 50 : 0;
                double multiplier = (1 + (0.01 * (duiRate + coverageRate)));
                double q = (50 + ageRate + carYearRate + carMakeModelRate + ticketRate) * (multiplier);
                insuree.Quote = Convert.ToDecimal(q);

                if (ModelState.IsValid)
                {
                    
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(insuree);
            }
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
