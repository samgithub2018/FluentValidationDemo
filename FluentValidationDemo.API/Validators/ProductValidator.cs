using FluentValidation;
using FluentValidation.Results;
using FluentValidationDemo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FluentValidationDemo.API.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            base.RuleFor(p => p.Id).Equal(0).WithMessage("产品ID不能为空！");
            base.RuleFor(p => p.Name).Null().Empty().WithMessage("产品名称不能为空！");
            base.RuleFor(p => p.ProductType).Null().Empty().WithMessage("产品类别不能为空！");
            base.RuleFor(p => p.PlaceOfOrigin).SetValidator(new AdressValidator());
        }

        public override ValidationResult Validate(ValidationContext<Product> context)
        {
            return base.Validate(context);
        }

        public override Task<ValidationResult> ValidateAsync(ValidationContext<Product> context, CancellationToken cancellation = default)
        {
            return base.ValidateAsync(context, cancellation);
        }
    }
}
