using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;
using MVCMiniProject.Models.ViewModels;

namespace MVCMiniProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }



























        //private readonly GroupRepository groupRepository;

        //public HomeController(GroupRepository groupRepository)
        //{
        //    this.groupRepository = groupRepository;
        //}

        //public IActionResult index()
        //{
        //    var viewmodel = groupRepository.GetAllGroups();
        //    return View(viewmodel);
        //}
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var model = groupRepository.GetGroupByID(id);
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Edit(GroupEditVM model)
        //{
        //    return View(model);
        //}

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Group model)
        //{
        //    if (!ModelState.IsValid)
        //        return View(model);

        //    groupRepository.AddGroup(model);
        //    // Persistera till DB.
        //    return RedirectToAction(nameof(index));
        //}
    }
}