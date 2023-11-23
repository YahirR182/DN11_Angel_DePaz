using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IMembersAppService _membersAppService;

        public HomeController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

    
        public IActionResult Index()
        {

            var members = _membersAppService.GetMembers();
            return View(members);
        }
    }
}

