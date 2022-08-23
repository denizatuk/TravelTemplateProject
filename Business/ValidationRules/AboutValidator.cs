using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title Yerini Boş Geçemezsiniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Cover İmageyi yüklemeden geçemezsiniz.");

        }
    }
}
