// <copyright file="CreateEmployeeCommandHandler.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Business.RequestHandlers.EmployeeManagement.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Business.RequestHandlers.EmployeeManagement.ViewModels;
    using Application.Core.Services.Interfaces;
    using Application.DataAccess.Model;
    using AutoMapper;
    using MediatR;

    /// <summary>
    ///   Create Employee command handler.
    /// </summary>
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeVM>
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="CreateEmployeeCommandHandler" /> class.</summary>
        /// <param name="employeeService">The employee service.</param>
        /// <param name="mapper">The mapper.</param>
        public CreateEmployeeCommandHandler(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        /// <summary>Handles a request.</summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Response from the request.</returns>
        public async Task<EmployeeVM> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request.Data);

            await _employeeService.CreateAsync(employee);

            return _mapper.Map<EmployeeVM>(employee);
        }
    }
}
