using BusinessLayer.Concreate;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        readonly CommentManager cm = new(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
          
            var values = cm.GetAllComment(id);
            return View(values);
        }
    }
}
