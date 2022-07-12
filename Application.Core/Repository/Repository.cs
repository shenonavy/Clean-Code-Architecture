// <copyright file="Repository.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Core.Repository.Interfaces;
    using Application.DataAccess.Database;
    using Application.DataAccess.Persistance.MutableEntity;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    ///   The generic repository.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class Repository<TModel> : IRepository<TModel>
        where TModel : Entity
    {
        /// <summary>The context.</summary>
        protected readonly ApplicationDbContext _context;

        /// <summary>Initializes a new instance of the <see cref="Repository{TModel}" /> class.</summary>
        /// <param name="context">The context.</param>
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The new item id.
        /// </returns>
        public async Task<Guid> AddAsync(TModel entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _context.Set<TModel>().AddAsync(entity, cancellationToken);
            return result.Entity.Id;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Delete(TModel entity)
        {
            _context.Set<TModel>().Remove(entity);
        }

        /// <summary>
        /// Finds the asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns>
        /// The list of results.
        /// </returns>
        public async Task<IEnumerable<TModel>> FindAsync(Func<TModel, bool> predicate)
        {
            return await _context.Set<TModel>().Where(predicate).AsQueryable().ToListAsync();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The signle result.
        /// </returns>
        public async Task<TModel> GetAsync(Guid id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns>All items.</returns>
        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _context.Set<TModel>().ToListAsync();
        }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The changes count.
        /// </returns>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TModel entity)
        {
            var entry = _context.Entry(entity);

            entry.State = EntityState.Modified;

            Task.FromResult(entity);
        }
    }
}
