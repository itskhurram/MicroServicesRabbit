using MicroServices.Banking.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
