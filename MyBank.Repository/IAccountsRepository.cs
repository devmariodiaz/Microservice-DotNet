using MyBank.Domain;
using MyBank.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository
{
    public interface IAccountsRepository : IGenericRepository<Account>
    {
        IEnumerable<Account> GetAllAccounts();
    }
}
