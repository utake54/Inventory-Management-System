using Inventory.Database.DataContextClass;
using Inventory.Model.Model;
using Inventory.Utilities.UtilitiesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class UserController : Controller
    {
        InventoryDBcontext db = new InventoryDBcontext();
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            var IsExist = db.UserTable.Any(x => x.MobileNo == user.MobileNo || x.EmailId == user.EmailId);
          
            if (!IsExist)
            {
                user.Password = PasswordEncoder.EncodePassword(user.Password);
                db.UserTable.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ViewBag.SignUpFailed = "User Already Exists";
                return View();
            }
        }

        public ActionResult AssignRoleToUser()
        {
            var allUsers = db.UserTable.ToList();
            return View(allUsers);
        }
    }
}