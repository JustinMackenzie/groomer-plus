// <copyright file="AnimalController.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

namespace GroomerPlus.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GroomerPlus.Core.Entities;
    using GroomerPlus.Core.Repositories;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Handles the requests for animal-related endpoints.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Produces("application/json")]
    [Route("api/Animal")]
    public class AnimalController : Controller
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IAnimalRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public AnimalController(IAnimalRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Gets all animals.
        /// </summary>
        /// <returns>A collection of all animals.</returns>
        [HttpGet]
        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return await this.repository.GetAllAnimals();
        }
    }
}