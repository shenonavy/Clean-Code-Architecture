// <copyright file="EmployeeService.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Application.Core.Repository.Interfaces;
    using Application.Core.Services.Interfaces;
    using Application.DataAccess.Model;

    /// <summary>
    ///   The Employee Service.
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeService" /> class.
        /// </summary>
        /// <param name="employeeRepository">The employee repository.</param>
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// The Employee Id.
        /// </returns>
        public async Task<Guid> CreateAsync(Employee employee)
        {
            _employeeRepository.Add(employee);

            await _employeeRepository.SaveChangesAsync();

            return employee.Id;
        }

        /// <summary>Deletes the specified employee.</summary>
        /// <param name="employee">The employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task Delete(Employee employee)
        {
            _employeeRepository.Delete(employee);

            await _employeeRepository.SaveChangesAsync();
        }

        /// <summary>Gets all asynchronous.</summary>
        /// <returns>
        ///   Get all employees.
        /// </returns>
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        /// <summary>Gets the by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   Return an employee.
        /// </returns>
        public async Task<Employee> GetById(Guid id)
        {
            return await _employeeRepository.GetAsync(id);
        }

        /// <summary>Updates the asynchronous.</summary>
        /// <param name="employee">The employee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task UpdateAsync(Employee employee)
        {
            _employeeRepository.Update(employee);

            await Task.CompletedTask;
        }
    }
}
