// <copyright file="DataContext.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.DataAccess.Database
{
    using Application.DataAccess.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    ///   Application db context.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {

        /// <summary>Initializes a new instance of the <see cref="ApplicationDbContext" /> class.</summary>
        /// <param name="options">The options.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1">DbSet</see> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.
        /// </param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)">UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)</see>)
        /// then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        /// <summary>Gets or sets the employees.</summary>
        /// <value>The employees.</value>
        public DbSet<Employee> Employees { get; set; }
    }
}
