using DataAccess.Repositories;
using DataAccess;
using Entities;

namespace Buisness.Managers
{
    public class PaymentManager
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentManager()
        {
            
            _paymentRepository = new PaymentRepository(new AppDbContext());
        }

        public void AddPayment(int rentalId, decimal amount, string paymentMethod)
        {
            //PaymentRepository üzerinden veri ekleme işlemi yapılacak
            var payment = new Payment
            {
                RentalID = rentalId,
                PaymentDate = DateTime.Now,
                Amount = amount,
                PaymentMethod = paymentMethod
            };

            _paymentRepository.Add(payment);  //Repository'e ekliyoruz.
        }

   
    }
}
