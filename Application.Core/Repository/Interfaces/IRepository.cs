// <copyright file="IRepository.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.DataAccess.Persistance.MutableEntity;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public interface IRepository<TModel>
        where TModel : Entity
    {
        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns>
        /// All items.
        /// </returns>
        Task<IEnumerable<TModel>> GetAllAsync();

        /// <summary>
        /// Gets the item by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The item.
        /// </returns>
        Task<TModel> GetAsync(Guid id);

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The item id.</returns>
        Task<Guid> AddAsync(TModel entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TModel entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TModel entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(TModel entity);

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The changes count.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
