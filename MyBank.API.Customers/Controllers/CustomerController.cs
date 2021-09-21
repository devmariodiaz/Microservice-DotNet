using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBank.Domain;
using MyBank.Repository;

namespace MyBank.API.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //[HttpGet]
        //[Route("api/customer")]
        //public IActionResult GetAll()
        //{
        //    var customers = _unitOfWork.Customers.GetAllCustomers();
        //    return Ok(customers);
        //}

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var customer = _unitOfWork.Customers.GetCustomerById(id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult CreateNewCustomer(Customer entity)
        {
            _unitOfWork.Customers.Add(entity);
             int num = _unitOfWork.Complete();
            return Ok($"Inserted {num} row(s)");
        }
    }
}