using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloMVC.Controllers
{
    public class CetController : Controller
    {
        public IActionResult test()
        {
            return View();
        }
        public IActionResult hello(string name, string surname)
        {
            Student student = new Student(); ;
            student.Name = name;
            student.Surname = surname;

            return View(student);
           // return Content($"<html><head><title>Merhaba</title></head><body><h1>Merhaba {name} {surname}</h1></body></html>");
            //return "Merhaba " + name + " "+ surname;

        }

        public IActionResult helloStudent(Student student)
        {
            return View(student);
            // return Content($"<html><head><title>Merhaba</title></head><body><h1>Merhaba {name} {surname}</h1></body></html>");
            //return "Merhaba " + name + " "+ surname;

        }
    }
}
