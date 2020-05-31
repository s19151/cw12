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
        public string Index()
        {
            return "This is the default action";
        }

        //GET: /HelloWorld/Welcome/1?name=string
        public string Welcome(string name, int ID = 1) 
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}