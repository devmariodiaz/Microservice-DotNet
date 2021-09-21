using MyBank.Domain;
using MyBank.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext context) : base(context) { }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        //public void InsertCustomer(Customer entity)
        //{
        //    _context.Add<Customer>(entity);
        //}
    }
}
