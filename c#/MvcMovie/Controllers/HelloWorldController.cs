using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            // renders the HTML in Views -> HelloWorld -> Index.cshtml
            return View();
        }


        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name = "joe", int numTimes = 1)
        {
            // ViewData is a dictionary that is passed to our view template
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            // renders the HTML in Views -> HelloWorld -> Welcome.cshtml
            return View();
        }
    }
}
