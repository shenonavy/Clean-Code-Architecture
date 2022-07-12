// <copyright file="IUnitOfWork.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Core.Repository.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IUnitOfWork.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The changes count.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
