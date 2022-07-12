using Application.Business.RequestHandlers.EmployeeManagement.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Data).SetValidator(new EmployeeVMValidator());
        }
    }
}
