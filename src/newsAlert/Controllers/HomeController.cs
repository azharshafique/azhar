using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using newsAlert.Models;

namespace newsAlert.Controllers
{
    public class HomeController : Controller
    {
        newssiteContext context = null;
        IHostingEnvironment env = null;
        public HomeController(IHostingEnvironment _env, newssiteContext _context)
        {
            context = _context;
            env = _env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult homepage()
        {
            IList<Videopost> pl = context.Videopost.ToList<Videopost>();

            return View(pl);
        }
        public IActionResult single(int id)
        {
            ViewBag.array = context.Videopost.Where(e => e.VideoId == id).ToList<Videopost>();
            IList<Videopost> vp = ViewBag.array;
            foreach (var file in vp) {
                var a = file.VideoName;
                IList<Videopost> pl = context.Videopost.Where(e => e.VideoName == a).ToList<Videopost>();
                return View(pl);
            }
            return View(); 
            
        }
        [HttpGet]
        public IActionResult AddVideoPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVideoPost(Videopost vp)
        {
            try
            {
                context.Videopost.Add(vp);
                context.SaveChanges();
                ViewBag.message = "Data inserted successfully";
                
            }
            catch
            {
                ViewBag.message = "Data not inserted some error occured";
               
            }
            return View("AddVideoPost");

        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
