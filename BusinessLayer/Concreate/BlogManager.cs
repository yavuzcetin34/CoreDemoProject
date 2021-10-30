using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this._blogDal = blogDal;
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> BlogLastTreePost()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListWithCategoryByWriterBm(int writerId)
        {
            return _blogDal.GetListWithCategoryByWriter(writerId);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(t => t.WriterId == id);
        }

        public List<Blog> GetBlogByIdList(int id)
        {
            return _blogDal.GetListAll(t => t.BlogId == id);
        }
        public Blog GetById(int id)
        {
            var result = _blogDal.GetById(id);
            return result;
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Remove(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }




    }
}
