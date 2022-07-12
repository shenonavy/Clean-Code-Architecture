using Application.Business.RequestHandlers.EmployeeManagement.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Business.Validators
{
    public class EmployeeVMValidator : AbstractValidator<EmployeeVM>
    {
        public EmployeeVMValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(x => $"{nameof(x.FirstName)} field is required").MaximumLength(50).
                WithMessage(x => $"{nameof(x.FirstName)} no more than 50");

            RuleFor(x => x.LastName).MaximumLength(50).WithMessage(x => $"{nameof(x.LastName)} no more than 50");

            RuleFor(x => x.Email).NotEmpty().WithMessage(x => $"{nameof(x.Email)} field is required").MaximumLength(100).
                WithMessage(x => $"{nameof(x.Email)} no more than 100");

            RuleFor(x => x.Mobile).MaximumLength(13).WithMessage(x => $"{nameof(x.Mobile)} no more than 13");

            RuleFor(x => x.Address).MaximumLength(100).WithMessage(x => $"{nameof(x.Address)} no more than 100");
        }
    }
}
