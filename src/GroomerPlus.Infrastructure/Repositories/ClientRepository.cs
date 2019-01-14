// <copyright file="SqlServerClientRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GroomerPlus.Core.Entities;
using GroomerPlus.Core.Repositories;
using GroomerPlus.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GroomerPlus.Infrastructure.Repositories
{
    /// <summary>
    /// An implementation of the clients repository that uses SQL server to store clients.
    /// </summary>
    /// <seealso cref="GroomerPlus.Core.Repositories.IClientRepository" />
    public class ClientRepository : BaseRepository, IClientRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ClientRepository(GroomingContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Adds the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>
        /// A handle for the task of adding the client to the repository
        /// </returns>
        /// <exception cref="ArgumentNullException">client</exception>
        public async Task AddClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.Context.Clients.Add(client);
            await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the client by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The client with the specified identifier.
        /// </returns>
        public async Task<Client> GetClientById(int id)
        {
            return await this.Context.Clients.SingleOrDefaultAsync(c => c.Id == id);
        }

        /// <summary>
        /// Gets all clients.
        /// </summary>
        /// <returns>
        /// A collection of all clients.
        /// </returns>
        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await this.Context.Clients.ToListAsync();
        }
    }
}
