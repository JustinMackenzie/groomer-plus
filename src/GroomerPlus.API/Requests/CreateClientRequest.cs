﻿// <copyright file="CreateClientRequest.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.API.Requests
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// A request to create a new client.
    /// </summary>
    public class CreateClientRequest
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        [Phone]
        public string Phone { get; set; }
    }
}