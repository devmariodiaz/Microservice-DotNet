using MyBank.Domain;
using MyBank.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository
{
    public class AccountsRepository : GenericRepository<Account>, IAccountsRepository
    {
        public AccountsRepository(ApplicationContext context) : base(context) { }
        public IEnumerable<Account> GetAllAccounts()
        {
            return _context.Accounts;
        }
    }
}
