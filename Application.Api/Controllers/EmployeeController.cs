// <copyright file="EmployeeController.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Application.Api.Extensions;
    using Application.Business.RequestHandlers.EmployeeManagement.Commands;
    using Application.Business.RequestHandlers.EmployeeManagement.ViewModels;
    using Application.Business.Validators;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    ///   The class for containing controller trigger.
    /// </summary>
    [Route("api/employee")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>Stores the specified employee creation.</summary>
        /// <param name="employee">The employee object.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost("create")]
        public async Task<ActionResult<EmployeeVM>> Store([FromBody] EmployeeVM employee)
        {
            var query = await HttpRequestExtensions.GetJsonBody<CreateEmployeeCommand, EmployeeValidator>(employee);
            if (!query.IsValid)
            {
                return BadRequest(query.Errors);
            }

            var model = query.Value;
            try
            {
                var result = await _mediator.Send(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
