using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public MembersController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

        public IActionResult Index()
        {
            List<Member> members = _membersAppService.GetMembers();

            MemberListViewModel memberListViewModel = new MemberListViewModel
            {
                NewMembersCount = 2,
                Members = members
            };
            return View(memberListViewModel);
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}

