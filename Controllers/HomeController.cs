﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleBlogMVC.Models;

namespace SimpleBlogMVC.Controllers
{
    public class HomeController : Controller
    {
        IBlog blog;
        Article article;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IBlog b)
        {
            _logger = logger;
            blog = b;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("allposts")]
        public IActionResult AllPosts()
        {
            return View(blog.GetArticles());
        }

        public IActionResult EditPost(int id)
        {
            return View(blog.EditPost(id));
        }


        [Route("justtest")]
        public IActionResult Test()
        {
            return View(blog.GetArticles());
        }
        [Route("hesthomepage")]
        public IActionResult TestHomePage()
        {
            return View(blog.GetArticlesOnHomePage());
        }

        [Route("view")]
        public IActionResult TestGetPost(string articleUrl)
        {
            Article _articleItem = blog.GetPost(articleUrl);
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
    }
}
