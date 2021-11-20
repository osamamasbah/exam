using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examosama.Controllers
{
    public class Contry : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
