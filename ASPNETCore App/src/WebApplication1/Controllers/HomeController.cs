﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Throw()
        {
            throw new Exception("Oh snap!!");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
