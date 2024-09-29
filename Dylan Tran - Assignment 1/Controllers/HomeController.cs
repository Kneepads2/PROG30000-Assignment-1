using Dylan_Tran___Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dylan_Tran___Assignment_1.Controllers
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

        [HttpGet]
        public ViewResult RequestForm()
        {
            return View();
        }

        public IActionResult AllEquipment()
        {
            var equipment = Repository.GetAllEquipment();
            return View(equipment);
        }

        public IActionResult AvailableEquipment()
        {
            var availableEquipment = Repository.GetAvailableEquipment();
            return View(availableEquipment);
        }

        [HttpPost]
        public ViewResult RequestForm(RequestForm requestForm)
        {
            // TODO: store response from guest
            Repository.AddRequest(requestForm);
            return View("FormSubmitted", requestForm);
        }

        public IActionResult Requests()
        {
            var allRequests = Repository.Requests;
            return View(allRequests);


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
