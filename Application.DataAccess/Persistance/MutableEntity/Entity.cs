// <copyright file="Entity.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.DataAccess.Persistance.MutableEntity
{
    using System;

    /// <summary>
    ///   Mutable entity.
    /// </summary>
    public class Entity
    {

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
