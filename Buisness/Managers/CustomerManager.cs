using DataAccess.Repositories;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using Buisness.Validations;

namespace Buisness.Managers
{
    public class CustomerManager
    {
        private readonly CustomerRepository _customerRepository;
        private readonly CustomerValidator _validator;
        

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository(new AppDbContext());
            _validator = new CustomerValidator();  
        }

        // 📌 Tüm müşterileri getir
        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        // 📌 Yeni müşteri ekle
        public void AddCustomer(Customer customer)
        {
            var validationResult = _validator.Validate(customer);

            if (!validationResult.IsValid)
            {
                string errors = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new Exception("Doğrulama Hatası:\n" + errors);
            }

            _customerRepository.Add(customer);
        }

        //Mevcut müşteriyi güncelle
        public void UpdateCustomer(Customer customer)
        {
            var validationResult = _validator.Validate(customer);
            if (!validationResult.IsValid)
            {
                throw new Exception("Doğrulama Hatası:\n" + string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage)));
            }

            var existingCustomer = _customerRepository.GetById(customer.CustomerID);
            if (existingCustomer == null)
            {
                throw new Exception("Güncellenecek müşteri bulunamadı.");
            }

            _customerRepository.Detach(existingCustomer);
            _customerRepository.Update(customer);        
        }

        // Bu kısım veritabanı bağlantıları sıkıntıya düşmemesi için formda gösterilmemiştir.
        public void DeleteCustomer(int customerID)
        {
            var existingCustomer = _customerRepository.GetById(customerID);
            if (existingCustomer == null)
            {
                throw new Exception("Silinmek istenen müşteri bulunamadı.");
            }

            _customerRepository.Delete(customerID);
        }
    }
}
