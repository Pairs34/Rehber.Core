using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RehberApp.Entities;
using RehberApp.Interfaces;

namespace RehberApp.Controllers
{
    public class AdminController : Controller
    {
        private IRehberRepository _rehberRepository;
        public AdminController(IRehberRepository rehberRepository)
        {
            _rehberRepository = rehberRepository;
        }
        // GET
        public IActionResult Index()
        {
            List<Rehber> rehbers = _rehberRepository.GetAll();
            return View(rehbers);
        }

        public IActionResult AddContact(Rehber rehber)
        {
            _rehberRepository.Add(rehber);
            return RedirectToAction("Index");
        }
    }
}