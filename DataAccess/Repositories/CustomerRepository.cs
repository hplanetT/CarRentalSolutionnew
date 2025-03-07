using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Customer GetByTCNo(string tcNo)
        {
            return _context.Customers.FirstOrDefault(c => c.TCNo == tcNo);
        }

        public Customer GetByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(c => c.Email == email);
        }
        public void Delete(int customerID)
        {
            Customer customer = _context.Customers.Find(customerID);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();  //kullanılmadı
            }
        }
        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Detach(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Detached;
        }
    }
}
