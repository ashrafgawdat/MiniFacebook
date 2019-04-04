using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.PlatformAbstractions;
using Mini_Facebook.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Mini_Facebook.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult GetImage(string name)
        //{ 
        //    var dir = ApplicationEnvironment.ApplicationBasePath;

        //    var image = System.IO.File.OpenRead(dir + "\\UserImages" );

        //    return File(image, "image/jpeg");

        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
