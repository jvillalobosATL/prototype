using System;
using System.Collections.Generic;
using System.Linq;
using test_mvc_website.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using test_mvc_website.App_Data;

namespace test_mvc_website.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext db = new MyDbContext();
        public HomeController() { 
        
        }
       [Authorize]
        public ActionResult HowItWorks()
        {
            //Guid userGuid = (Guid)Membership.GetUser().ProviderUserKey;
            AspNetUser user = db.AspNetUsers.Where(x =>x.UserName == User.Identity.Name).FirstOrDefault();
                     
            if (user == null)
            {
                throw new InvalidOperationException("User [" +
                    User.Identity.Name + " ] not found.");
            }

            // Do whatever u want with the unique identifier.
            Guid guid = Guid.Parse(user.Id);
            UserMapping userMapping = db.UserMappings.Find(guid);
            ViewBag.UserType = userMapping.Type;
            return View();

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //if (User!=null)
            //    if (User.Identity!=null)
            //    {
            //        AspNetUser user = db.AspNetUsers.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();

            //        if (user != null)
            //        {
            //            return View(new ContactUs {Email = user.Email,})
            //        }
            //    }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Contact([Bind(Include = "Id,Email,Name,Message")] ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {

                //if (User!=null)
                //    if (User.Identity != null)
                //    {
                //        AspNetUser user = db.AspNetUsers.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();

                //        if (user != null)
                //        {
                //            contactUs.User
                //        }
                //    }
                    contactUs.Id = Guid.NewGuid();
                    db.ContactUs.Add(contactUs);
                    db.SaveChanges();
                    return RedirectToAction("HowItWorks", "Home");
              
            }

            return View(contactUs);
        }

        public ActionResult Thanks()
        {
            ViewBag.Message = "Your thanks page.";

            return View();
        }
    }
}