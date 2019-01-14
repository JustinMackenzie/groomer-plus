// <copyright file="GroomingContext.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using GroomerPlus.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroomerPlus.Infrastructure.Data
{
    /// <summary>
    /// The database context for the groomer plus application.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class GroomingContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroomingContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public GroomingContext(DbContextOptions<GroomingContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the clients.
        /// </summary>
        /// <value>
        /// The clients.
        /// </value>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Gets or sets the pets.
        /// </summary>
        /// <value>
        /// The pets.
        /// </value>
        public DbSet<Pet> Pets { get; set; }

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        /// <value>
        /// The appointments.
        /// </value>
        public DbSet<Appointment> Appointments { get; set; }

        /// <summary>
        /// Gets or sets the breeds.
        /// </summary>
        /// <value>
        /// The breeds.
        /// </value>
        public DbSet<Breed> Breeds { get; set; }

        /// <summary>
        /// Gets or sets the animals.
        /// </summary>
        /// <value>
        /// The animals.
        /// </value>
        public DbSet<Animal> Animals { get; set; }
    }
}