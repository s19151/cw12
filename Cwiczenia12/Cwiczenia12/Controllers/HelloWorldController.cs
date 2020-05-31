using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia12.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public string Index()
        {
            return "This is the default action";
        }

        //GET: /HelloWorld/Welcome/
        public string Welcome() 
        {
            return "This is the Welcome action Method";
        }
    }
}