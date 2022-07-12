// <copyright file="HttpRequestExtensions.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Api.Extensions
{
    using System.Threading.Tasks;
    using FluentValidation;
    using Newtonsoft.Json;

    /// <summary>
    ///   The Http Request Extensions.
    /// </summary>
    public static class HttpRequestExtensions
    {

        /// <summary>Gets the json body.</summary>
        /// <typeparam name="TModel">Type used for deserialization of the request body.</typeparam>
        /// <typeparam name="TValidator">Validator used to validate the deserialized request body.</typeparam>
        /// <param name="request">The request.</param>
        /// <returns>
        ///   The validation result.
        /// </returns>
        public static async Task<ValidatableRequest<TModel>> GetJsonBody<TModel, TValidator>(object request)
            where TValidator : AbstractValidator<TModel>, new()
        {
            var requestObject = await GetJsonBody<TModel>(request);
            var validator = new TValidator();
            var validationResult = validator.Validate(requestObject);

            if (!validationResult.IsValid)
            {
                return new ValidatableRequest<TModel>
                {
                    Value = requestObject,
                    IsValid = false,
                    Errors = validationResult.Errors,
                };
            }

            return new ValidatableRequest<TModel>
            {
                Value = requestObject,
                IsValid = true,
            };
        }

        /// <summary>Returns the deserialized request body.</summary>
        /// <typeparam name="T">Type used for deserialization of the request body.</typeparam>
        /// <param name="request">The request.</param>
        /// <returns>
        ///   The model.
        /// </returns>
        public static async Task<T> GetJsonBody<T>(object request)
        {
            var result = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(request));
            var isProp = result.GetType().GetProperty("Data");
            if (isProp != null)
            {
                isProp.SetValue(result, request);
            }

            return await Task.FromResult(result);
        }
    }
}
