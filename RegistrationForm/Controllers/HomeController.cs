using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Registration reg)
        {
            if(reg.FirstName !=null && reg.LastName != null && reg.Password != null && reg.ConfirmPassword !=null && reg.Email !=null)
            {
                return View();
            }
            return View("Index");
        }
    }
}