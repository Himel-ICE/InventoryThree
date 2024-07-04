using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryThree;
using InventoryThree.Models;

namespace InventoryThree.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Account model)
        {
            if (model.UserName == "Himel" && model.Password == "1234")
            {
                Session["User"] = model.UserName;
                ViewBag.Message = "True";
                return RedirectToAction("DashBoard", "Home");
            }
            else ViewBag.Message = "False";
            return View();
        }

    }
}