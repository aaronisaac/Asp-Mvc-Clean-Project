using System.Diagnostics;
using clean_arch.Features.ErrorPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace clean_arch.Features.ErrorPage.Controllers
{
    public class ErrorPageController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}