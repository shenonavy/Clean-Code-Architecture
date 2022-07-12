// <copyright file="DependencyInjection.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core
{
    using Application.Core.Repository;
    using Application.Core.Repository.Interfaces;
    using Application.Core.Services;
    using Application.Core.Services.Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    ///   Add Applicaiton dependencies.
    /// </summary>
    public static class DependencyInjection
    {

        /// <summary>Adds the application core.</summary>
        /// <param name="services">The services.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static IServiceCollection AddApplicationCore(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
