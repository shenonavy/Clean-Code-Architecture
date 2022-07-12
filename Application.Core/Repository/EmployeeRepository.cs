// <copyright file="EmployeeRepository.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository
{
    using Application.Core.Repository.Interfaces;
    using Application.DataAccess.Database;
    using Application.DataAccess.Model;

    /// <summary>
    ///   Employee Repository.
    /// </summary>
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        /// <summary>Initializes a new instance of the <see cref="EmployeeRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public EmployeeRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
