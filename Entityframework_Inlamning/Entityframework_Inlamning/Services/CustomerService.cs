using Entityframework_Inlamning.Data;
using Entityframework_Inlamning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Services
{
    internal interface ICustomerService
    {
        void CreateCustomer(Customer customer);
        Customer GetId(int id);

        IEnumerable<Customer> GetAll();

        Customer GetEmail(string email);
    }
     internal class CustomerService : ICustomerService
        {
            private readonly SqlContext _context = new SqlContext();

            public void CreateCustomer(Customer customer)
            {
                var _customers = _context.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();
                if (_customers == null)
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                }
            }

            public IEnumerable<Customer> GetAll()
            {
            return _context.Customers;
            }

            public Customer GetId(int id)
            {
                return _context.Customers.Find(id);
            }

        public Customer GetEmail(string email)
        {
            return _context.Customers.Where(c => c.Email == email).FirstOrDefault();
        }
    }
}
