using Microsoft.AspNetCore.Mvc;
using MVCAPP1.Models;
using System.Collections.Generic;


namespace MVCAPP1.Controllers
{
    public class HomeWorldController : Controller
    {


        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel();
            
            return View();
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
           
            return RedirectToAction(nameof(Index));


        }
    }
}
