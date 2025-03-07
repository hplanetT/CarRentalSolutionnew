using Buisness.Managers;
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
    public partial class FrmCustomer : Form
    {
        private readonly CustomerManager _customerManager;

        public FrmCustomer()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            LoadCustomers();
        }

        //Müşteri listesini yükleme metodu
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = null;  //temizleyeleme
            dgvCustomers.DataSource = _customerManager.GetAllCustomers();

            dgvCustomers.Columns["CustomerID"].Visible = false;
        }

        // 📌 Müşteri ekleme işlemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    TCNo = txtTCNo.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,

                };

                _customerManager.AddCustomer(newCustomer);
                LoadCustomers();
                MessageBox.Show("Müşteri başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Müşteri silme işlemi sonradan kullanılmayacak 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                _customerManager.DeleteCustomer(customerId);
                LoadCustomers();
                MessageBox.Show("Müşteri silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.");
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtTCNo.Text = dgvCustomers.Rows[e.RowIndex].Cells["TCNo"].Value.ToString();
                txtPhoneNumber.Text = dgvCustomers.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = dgvCustomers.Rows[e.RowIndex].Cells["Email"].Value.ToString();

            }
        }

        //Müşteri güncelleme işlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                Customer updatedCustomer = new Customer
                {
                    CustomerID = customerId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    TCNo = txtTCNo.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,

                };

                _customerManager.UpdateCustomer(updatedCustomer);
                LoadCustomers();
                MessageBox.Show("Müşteri güncellendi!");
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.");
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    TCNo = txtTCNo.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,

                };

                _customerManager.AddCustomer(newCustomer);
                LoadCustomers();
                MessageBox.Show("Müşteri başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
    
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                    Customer updatedCustomer = new Customer
                    {
                        CustomerID = customerId,  // 📌 Seçili müşterinin ID'si
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        TCNo = txtTCNo.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Email = txtEmail.Text
                    };

                    _customerManager.UpdateCustomer(updatedCustomer);
                    LoadCustomers(); //Listeyi güncelle

                    MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtTCNo.Text = dgvCustomers.Rows[e.RowIndex].Cells["TCNo"].Value.ToString();
                txtPhoneNumber.Text = dgvCustomers.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = dgvCustomers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Önce müşterinin seçilip seçilmediğini kontrol et
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                    DialogResult result = MessageBox.Show("Bu müşteriyi silmek istediğinizden emin misiniz?",
                                                          "Onay",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _customerManager.DeleteCustomer(customerId);
                        LoadCustomers(); // 📌 Listeyi güncelle
                        MessageBox.Show("Müşteri başarıyla silindi!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir müşteri seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}