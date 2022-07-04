using LeaveManagement_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        const string uName="xyz";
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (login.UserName == "Raj" && login.Password == "ss")
            {

                 HttpContext.Session.SetString("uName", login.UserName);
                return RedirectToAction("DashBoard", "User");
            }
            else
            {
                ViewBag.msg = "Invalid UserName/password";
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cancel()
        {
            return RedirectToAction("Index","Home");
        }

        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
