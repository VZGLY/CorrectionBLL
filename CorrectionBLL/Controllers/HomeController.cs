using BLL.Interfaces;
using BLL.Models;
using CorrectionBLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CorrectionBLL.Controllers
{
    public class HomeController : Controller
    {

        private readonly IStringService _stringService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IStringService stringService)
        {
            _logger = logger;
            _stringService = stringService;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Result(TextForm form)
        {
            TextViewModel textViewModel = _stringService.Capitalize(form);
            return View(textViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}