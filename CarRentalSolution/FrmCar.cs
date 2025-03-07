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
    public partial class FrmCar : Form
    {
        private CarManager _carManager = new CarManager(); 

        public FrmCar()
        {
            InitializeComponent();
        }

        private void FrmCar_Load(object sender, EventArgs e)
        {
            LoadCars(); //Araçları listele

            cmbFuelType.Items.AddRange(new string[] { "Benzin", "Dizel", "Elektrik" });
            cmbTransmission.Items.AddRange(new string[] { "Manuel", "Otomatik" });
            cmbStatus.Items.AddRange(new string[] { "Müsait", "Kiralık" });
            dgvCars.CellClick += dgvCars_CellClick;
        }

        private void LoadCars()
        {
            dgvCars.DataSource = null; //Önce eski veri kaynağını temizle
            dgvCars.DataSource = _carManager.GetAllCars(); //Sonra yeni veriyi ata
            dgvCars.ClearSelection(); //Seçili satırı temizle

            if (dgvCars.Columns.Contains("CarID"))
            {
                dgvCars.Columns["CarID"].Visible = false; //ID sütununu gizle
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text) ||
        string.IsNullOrWhiteSpace(txtModel.Text) ||
        string.IsNullOrWhiteSpace(txtLicensePlate.Text) ||
        string.IsNullOrWhiteSpace(txtYear.Text) ||
        string.IsNullOrWhiteSpace(txtDailyPrice.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Yıl kontrolü
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Lütfen geçerli bir yıl girin! (Örn: 2024)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Fiyat (decimal) format kontrolü
            if (!decimal.TryParse(txtDailyPrice.Text, out decimal dailyPrice))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin! (Örn: 500.75)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Combobox boş seçilirse hata almamak için
            string fuelType = cmbFuelType.SelectedItem?.ToString() ?? "Bilinmiyor";
            string transmission = cmbTransmission.SelectedItem?.ToString() ?? "Bilinmiyor";
            bool status = cmbStatus.SelectedItem?.ToString() == "Müsait";

            _carManager.AddCar(new Car
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Year = year,
                LicensePlate = txtLicensePlate.Text,
                FuelType = fuelType,
                Transmission = transmission,
                DailyPrice = dailyPrice,
                Status = status
            });

            LoadCars(); //Yeni araç eklenince listeyi yenile
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir araç seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            int carId;
            if (!int.TryParse(dgvCars.SelectedRows[0].Cells["CarID"].Value?.ToString(), out carId) || carId == 0)
            {
                MessageBox.Show("Seçili aracın ID'si alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

   
            if (string.IsNullOrWhiteSpace(txtYear.Text) || !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Lütfen geçerli bir yıl girin! (Örn: 2024)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtDailyPrice.Text) || !decimal.TryParse(txtDailyPrice.Text, out decimal dailyPrice))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin! (Örn: 500.75)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string fuelType = cmbFuelType.SelectedItem?.ToString() ?? "Bilinmiyor";
            string transmission = cmbTransmission.SelectedItem?.ToString() ?? "Bilinmiyor";
            bool status = cmbStatus.SelectedItem?.ToString() == "Müsait";

            //Güncellenen aracı oluştur
            Car updatedCar = new Car
            {
                CarID = carId,
                Brand = txtBrand.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Year = year,
                LicensePlate = txtLicensePlate.Text.Trim(),
                FuelType = fuelType,
                Transmission = transmission,
                DailyPrice = dailyPrice,
                Status = status
            };

            try
            {
                _carManager.UpdateCar(updatedCar);
                MessageBox.Show("Araç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataGridView'i yenile
                LoadCars();
                dgvCars.Refresh();
                dgvCars.ClearSelection(); //Güncellemeden sonra seçili satırı kaldır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.Rows.Count == 0) //DataGridView tamamen boş mu?
            {
                MessageBox.Show("Silinecek araç bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCars.SelectedRows.Count == 0) //Kullanıcı bir satır seçmiş mi?
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int carId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["CarID"].Value);

            DialogResult result = MessageBox.Show("Bu aracı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _carManager.DeleteCar(carId);

                LoadCars(); 

                if (dgvCars.Rows.Count == 0) 
                {
                    MessageBox.Show("Tüm araçlar silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

         
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ✅ Geçerli bir satır mı?
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

       
                txtBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "";
                txtModel.Text = row.Cells["Model"].Value?.ToString() ?? "";
                txtYear.Text = row.Cells["Year"].Value?.ToString() ?? "";
                txtLicensePlate.Text = row.Cells["LicensePlate"].Value?.ToString() ?? "";
                txtDailyPrice.Text = row.Cells["DailyPrice"].Value?.ToString() ?? "";

                cmbFuelType.SelectedItem = row.Cells["FuelType"].Value?.ToString() ?? "Bilinmiyor";
                cmbTransmission.SelectedItem = row.Cells["Transmission"].Value?.ToString() ?? "Bilinmiyor";

  
                cmbStatus.SelectedItem = row.Cells["Status"].Value != null && (bool)row.Cells["Status"].Value ? "Müsait" : "Kiralık";
            }
        }

        private void cmbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
