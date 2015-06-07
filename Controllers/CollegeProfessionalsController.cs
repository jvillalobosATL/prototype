using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test_mvc_website.App_Data;
using test_mvc_website.General;

namespace test_mvc_website.Controllers
{
     [Authorize]
    public class CollegeProfessionalsController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: CollegeProfessionals
        public ActionResult Index()
        {
            return View(db.CollegeProfessionals.ToList());
        }

        // GET: CollegeProfessionals/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollegeProfessional collegeProfessional = db.CollegeProfessionals.Find(id);
            if (collegeProfessional == null)
            {
                return HttpNotFound();
            }
            return View(collegeProfessional);
        }

        // GET: CollegeProfessionals/Create
         [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CollegeProfessionals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
         public ActionResult Create([Bind(Include = "Id,Email,Description,AreaOfStudy,YearsWorked,DegreeMayor,UniversityName,Password,ConfirmPassword,HowDidYouHearAboutUs,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber,UniversityInvolvement")] CollegeProfessionalViewModel collegeProfessional)
        {
            if (ModelState.IsValid)
            {
                collegeProfessional.Id = Guid.NewGuid();
                CollegeProfessional dbModel = new CollegeProfessional();
                Reflection.CopyProperties(collegeProfessional,dbModel);

                db.CollegeProfessionals.Add(dbModel);
                db.SaveChanges();
                return RedirectToAction("Thanks", "Home");
            }

            return View(collegeProfessional);
        }

        // GET: CollegeProfessionals/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollegeProfessional collegeProfessional = db.CollegeProfessionals.Find(id);
            if (collegeProfessional == null)
            {
                return HttpNotFound();
            }
            return View(collegeProfessional);
        }

        // POST: CollegeProfessionals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Description,AreaOfStudy,YearsWorked,HowDidYouHearAboutUs,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber")] CollegeProfessionalViewModel collegeProfessional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collegeProfessional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collegeProfessional);
        }

        // GET: CollegeProfessionals/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollegeProfessional collegeProfessional = db.CollegeProfessionals.Find(id);
            if (collegeProfessional == null)
            {
                return HttpNotFound();
            }
            return View(collegeProfessional);
        }

        // POST: CollegeProfessionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CollegeProfessional collegeProfessional = db.CollegeProfessionals.Find(id);
            db.CollegeProfessionals.Remove(collegeProfessional);
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
