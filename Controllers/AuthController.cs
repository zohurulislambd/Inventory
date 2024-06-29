using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory.Controllers;
using System.Web.UI.WebControls;
namespace Inventory.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account Model)
        {
            //Double Layer validation
            if (String.IsNullOrEmpty(Model.UserName) || String.IsNullOrEmpty(Model.Password))
                ViewBag.Message = "Input Needed";


            if (Model.UserName == "Zohurul" && Model.Password == "123")
            {
                Session["User"] = Model.UserName;
                
                ViewBag.Message = "Login Successfully";
                //RedirectToAction("DashBoard", "Home");
            }
            else
            { 
                ViewBag.Message = "User or password is wrong";
            }
            return View();
        }
    }
}