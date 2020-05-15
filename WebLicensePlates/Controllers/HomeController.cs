using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetSeo.CoreMvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLicensePlates.Models;

namespace WebLicensePlates.Controllers
{
    [SiteName("Website name")]
    [SiteUrl("https://production-url.co/")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [PageTitle("Listing items")]
        [MetaDescription("List of the company's product-items")]
        public IActionResult Index()
        {
            var seoHelper = HttpContext.RequestServices.GetSeoHelper();
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
