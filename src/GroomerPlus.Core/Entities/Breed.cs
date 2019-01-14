// <copyright file="Breed.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.Core.Entities
{
    /// <summary>
    /// Represents the breed of an animal.
    /// </summary>
    public class Breed
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the animal identifier.
        /// </summary>
        /// <value>
        /// The animal identifier.
        /// </value>
        public int AnimalId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the groom frequency in days.
        /// </summary>
        /// <value>
        /// The groom frequency in days.
        /// </value>
        public int? GroomFrequency { get; set; }
    }
}
