using SpeedyCouriers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeedyCouriers.Controllers
{
    public class HomeController : Controller
    {
        SpeedyCouriersEntities db = new SpeedyCouriersEntities();
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LogIn()
        {
            //List<Account> users = db.Accounts.ToList();
            ViewBag.Message = "Your contact page.";

           return View();
        }

        [HttpPost]
        public ActionResult Autherize(SpeedyCouriers.Models.userInformation userModel)
        {
            using (db) 
            {
            var userDetails = db.userInformations.Where(x => x.Name == userModel.Name && x.Userpassword == userModel.Userpassword).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password.";
                    return View("LogIn", userModel);
                }
                else {
                    Session["userID"] = userDetails.userID;
                    Session["Name"] = userDetails.Name.ToString();
                    Session["Email"] = userDetails.Email.ToString();
                    Session["UserRole"] = userDetails.UserRole.ToString();
                    return RedirectToAction("Index", "User");
                }
            }

     
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Include = "Name, userPassword, Email,UserRole")] userInformation guest)
       {
            if (ModelState.IsValid)
            {
                db.userInformations.Add(guest);
                db.SaveChanges();
                return View();
            }

            return View();
        }
    }
}