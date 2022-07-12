// <copyright file="DependencyInjection.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Business
{
    using System.Reflection;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    ///   Add Applicaiton dependencies.
    /// </summary>
    public static class DependencyInjection
    {

        /// <summary>Adds the application.</summary>
        /// <param name="services">The services.</param>
        /// <returns>
        ///   The service collection.
        /// </returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
