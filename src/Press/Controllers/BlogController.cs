using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Press.Controllers {
    public class BlogController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Article(string slug) {
            return View();
        }
    }
}
