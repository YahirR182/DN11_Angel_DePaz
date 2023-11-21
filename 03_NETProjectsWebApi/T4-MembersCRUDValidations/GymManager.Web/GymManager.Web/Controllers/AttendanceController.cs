using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
       
        public IActionResult MemberIn()
        {
            return View();
        }

        public IActionResult MemberOut()
        {
            return View();
        }
    }
}

