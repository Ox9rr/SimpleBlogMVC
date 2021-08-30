using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogMVC.Models
{
    public class TagFoArticles
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Article> Articles { get; set; }

    }
}
