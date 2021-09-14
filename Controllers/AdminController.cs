using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public IActionResult GetArticleDetails(int id)
        {
            Article _articleItem = blog.GetPostByID(id);
            List<Article> article = new List<Article>();
            article.Add(_articleItem);
            if (article != null)
                try
                {
                    return View(article);
                }
                catch
                {
                    Exception ex;
                }
            return NotFound();
        }

        //[Route("admin/create")]
        //public IActionResult CreatePost2()
        //{
        //    return View();
        //}
    }
}
