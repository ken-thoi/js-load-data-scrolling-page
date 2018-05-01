using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FetchData(int pageIndex = 0)
        {
            var posts = new List<Post>();
            int first = pageIndex + 1;
            int last = pageIndex + 10;
            for (int i = first; i <= last; i++)
            {
                posts.Add(new Post()
                {
                    Id = i,
                    Date = DateTime.UtcNow,
                    Title = "Title " + i,
                    Content = "Content from Database with Id" + i
                });
            }

            return Json(posts, JsonRequestBehavior.AllowGet);
        }

        public class Post
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}