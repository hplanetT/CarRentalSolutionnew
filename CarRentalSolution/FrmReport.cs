using DataAccess;
using Entities; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSolutionUI
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            LoadRentalData();
            LoadPaymentData();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadRentalData()
        {
            using (var context = new AppDbContext()) 
            {
                // Kiralanan araçlar ve kiralama bilgilerini çekme
                var rentalData = from rental in context.Rentals
                                 join car in context.Cars on rental.CarID equals car.CarID  
                                 join customer in context.Customers on rental.CustomerID equals customer.CustomerID  
                                 select new
                                 {
                                     car.Brand,  
                                     car.Model,  
                                     customer.FirstName,  
                                     rental.RentDate, 
                                     rental.ReturnDate,  
                                     rental.Status  
                                 };

                // Kiralama verilerini DataGridView'e atama
                dgvRental.DataSource = rentalData.ToList(); // Kiralama verilerini listeye çevirip grid'e yükle
            }
        }

        private void LoadPaymentData()
        {
            using (var context = new AppDbContext()) 
            {
                // Ödeme bilgilerini çekme
                var paymentData = from payment in context.Payments
                                  join rental in context.Rentals on payment.RentalID equals rental.RentalID  
                                  join customer in context.Customers on rental.CustomerID equals customer.CustomerID  
                                  join car in context.Cars on rental.CarID equals car.CarID  
                                  select new
                                  {
                                      car.Brand, 
                                      car.Model, 
                                      customer.FirstName, 
                                      payment.Amount,
                                      payment.PaymentDate, 
                                      payment.PaymentMethod 
                                  };

                // Ödeme verilerini DataGridView'e atama
                dgvPayment.DataSource = paymentData.ToList(); // Ödeme verilerini listeye çevirip grid'e yükle
            }
        }

        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
