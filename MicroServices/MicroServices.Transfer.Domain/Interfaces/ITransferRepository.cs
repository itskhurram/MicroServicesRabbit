using MicroServices.Transfer.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
