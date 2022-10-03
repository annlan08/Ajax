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
    }
}
