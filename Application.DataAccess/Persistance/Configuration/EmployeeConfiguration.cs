// <copyright file="EmployeeConfiguration.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.DataAccess.Persistance.Configuration
{
    using Application.DataAccess.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    ///   Employee configuration.
    /// </summary>
    sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        /// <summary>Configures the entity of type <span class="typeparameter">TEntity</span>.</summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();
            builder.HasIndex(e => e.Id)
                .IsUnique();

            builder.Property(e => e.FirstName)
                .IsRequired().HasMaxLength(50);

            builder.Property(e => e.LastName)
                .HasMaxLength(50);

            builder.Property(e => e.Email)
                .IsRequired().HasMaxLength(100);
            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.Property(e => e.Mobile)
                .HasMaxLength(13);

            builder.Property(e => e.Address)
                .HasMaxLength(100);
        }
    }
}