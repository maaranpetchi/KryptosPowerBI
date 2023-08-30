using AuthSystem.Areas.Identity.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger,UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"]=_userManager.GetUserId(this.User);
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


        public IActionResult BankingAnalyticsReport()
        {
            // Set the URL you want to display in the iframe
            ViewBag.Url = "https://app.powerbi.com/view?r=eyJrIjoiYmI3M2QyZTktYWYxMC00MGUwLWJmZDYtNDI4ZmFiNTM5NmFjIiwidCI6IjE3ZDAxMGY0LTE0ZTItNGRiYy04MDU2LTc3MWE1MjllYWRmZCJ9\"";
            return View("Iframe");
        }
   

        public IActionResult DigitalInsuranceReport()
        {
            // Set the URL you want to display in the iframe
            ViewBag.Url = "https://www.example.com/report";
            return View("Iframe");
        }

        public IActionResult Dashboard()
        {
            // Set the URL you want to display in the iframe
            ViewBag.Url = "https://www.example.com/dashboard";
            return View("Iframe");
        }

    }
}