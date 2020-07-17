using MicroServices.Transfer.Data.Context;
using MicroServices.Transfer.Domain.Interfaces;
using MicroServices.Transfer.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _transferDbContext;
        public TransferRepository(TransferDbContext transferDbContext)
        {
            _transferDbContext = transferDbContext;
        }

        public void Add(TransferLog transferLog)
        {
            _transferDbContext.Add(transferLog);
            _transferDbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferDbContext.TransferLogs;
        }
    }
}
