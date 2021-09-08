using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcApp01.Models;
namespace MvcApp01.Controllers
{
    public class StudentsController : Controller
    {
       static List<Student> students = new List<Student>()
        {
            new Student{Id=9001,SName="Anil",Course=".NET",Fee=15000},
            new Student{Id=9002,SName="Bobby",Course="MVC .NET Core",Fee=25000},
            new Student{Id=9003,SName="Cathe",Course="Angular",Fee=12000}
        };
        public IActionResult Index()    //Refers to definition return group of records
        {
            ViewBag.students = students;
            return View();
        }
        public IActionResult Details(int id)    //Refers to definition returng single record for specified id
        {
            ViewBag.s = students.Single(x => x.Id == id);
            return View();
        }
        [HttpGet]
        public IActionResult Create()   
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string sname, string course, int fee)    
        {
            Student s = new Student()
            {
                Id = id,
                SName=sname,
                Course=course,
                Fee=fee
            };
            students.Add(s);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student s = students.Single(x=>x.Id==id);
            ViewBag.s = s;
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, string sname, string course, int fee)
        {
            Student s = new Student()
            {
                Id = id,
                SName = sname,
                Course = course,
                Fee = fee
            };
            int index = students.FindIndex(x => x.Id == id);
            students[index] = s;
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student s = students.Single(x => x.Id == id);
            ViewBag.s = s;
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id, string sname, string course, int fee)
        {          
            int index = students.FindIndex(x => x.Id == id);
            students.RemoveAt(index);
            return RedirectToAction("index");
        }
    }
}
