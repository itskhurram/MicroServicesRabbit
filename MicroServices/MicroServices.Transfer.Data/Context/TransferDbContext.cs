using MicroServices.Transfer.Domain.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TransferLog> TransferLogs { get; set; }

    }
}
