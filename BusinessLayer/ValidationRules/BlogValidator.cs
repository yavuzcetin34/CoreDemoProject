using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(t => t.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş olamaz !");
            RuleFor(t => t.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden az veri girişi yapınız !");
            RuleFor(t => t.BlogTitle).MinimumLength(3).WithMessage("Lütfen 5 karakterden fazla veri girişi yapınız !");


            RuleFor(t => t.BlogContent).NotEmpty().WithMessage("Blog içeriği boş olamaz !");
            RuleFor(t => t.BlogImage).NotEmpty().WithMessage("Blog görseli boş olamaz !");
        }
    }
}
