using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddCategory(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetAllBlogs();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        
    }
}
