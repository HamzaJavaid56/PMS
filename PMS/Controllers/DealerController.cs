﻿using Microsoft.AspNetCore.Mvc;

namespace PMS.Controllers
{
    public class DealerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
