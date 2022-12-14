using Ajax.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Controllers
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello","text/html",System.Text.Encoding.UTF8);
        }

        private readonly IWebHostEnvironment _host;
        private readonly DemoContext _context;
        private readonly NorthwindContext _Ncontext;

        public APIController(IWebHostEnvironment host,DemoContext context, NorthwindContext Ncontext)
        {
            _host = host;
            _context = context;
            _Ncontext = Ncontext;
        }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult Text()
        {
            return View();
        }

        public IActionResult SayHello(string name)
        {
            System.Threading.Thread.Sleep(2000);
            if(string.IsNullOrEmpty(name))
            {
                name = "無名氏";
            }
            return Content($"Hello {name}","text / html",System.Text.Encoding.UTF8);
        }

        public IActionResult Register(Member member)
        {
            string result = "";

            if (_context.Members.Where(m => m.Name == member.Name).Any())
            {
                result += "name ";
            }

            if (_context.Members.Where(m => m.Email == member.Email).Any())
            {
                result += "email ";
            }

            if (string.IsNullOrEmpty(result)) 
            {
                result = "";
                _context.Members.Add(member);
                _context.SaveChanges();
                return Content("OK", "text/plain");
            }
            return Content($"{result}", "text/plain");
            //string info = _host.ContentRootPath + " //// " + _host.WebRootPath;
            //return Content(info, "text/plain");
        }

        public IActionResult Promsie()
        {
            return View();
        }

        public IActionResult Fetch()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }


        public IActionResult city()
        {
            var City = _context.Addresses.Select(c => c.City).Distinct();
            return Json(City);
        }

        public IActionResult site(string city)
        {
            var Site = _context.Addresses.Where(s => s.City == city).Select(s => s.SiteId).Distinct();
            return Json(Site);
        }

        public IActionResult road(string site)
        {
            var Road = _context.Addresses.Where(r => r.SiteId == site).Select(r => r.Road).Distinct();
            return Json(Road);
        }

        public IActionResult product(string keyword)
        {
            var prod = _Ncontext.Products.Where(p => p.ProductName.Contains(keyword)).Select(p => p.ProductName).ToArray();
            return Json(prod);
        }
    }
}
