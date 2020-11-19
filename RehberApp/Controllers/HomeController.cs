using Microsoft.AspNetCore.Mvc;
using RehberApp.Entities;
using RehberApp.Interfaces;
using RehberApp.Repositories;
using System.Collections.Generic;

namespace RehberApp.Controllers
{
    public class HomeController : Controller
    {
        private IRehberRepository _rehberRepository;
        public HomeController(IRehberRepository rehberRepository)
        {
            _rehberRepository = rehberRepository;
        }
        // GET
        public IActionResult Index()
        {
            List<Rehber> allRehber = _rehberRepository.GetAll();
            return View(allRehber);
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}