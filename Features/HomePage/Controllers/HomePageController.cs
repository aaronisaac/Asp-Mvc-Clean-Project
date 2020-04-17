using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace clean_arch.Features.HomePage.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}