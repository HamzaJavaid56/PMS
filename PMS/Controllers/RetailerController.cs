﻿using Microsoft.AspNetCore.Mvc;

namespace PMS.Controllers
{
    public class RetailerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
