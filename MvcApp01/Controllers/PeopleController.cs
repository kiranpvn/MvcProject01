using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcApp01.Models;

namespace MvcApp01.Controllers
{
    public class PeopleController : Controller
    {
        List<Person> people = new List<Person>() {
                new Person() { Id = 1001, PName = "Ramya", Gender = "Female", Age = 25 },
                new Person() { Id = 1002, PName = "Raj", Gender = "Male", Age = 10 },
                new Person() { Id = 1003, PName = "Aryan", Gender = "Male", Age = 8},
                new Person() { Id = 1004, PName = "Sravanthi", Gender = "Female", Age = 28 }
            };

        public IActionResult Index()
        {            
            ViewBag.people = people;
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.p = people.Single(x => x.Id == id);
            return View();
        }
    }
}
