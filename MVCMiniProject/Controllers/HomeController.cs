using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;
using MVCMiniProject.Models.Entities;
using MVCMiniProject.Models.ViewModels;

namespace MVCMiniProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly HuginRepository repository;

        public HomeController(HuginRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var model = repository.GetAllGroups();
            return View(model);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Create()
        {
            var model = repository.PrintGroupForm();
            return View(model);
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