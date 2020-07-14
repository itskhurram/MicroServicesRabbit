using MicroServices.Banking.Application.Models;
using MicroServices.Banking.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
