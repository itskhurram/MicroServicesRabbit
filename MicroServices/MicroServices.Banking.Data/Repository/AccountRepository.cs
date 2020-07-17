using MicroServices.Banking.Data.Context;
using MicroServices.Banking.Domain.Interfaces;
using MicroServices.Banking.Domain.Models;

using System.Collections.Generic;

namespace MicroServices.Banking.Data.Repository {
    public class AccountRepository : IAccountRepository {
        private BankingDbContext _bankingDbContext;
        public AccountRepository(BankingDbContext bankingDbContext) {
            _bankingDbContext = bankingDbContext;
        }
        public IEnumerable<Account> GetAccounts() {
            return _bankingDbContext.Accounts;
        }
    }
}
