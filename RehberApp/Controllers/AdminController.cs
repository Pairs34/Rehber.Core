using Microsoft.AspNetCore.Mvc;

namespace RehberApp.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}