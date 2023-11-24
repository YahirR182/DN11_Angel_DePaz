using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManager.ApplicationServices.MembershipTypes;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {

        private readonly IMembershipTypesAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService=membershipTypesAppService;
        }


        public IActionResult Index()
        {

            List<MembershipType> membershipTypes = _membershipTypesAppService.GetMembershipTypes();
            MembershipTypesListViewModel membershipTypesListViewModel = new MembershipTypesListViewModel {

                MembershipTypes = membershipTypes
            };
            return View(membershipTypesListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MembershipType membership)
        {
            _membershipTypesAppService.AddMembershipType(membership);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int membershipId)
        {
            _membershipTypesAppService.DeleteMembershipType(membershipId);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int membershipId)
        {
            MembershipType membership = _membershipTypesAppService.GetMembershipType(membershipId);

            return View(membership);
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membership)
        {
            _membershipTypesAppService.EditMembershipType(membership);
            return RedirectToAction("Index");
        }



    }
}

