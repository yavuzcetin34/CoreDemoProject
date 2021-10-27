using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş olamaz ");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adrsi boş olamaz ");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş olamaz ");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter olmalı");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı");

			//RuleFor(x => x.WriterPassord)
			//		.MinimumLength(4).WithMessage("Şifre en az 4 karakter olmalı")
			//		.Matches("[A-Z]").WithMessage("Şifrenizde büyük harf olmalı")
			//		.Matches("[a-z]").WithMessage("Şifrenizde küçük harf olmalı")
			//		.Matches("[0-9]").WithMessage("Şifrenizde rakam olmalı")
			//		.Matches("[^a-zA-Z0-9]").WithMessage("Şifrenizde özel karakter olmalı");
		}
	}
}
