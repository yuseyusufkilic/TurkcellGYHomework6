using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Transient_Scoped_Singleton_Diffrences.Models;
using Transient_Scoped_Singleton_Diffrences.Services;

namespace Transient_Scoped_Singleton_Diffrences.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServices _services1;
        private readonly IServices _services2;
        

        public HomeController(ILogger<HomeController> logger, IServices services1,IServices services2)
        {
            _logger = logger;
            _services1 = services1;
            _services2 = services2;
            
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = _services1.ReturnGUID();
            ViewBag.transient2 = _services2.ReturnGUID();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
