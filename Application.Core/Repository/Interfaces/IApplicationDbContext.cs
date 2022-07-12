// <copyright file="IApplicationDbContext.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;
    using Application.DataAccess.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Db Context interface.
    /// </summary>
    public interface IApplicationDbContext
    {
        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The locations.
        /// </value>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The changes count.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sets the state of the entry.
        /// </summary>
        /// <typeparam name="TEntry">The type of the entry.</typeparam>
        /// <param name="entry">The entry.</param>
        /// <param name="entityState">State of the entity.</param>
        void SetEntryState<TEntry>(TEntry entry, EntityState entityState);

        /// <summary>
        /// Sets this instance.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <returns>The data collection.</returns>
        DbSet<TModel> Set<TModel>()
            where TModel : class;
    }
}
