using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        readonly ContactManager cm = new(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.Date = new System.DateTime();
            p.Status = true;
            cm.ContactAdd(p);

            return RedirectToAction("Index", "Blog");
        }
    }

}
