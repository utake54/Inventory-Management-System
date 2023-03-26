using Inventory.Database.DataContextClass;
using Inventory.ModelDTO.DTO;
using Inventory.Utilities.UtilitiesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class AccountController : Controller
    {
        InventoryDBcontext db = new InventoryDBcontext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDTO user)
        {
            if (user.Password != null)
            {
                user.Password = PasswordEncoder.EncodePassword(user.Password);
                var IsValid = db.UserTable.Any(x => x.EmailId == user.LoginID || x.MobileNo == user.LoginID && x.Password == user.Password);

                if (IsValid)
                {
                    return RedirectToAction("CategoryList", "Category");
                }

                else
                {
                    ViewBag.LoginFailed = "Please Enter Correct Login Id & Password....!!!";
                    return View();
                }
            }
            else
            {
                ViewBag.Empty = "Login Id and Password Cannot be empty..";
                return View();
            }

        }

        public ActionResult LogOut()
        {
            return RedirectToAction("Login");
        }
    }
}