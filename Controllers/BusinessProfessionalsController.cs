using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test_mvc_website.App_Data;

namespace test_mvc_website.Controllers
{
     [Authorize]
    public class BusinessProfessionalsController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: BusinessProfessionals
        public ActionResult Index()
        {
            List<BusinessProfessional> t = db.BusinessProfessionals.ToList();
            return View(t);
        }

        // GET: BusinessProfessionals/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfessional businessProfessional = db.BusinessProfessionals.Find(id);
            if (businessProfessional == null)
            {
                return HttpNotFound();
            }
            return View(businessProfessional);
        }

        // GET: BusinessProfessionals/Create
         [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessProfessionals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,HowDidYouHearAboutUs,Industry,CompanySize,Title,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber")] BusinessProfessional businessProfessional)
        {
            if (ModelState.IsValid)
            {
                businessProfessional.Id = Guid.NewGuid();
                db.BusinessProfessionals.Add(businessProfessional);
                db.SaveChanges();
                return RedirectToAction("Thanks","Home");
            }

            return View(businessProfessional);
        }

        // GET: BusinessProfessionals/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfessional businessProfessional = db.BusinessProfessionals.Find(id);
            if (businessProfessional == null)
            {
                return HttpNotFound();
            }
            return View(businessProfessional);
        }

        // POST: BusinessProfessionals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,HowDidYouHearAboutUs,Industry,CompanySize,Title,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber")] BusinessProfessional businessProfessional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessProfessional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(businessProfessional);
        }

        // GET: BusinessProfessionals/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfessional businessProfessional = db.BusinessProfessionals.Find(id);
            if (businessProfessional == null)
            {
                return HttpNotFound();
            }
            return View(businessProfessional);
        }

        // POST: BusinessProfessionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            BusinessProfessional businessProfessional = db.BusinessProfessionals.Find(id);
            db.BusinessProfessionals.Remove(businessProfessional);
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
