// <copyright file="IMapFrom.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Business.Common.Mappings
{
    using AutoMapper;

    /// <summary>
    /// The Mapping interface.
    /// </summary>
    /// <typeparam name="T">
    /// The source type.
    /// </typeparam>
    public interface IMapFrom<T>
    {
        /// <summary>
        /// Mappings the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()).ReverseMap();
    }
}
