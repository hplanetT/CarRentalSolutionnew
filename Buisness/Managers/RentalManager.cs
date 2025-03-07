using DataAccess.Repositories;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Buisness.Managers
{
    public class RentalManager
    {
        private readonly RentalRepository _rentalRepository;
        private readonly CarRepository _carRepository;

        public RentalManager()
        {
            _rentalRepository = new RentalRepository(new AppDbContext());
            _carRepository = new CarRepository(new AppDbContext());
        }

        public int RentCar(int carId, int customerId, DateTime rentDate, DateTime returnDate)
        {
            using (var context = new AppDbContext())
            {
                var car = context.Cars.Find(carId);
                if (car == null || !car.Status)
                {
                    throw new Exception("Seçilen araç kiralanamaz!");
                }

                int rentalDays = (returnDate - rentDate).Days;
                decimal totalPrice = rentalDays * car.DailyPrice;

                var rental = new Rental
                {
                    CarID = carId,
                    CustomerID = customerId,
                    RentDate = rentDate,
                    ReturnDate = returnDate,
                    TotalPrice = totalPrice,
                    Status = "Kirada"
                };

                context.Rentals.Add(rental);
                car.Status = false; // Araç artık kirada
                context.SaveChanges();

                return rental.RentalID;
            }
        }

        public void ReturnCar(int rentalId)
        {
            using (var context = new AppDbContext())
            {
                var rental = context.Rentals.Find(rentalId);
                if (rental == null || rental.ReturnDate != null)
                {
                    throw new Exception("Araç zaten iade edilmiş!");
                }

                rental.ReturnDate = DateTime.Now;
                rental.Status = "Müsait";

                var car = context.Cars.Find(rental.CarID);
                if (car != null)
                {
                    car.Status = true;
                }

                context.SaveChanges();
            }

        }
       
    }
}
