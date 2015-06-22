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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using test_mvc_website.Models;

namespace test_mvc_website.Controllers
{
     [Authorize]
    public class BusinessProfessionalsController : Controller
    {

        #region  security
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        #endregion


        private MyDbContext db = new MyDbContext();

        public ActionResult HowItWorks() {

            return View();
        
        }

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
        [AllowAnonymous]
         public async Task<ActionResult> Create([Bind(Include = "Id,Email,Password,ConfirmPassword,HowDidYouHearAboutUs,Industry,CompanySize,Title,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber")] BusinessProfessionalViewModel businessProfessional)
        {
            if (ModelState.IsValid)
            {


                var user = new ApplicationUser { UserName = businessProfessional.Email, Email = businessProfessional.Email };
                var result = await UserManager.CreateAsync(user, businessProfessional.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    businessProfessional.Id = Guid.NewGuid();
                    BusinessProfessional dbModel = new BusinessProfessional();
                    Reflection.CopyProperties(businessProfessional, dbModel);
                    
                    db.BusinessProfessionals.Add(dbModel);
                    db.UserMappings.Add(new UserMapping { UserId = Guid.Parse(user.Id), Type = "business",EntityId=businessProfessional.Id });
                    db.SaveChanges();
                    return RedirectToAction("HowItWorks","Home");
                }
                AddErrors(result);
            }

            return View(businessProfessional);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
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
        public ActionResult Edit([Bind(Include = "Id,Email,HowDidYouHearAboutUs,Industry,CompanySize,Title,Name,AllowFeedbackEmail,AllowSurvey,AllowCall,PhoneNumber")] BusinessProfessionalViewModel businessProfessional)
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
