// <copyright file="IEmployeeRepository.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository.Interfaces
{
    using Application.DataAccess.Model;

    /// <summary>
    ///   Employee Repository.
    /// </summary>
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
