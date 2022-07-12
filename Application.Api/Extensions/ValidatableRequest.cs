// <copyright file="ValidatableRequest.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Api.Extensions
{
    using System.Collections.Generic;
    using FluentValidation.Results;

    /// <summary>
    /// The Validatable Request.
    /// </summary>
    /// <typeparam name="T">
    /// The model type.
    /// </typeparam>
    public class ValidatableRequest<T>
    {
        /// <summary>
        /// Gets or sets the deserialized value of the request.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the deserialized value was found to be valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the collection of validation errors.
        /// </summary>
        public IList<ValidationFailure> Errors { get; set; }
    }
}
