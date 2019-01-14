// <copyright file="BreedController.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.API.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GroomerPlus.Core.Entities;
    using GroomerPlus.Core.Repositories;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Handles requests related to breeds.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Produces("application/json")]
    public class BreedController : Controller
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IBreedRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BreedController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public BreedController(IBreedRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all breeds.
        /// </summary>
        /// <param name="animalId">The animal identifier.</param>
        /// <returns>
        /// A list of breeds.
        /// </returns>
        [HttpGet]
        [Route("api/animal/{animalId}/breed")]
        public async Task<IEnumerable<Breed>> GetAllBreeds(int animalId)
        {
            return await this.repository.GetBreedsByAnimal(animalId);
        }
    }
}