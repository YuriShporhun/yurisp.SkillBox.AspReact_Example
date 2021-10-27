﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDataAccess
    {
        public DbSet<Domain.Ticket> Tickets { get; set; }

        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
