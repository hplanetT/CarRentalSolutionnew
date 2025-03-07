using DataAccess.Repositories;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Managers
{
    public class CarManager
    {
        private readonly CarRepository _carRepository;




        public Car GetCarById(int carId)
        {
            return _carRepository.GetById(carId);  //CarRepository üzerinden aracı alıyoruz
        }

        public CarManager()
        {
            _carRepository = new CarRepository(new AppDbContext());
        }

        // Tüm araçları getir
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAll();
        }

        // Müsait olan araçları getir
        public List<Car> GetAvailableCars()
        {
            return _carRepository.GetAvailableCars();
        }

        //Yeni araç ekle
        public void AddCar(Car car)
        {

            if (car == null)
                throw new ArgumentNullException(nameof(car), "Araç bilgisi boş olamaz.");

            if (_carRepository.GetByLicensePlate(car.LicensePlate) != null)
            {
                throw new Exception("Bu plaka zaten kayıtlı.");
            }

            _carRepository.Add(car);
        }

        //Mevcut aracı güncelle
        public void UpdateCar(Car car)
        {
            var existingCar = _carRepository.GetById(car.CarID);

            if (existingCar == null)
            {
                throw new Exception("Güncellenmek istenen araç bulunamadı.");
            }

            existingCar.Brand = car.Brand;
            existingCar.Model = car.Model;
            existingCar.Year = car.Year;
            existingCar.LicensePlate = car.LicensePlate;
            existingCar.FuelType = car.FuelType;
            existingCar.Transmission = car.Transmission;
            existingCar.DailyPrice = car.DailyPrice;
            existingCar.Status = car.Status;

            _carRepository.Update(existingCar);
        }

        // Bu kısım kullanılmayacaktır. Veritabanında bağlı olduğu için hatalara sebep olmaması için.
        public void DeleteCar(int carId)
        {
            var car = _carRepository.GetById(carId);
            if (car == null)
            {
                throw new Exception("Silinmek istenen araç bulunamadı.");
            }

            _carRepository.Delete(carId);
        }

        //Plakaya göre araç getir
        public Car GetCarByLicensePlate(string licensePlate)
        {
            return _carRepository.GetByLicensePlate(licensePlate);
        }
    }
}
