using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RentalRepository : Repository<Rental>
    {
        private readonly AppDbContext _context;

        public RentalRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Rental> GetActiveRentals()
        {
            return _context.Rentals.Where(r => r.Status == "Aktif").ToList();
        }

        public List<Rental> GetRentalsByCustomerId(int customerId)
        {
            return _context.Rentals.Where(r => r.CustomerID == customerId).ToList();
        }
    }
    }
