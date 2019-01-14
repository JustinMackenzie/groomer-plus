// <copyright file="IAnimalRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GroomerPlus.Core.Entities;

    /// <summary>
    /// Stores and provides retrieval for animals.
    /// </summary>
    public interface IAnimalRepository
    {
        /// <summary>
        /// Gets all animals.
        /// </summary>
        /// <returns>A collection of animals.</returns>
        Task<IEnumerable<Animal>> GetAllAnimals();
    }
}
