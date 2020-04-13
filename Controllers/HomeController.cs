using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DateTime.Controllers{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}