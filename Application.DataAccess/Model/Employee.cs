// <copyright file="Employee.cs" company="SHafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.DataAccess.Model
{
    using Application.DataAccess.Persistance.MutableEntity;

    /// <summary>
    ///   Employee entity.
    /// </summary>
    public class Employee : Entity
    {
        /// <summary>Gets or sets the first name.</summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>Gets or sets the email.</summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>Gets or sets the mobile.</summary>
        /// <value>The mobile.</value>
        public string Mobile { get; set; }

        /// <summary>Gets or sets the address.</summary>
        /// <value>The address.</value>
        public string Address { get; set; }
    }
}