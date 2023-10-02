using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devcard_MVC.ViewComponents
{
    public class LatestArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
new Article(1,"هوش مصنوعی","محصولات ایجاد شده با ","blog-post-thumb-1.jpg"),
               new Article (2,"هوش مصنوعی","محصولات ایجاد شده با ","blog-post-thumb-3.jpg"),
               new Article (3,"هوش مصنوعی","محصولات ایجاد شده با ","blog-post-thumb-5.jpg"),
               new Article (4,"هوش مصنوعی","محصولات ایجاد شده با ","blog-post-thumb-7.jpg"),
            };
            return View("_LatestArticle",articles);
            //return View("",articles);
        }
    }
}
