using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;
using System.Diagnostics;

namespace MinhaDemoMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //return Json("{'nome':'Eduardo'}");
            /*var fileBytes = System.IO.File.ReadAllBytes(@"C:\AiOLog.txt");
            var fileName = "teste.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);*/

            return Content("Teste Content");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}