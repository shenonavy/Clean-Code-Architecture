// <copyright file="UnitOfWork.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository
{
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Core.Repository.Interfaces;

    /// <summary>
    ///   The UnitOfWork.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _context;

        /// <summary>Initializes a new instance of the <see cref="UnitOfWork" /> class.</summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(IApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>Saves the changes asynchronous.</summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The changes count.</returns>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
