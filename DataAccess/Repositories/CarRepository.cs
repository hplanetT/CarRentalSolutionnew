using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CarRepository : Repository<Car>
    {
        private readonly AppDbContext _context;

        public CarRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        //Tüm araçları getir
        public List<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        //Müsait olan araçları getir
        public List<Car> GetAvailableCars()
        {
            return _context.Cars.Where(c => c.Status == true).ToList();
        }

        //Plakaya göre araç getir
        public Car GetByLicensePlate(string licensePlate)
        {
            return _context.Cars.FirstOrDefault(c => c.LicensePlate == licensePlate);
        }

        //Yeni araç ekle
        public void Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        //Mevcut aracı güncelle
        public void Update(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }

        //kullanılmayacak
        public void Delete(int carId)
        {
            var car = _context.Cars.Find(carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }

        public Car GetById(int carId)
        {
            return _context.Cars.FirstOrDefault(car => car.CarID == carId);  //CarID ile aracı bulma
        }
    }
}
