// <copyright file="IEmployeeService.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Application.DataAccess.Model;

    /// <summary>
    ///   Employee interface.
    /// </summary>
    public interface IEmployeeService
    {

        /// <summary>Gets all asynchronous.</summary>
        /// <returns>
        ///   List of All employee details.
        /// </returns>
        Task<IEnumerable<Employee>> GetAllAsync();

        /// <summary>Creates the asynchronous.</summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        ///   The employee Id.
        /// </returns>
        Task<Guid> CreateAsync(Employee employee);

        /// <summary>Gets the by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   Return an employee.
        /// </returns>
        Task<Employee> GetById(Guid id);

        /// <summary>Updates the asynchronous.</summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        ///   Update an employee.
        /// </returns>
        Task UpdateAsync(Employee employee);

        /// <summary>Deletes the specified employee.</summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        ///   Demelete an employee.
        /// </returns>
        Task Delete(Employee employee);
    }
}
