using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager ab = new(new EfAboutRepository());
        public IActionResult AboutIndex()
        {
            var result = ab.GetList();
            return View(result);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
