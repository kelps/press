﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebCore1.Controllers {
    public class BlogController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Article(string slug) {
            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
