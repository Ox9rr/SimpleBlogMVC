using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogMVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public bool IsActive { get; set; }
        public bool OnHomePage { get; set; }
        //public int TagForArticlesId { get; set; }
    }
}
