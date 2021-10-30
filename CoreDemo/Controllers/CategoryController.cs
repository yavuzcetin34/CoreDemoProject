using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }
    }
}
