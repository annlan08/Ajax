using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Homework1()
        {
            return View();
        }
    }
}
