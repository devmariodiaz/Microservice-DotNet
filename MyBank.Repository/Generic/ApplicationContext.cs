using Microsoft.EntityFrameworkCore;
using MyBank.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Repository.Generic
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
    }
}
