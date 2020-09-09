using FluentValidation;
using FluentValidationDemo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationDemo.API.Validators
{
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            base.RuleFor(p => p.Id).Equal(0).WithMessage("地址ID不能为空！");
            base.RuleFor(p => p.Province).Null().WithMessage("省级地址不能为空！");
            base.RuleFor(p => p.Country).Null().Empty().WithMessage("国籍不能为空！");
            base.RuleFor(p => p.City).Null().Empty().WithMessage("市级地址不能为空！");
        }

    }
}
