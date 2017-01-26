using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Press.Controllers {
    public class BlogController : Controller {
        Services.IBlogRepository blog;
        public BlogController(Services.IBlogRepository blog) {
            this.blog = blog;
        }

        public IActionResult Index() {
            return View(blog.List());
        }

        public IActionResult ViewPost(string slug) {
            return View("Post", blog.List().First());
        }
    }
}
