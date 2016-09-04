using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;

namespace TodoApi.Controllers
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("home/{name}")]
        public IActionResult Index(string name){
            Student s=new Student{Id=1,Name=name,CreateTime=DateTime.Now};
            ViewBag.Name=JsonConvert.SerializeObject(s);
            return View();
        }
    }

    public class Student{
        public int Id{get;set;}

        public string Name{get;set;}

        public DateTime CreateTime{get;set;}
    }
}