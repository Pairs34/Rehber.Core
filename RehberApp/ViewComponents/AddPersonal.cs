using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RehberApp.Entities;

namespace RehberApp.ViewComponents
{
    public class AddPersonal : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new Rehber());
        }
    }
}
