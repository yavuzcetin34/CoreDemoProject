using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.Date = System.DateTime.Now;
            p.Status = true;
            p.BlogId = 2;

            cm.AddComment(p);   

            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetAllComment(id);
            return PartialView(values);
        }
    }
}
