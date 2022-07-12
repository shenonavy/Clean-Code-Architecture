// <copyright file="DependencyInjection.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Common
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    ///   Add Applicaiton dependencies.
    /// </summary>
    public static class DependencyInjection
    {

        /// <summary>Adds the application common.</summary>
        /// <param name="services">The services.</param>
        /// <returns>
        ///   The service collection.
        /// </returns>
        public static IServiceCollection AddApplicationCommon(this IServiceCollection services)
        {
            return services;
        }
    }
}
