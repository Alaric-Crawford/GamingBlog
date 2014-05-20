using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameTable.Controllers
{
    public class HomeController : Controller
    {
        Models.GameTableEntities db = new Models.GameTableEntities();
        // GET: /Home/

        public ActionResult Index()
        {
            var list = db.Posts.OrderByDescending(x => x.postedOn).Take(6);
            return View(list);
        }

        public ActionResult Approval(int id)
        {
            var post = db.Posts.Where(x => x.PostID == id).First();
            post.Approval += 1;
            db.SaveChanges();

            return Content(post.Approval + " Approval Score");
        }

        public ActionResult AddComment(int id, FormCollection values)
        {
            var comment = new Models.Comment();
            comment.PostID = id;
            comment.author = values["author"];
            comment.body = values["body"];
            comment.postedOn = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Approval = 0;

            db.Comments.Add(comment);
            db.SaveChanges();

            var post = db.Posts.Find(id);

            return PartialView("Comment", post);
        }
    }
}
