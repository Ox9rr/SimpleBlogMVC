using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using SimpleBlogMVC.Models;

namespace SimpleBlogMVC.Controllers
{
    public class AdminController : Controller
    {
        IBlog blog;
        Article article;
        private readonly ILogger<HomeController> _logger;

        public AdminController(ILogger<HomeController> logger, IBlog b)
        {
            _logger = logger;
            blog = b;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("admin/create")]
        public IActionResult CreatePost()
        {
            return View();
        }

        [Route("admin/articles")]
        public IActionResult GetAllPosts()
        {
            return View(blog.GetArticles());
        }

        //[Route("admin/create")]
        //public IActionResult CreatePost2()
        //{
        //    return View();
        //}
    }
}
