// <copyright file="SqlServerAnimalRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Threading.Tasks;
using GroomerPlus.Core.Entities;
using GroomerPlus.Core.Repositories;
using GroomerPlus.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GroomerPlus.Infrastructure.Repositories
{
    /// <summary>
    /// An implementation of the animal repository that uses SQL server to store animals.
    /// </summary>
    /// <seealso cref="BaseRepository" />
    /// <seealso cref="GroomerPlus.Core.Repositories.IAnimalRepository" />
    public class AnimalRepository : BaseRepository, IAnimalRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AnimalRepository(GroomingContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets all animals.
        /// </summary>
        /// <returns>
        /// A collection of animals.
        /// </returns>
        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return await this.Context.Animals
                .ToListAsync();
        }
    }
}
