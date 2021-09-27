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


        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        [ActionName("CreatePost")]
        //[Route("admin/create")]
        public IActionResult CreatePost(Article article)
        {
            blog.CreatePost(article);
            return RedirectToAction("GetAllPosts");
        }


        public IActionResult EditPost(int id)
        {
            Article article = blog.GetPostByID(id);
            if (article != null || id > 0)
                return View(article);
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditPost(Article article)
        {
            blog.EditPost(article);
            return RedirectToAction("GetAllPosts");
        }

        //[Route("admin/articles")]
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

        [HttpGet]
        public IActionResult DeletePost(int id)
        {
            blog.DeletePost(id);
            if (id == 0)
                return NotFound();
            return RedirectToAction("GetAllPosts");

        }

        //[Route("admin/create")]
        //public IActionResult CreatePost2()
        //{
        //    return View();
        //}
    }
}
