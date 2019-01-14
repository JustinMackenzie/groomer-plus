// <copyright file="SqlServerAppointmentRepository.cs" company="GroomerPlus">
// Copyright (c) GroomerPlus. All rights reserved.
// </copyright>

using System.Threading.Tasks;
using GroomerPlus.Core.Entities;
using GroomerPlus.Core.Repositories;
using GroomerPlus.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GroomerPlus.Infrastructure.Repositories
{
    /// <summary>
    /// An implementation of the appointment repository that uses SQL server to store appointments.
    /// </summary>
    /// <seealso cref="GroomerPlus.Core.Repositories.IAppointmentRepository" />
    public class AppointmentRepository : BaseRepository, IAppointmentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AppointmentRepository(GroomingContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Creates the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <returns>
        /// A handle for the task of adding the appointment to the repository.
        /// </returns>
        public async Task AddAppointment(Appointment appointment)
        {
            await this.Context.Appointments.AddAsync(appointment);
            await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the appointment.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <returns>
        /// The appointment with the specified identifier.
        /// </returns>
        public async Task<Appointment> GetAppointment(int appointmentId)
        {
            return await this.Context.Appointments
                .SingleOrDefaultAsync(a => a.Id == appointmentId);
        }
    }
}
