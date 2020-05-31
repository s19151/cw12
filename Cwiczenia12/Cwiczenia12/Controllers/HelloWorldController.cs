using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia12.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome?name=string&numTimes=1
        public IActionResult Welcome(string name, int numTimes) 
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}