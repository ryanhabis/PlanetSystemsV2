using loginAndRegister.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using starSystemV2.Data;
using System.Diagnostics;

namespace loginAndRegister.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NasaApodAPIService _nasaApodAPIService;
        
        public HomeController(ILogger<HomeController> logger,NasaApodAPIService nasaApodAPIService)
        {
            _logger = logger;
            _nasaApodAPIService = nasaApodAPIService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var apod= await _nasaApodAPIService.GetApodAsync(); 
            return View(apod);
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
