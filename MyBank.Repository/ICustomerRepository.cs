using MyBank.Domain;
using MyBank.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        //void InsertCustomer(Customer entity);
    }
}
