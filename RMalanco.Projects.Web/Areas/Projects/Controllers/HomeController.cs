using Microsoft.AspNetCore.Mvc;
using RMalanco.Projects.Interfaces.Base;
using RMalanco.Projects.Models.Errors;
using System.Diagnostics;

namespace RMalanco.Projects.Web.Areas.Projects.Controllers
{
    [Area("Projects")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var roles = _unitOfWork.Roles.GetAll();
            return View(roles);
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
