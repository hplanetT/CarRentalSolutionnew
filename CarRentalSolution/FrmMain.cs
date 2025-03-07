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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomer customerForm = new FrmCustomer();
            customerForm.ShowDialog();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            FrmCar carForm = new FrmCar();
            carForm.ShowDialog();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            FrmRental rentalForm = new FrmRental();
            rentalForm.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            
            //Ayrı payment forma ihtiyaç duyulmadı.
            //FrmPayment paymentForm = new FrmPayment();
            //paymentForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           FrmReport reportForm = new FrmReport();
           reportForm.ShowDialog();
        }
    }
}
