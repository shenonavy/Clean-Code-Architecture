// <copyright file="CreateEmployeeCommand.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Business.RequestHandlers.EmployeeManagement.Commands
{
    using Application.Business.RequestHandlers.EmployeeManagement.ViewModels;
    using MediatR;

    /// <summary>
    ///   Create Employee Command.
    /// </summary>
    public class CreateEmployeeCommand : IRequest<EmployeeVM>
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public EmployeeVM Data { get; set; }
    }
}
