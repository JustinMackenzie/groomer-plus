// <copyright file="SqlServerBreedRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroomerPlus.Core.Entities;
using GroomerPlus.Core.Repositories;
using GroomerPlus.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GroomerPlus.Infrastructure.Repositories
{
    /// <summary>
    /// An implementation of the breed repository that uses SQL server to store breeds.
    /// </summary>
    /// <seealso cref="GroomerPlus.Core.Repositories.IBreedRepository" />
    public class BreedRepository : BaseRepository, IBreedRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreedRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BreedRepository(GroomingContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets all breeds.
        /// </summary>
        /// <param name="animalId">The animal identifier.</param>
        /// <returns>
        /// All breeds.
        /// </returns>
        public async Task<IEnumerable<Breed>> GetBreedsByAnimal(int animalId)
        {
            return await this.Context.Breeds
                .Where(b => b.AnimalId == animalId)
                .ToListAsync();
        }
    }
}
