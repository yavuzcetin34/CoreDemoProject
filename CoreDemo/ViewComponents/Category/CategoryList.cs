using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        readonly CategoryManager cm = new(new EfCategoryRepository());
        

        public  IViewComponentResult Invoke()
        {
            var values = cm.GetAllCategories();
            return View(values);    

        }

    }
}
