// <copyright file="BaseSqlServerRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using GroomerPlus.Infrastructure.Data;

namespace GroomerPlus.Infrastructure.Repositories
{
    /// <summary>
    /// The base sql server repository
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly GroomingContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        protected BaseRepository(GroomingContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected GroomingContext Context => this.context;
    }
}
