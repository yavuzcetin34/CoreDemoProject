using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void RemoveComment(Comment comment);
        //void UpdateComment(Comment comment);
        List<Comment> GetAllComment(int id);
        //Comment GetCommentById(int id);
    }
}
