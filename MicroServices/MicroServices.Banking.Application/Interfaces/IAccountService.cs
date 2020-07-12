using MicroServices.Banking.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
