// <copyright file="IBreedRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GroomerPlus.Core.Entities;

    /// <summary>
    /// Stores and provides retrieval of breeds.
    /// </summary>
    public interface IBreedRepository
    {
        /// <summary>
        /// Gets all breeds.
        /// </summary>
        /// <param name="animalId">The animal identifier.</param>
        /// <returns>
        /// All breeds.
        /// </returns>
        Task<IEnumerable<Breed>> GetBreedsByAnimal(int animalId);
    }
}
