using InventoryThree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryThree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashBoard()
        {
            Equipment.EquipmentList();
            return View();
        }
    }
}