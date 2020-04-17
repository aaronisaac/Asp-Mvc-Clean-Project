using Microsoft.AspNetCore.Mvc;

namespace clean_arch.Features.PrivacyPage.Controllers
{
    public class PrivacyPageController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}