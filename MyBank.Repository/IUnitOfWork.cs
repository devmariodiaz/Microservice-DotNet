using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Complete();
    }
}
