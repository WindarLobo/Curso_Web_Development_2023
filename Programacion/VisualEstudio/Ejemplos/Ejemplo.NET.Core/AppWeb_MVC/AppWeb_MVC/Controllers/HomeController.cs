using AppWeb_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppWeb_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetTime()
        {
            DateTime dateTime = DateTime.Now;
            string responde = "{\"time\": \"" + dateTime + "\"}";
            return Json(responde);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}