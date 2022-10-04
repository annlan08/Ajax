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
            return Content("Hello 帥哥沛軒","text/html",System.Text.Encoding.UTF8);
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
            return Content($"Hello 帥哥{name}","text / html",System.Text.Encoding.UTF8);
        }
    }
}
