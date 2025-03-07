using Buisness.Managers;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSolutionUI
{
    public partial class FrmRental : Form
    {
        private readonly CustomerManager _customerManager;
        private readonly CarManager _carManager;
        private readonly RentalManager _rentalManager;
        private readonly PaymentManager _paymentManager;

        public FrmRental()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _carManager = new CarManager();
            _rentalManager = new RentalManager();
            _paymentManager = new PaymentManager();

        }

        private void FrmRental_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAvailableCars();
            dtpRentDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now.AddDays(1);
            cmbPaymentMethod.Items.Add("Nakit");
            cmbPaymentMethod.Items.Add("Kredi Kartı");

            // Varsayılan olarak "Nakit" seçili olmasını sağlıyoruz
            cmbPaymentMethod.SelectedIndex = 0; // İlk eleman "Nakit" olarak seçili olur
        }

        private void LoadCustomers()
        {
            var customers = _customerManager.GetAllCustomers();

            if (customers == null || customers.Count == 0)
            {
                MessageBox.Show("Sistemde kayıtlı müşteri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "FirstName"; 
            cmbCustomer.ValueMember = "CustomerID";  
        }

        private void LoadAvailableCars()
        {
            var cars = _carManager.GetAllCars().Where(c => c.Status).ToList();

            if (cars == null || cars.Count == 0)
            {
                MessageBox.Show("Şu anda kiralanabilir araç bulunmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbCar.DataSource = cars;
            cmbCar.DisplayMember = "Brand";  
            cmbCar.ValueMember = "CarID";    
        }

        private void CalculateTotalPrice()
        {
            if (cmbCar.SelectedValue == null || dtpRentDate.Value == null || dtpReturnDate.Value == null)
            {
                return;
            }

            int carId = Convert.ToInt32(cmbCar.SelectedValue);
            var selectedCar = _carManager.GetCarById(carId);

            if (selectedCar == null)
            {
                MessageBox.Show("Araç bilgisi alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime rentDate = dtpRentDate.Value;
            DateTime returnDate = dtpReturnDate.Value;

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Dönüş tarihi alış tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rentalDays = (returnDate - rentDate).Days;
            decimal totalPrice = rentalDays * selectedCar.DailyPrice;

            // Toplam fiyatı Label'a yansıtıyoruz
            lblTotalPrice.Text = totalPrice.ToString("F2"); // F2, 2 ondalıklı gösterim için
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || cmbCar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri ve araç seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            int carId = Convert.ToInt32(cmbCar.SelectedValue);
            DateTime rentDate = dtpRentDate.Value;
            DateTime returnDate = dtpReturnDate.Value;

            decimal totalPrice = 0;

            if (decimal.TryParse(lblTotalPrice.Text, out totalPrice))
            {
                //Kiralama işlemi yapılır
                int rentalId = _rentalManager.RentCar(carId, customerId, rentDate, returnDate);

                //Araç kiralandıktan sonra ödeme işlemini başlatıyoruz
                try
                {
                    // Ödeme işlemi kaydedilir
                    _paymentManager.AddPayment(rentalId, totalPrice, cmbPaymentMethod.SelectedItem.ToString());  // Ödeme kaydedildi
                    MessageBox.Show("Kiralama ve ödeme işlemi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kiralanan aracı listeden çıkarma işlemi
                    var rentedCar = _carManager.GetCarById(carId);
                    if (rentedCar != null)
                    {
                        rentedCar.Status = false;  // Aracın durumu kiralandı olarak güncelleniyor
                        _carManager.UpdateCar(rentedCar);  // Araç güncelleniyor
                    }

                    // Güncel araç listesi 
                    LoadAvailableCars();  // Yüklenen araçlar güncelleniyor
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Toplam fiyat hesaplanamadı. Lütfen hesaplamayı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();

            decimal totalPrice = 0;
            if (decimal.TryParse(lblTotalPrice.Text, out totalPrice))
            {
                
                MessageBox.Show($"Toplam Tutar: {totalPrice:C}", "Ödeme Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Toplam fiyat hesaplanamadı. Lütfen tarih ve araç seçimini kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {
            //kullanılmadı.
        }
    }
}
