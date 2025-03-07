namespace CarRentalSolutionUI
{
    partial class FrmCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblLicensePlate = new Label();
            lblDailyPrice = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtLicensePlate = new TextBox();
            txtDailyPrice = new TextBox();
            cmbFuelType = new ComboBox();
            cmbTransmission = new ComboBox();
            lblBrand = new Label();
            cmbStatus = new ComboBox();
            lblFuelType = new Label();
            lblTransmission = new Label();
            lblStatus = new Label();
            dgvCars = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblModel.Location = new Point(61, 139);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(56, 18);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblYear.Location = new Point(61, 184);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(27, 18);
            lblYear.TabIndex = 0;
            lblYear.Text = "Yıl";
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblLicensePlate.Location = new Point(61, 225);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(53, 18);
            lblLicensePlate.TabIndex = 0;
            lblLicensePlate.Text = "Plaka";
            // 
            // lblDailyPrice
            // 
            lblDailyPrice.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblDailyPrice.Location = new Point(44, 274);
            lblDailyPrice.Name = "lblDailyPrice";
            lblDailyPrice.Size = new Size(115, 52);
            lblDailyPrice.TabIndex = 0;
            lblDailyPrice.Text = "Günlük Kiralama Ücreti ";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(165, 95);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(125, 27);
            txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(165, 139);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(165, 184);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 1;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(165, 225);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(125, 27);
            txtLicensePlate.TabIndex = 1;
            // 
            // txtDailyPrice
            // 
            txtDailyPrice.Location = new Point(165, 274);
            txtDailyPrice.Name = "txtDailyPrice";
            txtDailyPrice.Size = new Size(125, 27);
            txtDailyPrice.TabIndex = 1;
            // 
            // cmbFuelType
            // 
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Location = new Point(604, 98);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(151, 28);
            cmbFuelType.TabIndex = 2;
            // 
            // cmbTransmission
            // 
            cmbTransmission.FormattingEnabled = true;
            cmbTransmission.Location = new Point(604, 154);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(151, 28);
            cmbTransmission.TabIndex = 2;
            cmbTransmission.SelectedIndexChanged += cmbTransmission_SelectedIndexChanged;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblBrand.Location = new Point(61, 95);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(59, 18);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Marka";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(604, 207);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 2;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblFuelType.Location = new Point(472, 102);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(92, 18);
            lblFuelType.TabIndex = 0;
            lblFuelType.Text = "Yakıt Türü";
            // 
            // lblTransmission
            // 
            lblTransmission.AutoSize = true;
            lblTransmission.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblTransmission.Location = new Point(471, 164);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(91, 18);
            lblTransmission.TabIndex = 0;
            lblTransmission.Text = "Vites Türü";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(469, 211);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(115, 18);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Araç Durumu";
            // 
            // dgvCars
            // 
            dgvCars.BackgroundColor = SystemColors.InactiveCaption;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(384, 323);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersWidth = 51;
            dgvCars.Size = new Size(558, 131);
            dgvCars.TabIndex = 3;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(61, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 82);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(207, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 82);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(384, 9);
            label2.Name = "label2";
            label2.Size = new Size(262, 42);
            label2.TabIndex = 5;
            label2.Text = "ARAÇ KAYIT";
            // 
            // FrmCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1063, 530);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCars);
            Controls.Add(cmbStatus);
            Controls.Add(cmbTransmission);
            Controls.Add(cmbFuelType);
            Controls.Add(txtDailyPrice);
            Controls.Add(txtLicensePlate);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(lblDailyPrice);
            Controls.Add(lblLicensePlate);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblStatus);
            Controls.Add(lblTransmission);
            Controls.Add(lblFuelType);
            Controls.Add(lblBrand);
            Controls.Add(label1);
            Name = "FrmCar";
            Text = "FrmCar";
            Load += FrmCar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblModel;
        private Label lblYear;
        private Label lblLicensePlate;
        private Label lblDailyPrice;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtLicensePlate;
        private TextBox txtDailyPrice;
        private ComboBox cmbFuelType;
        private ComboBox cmbTransmission;
        private Label lblBrand;
        private ComboBox cmbStatus;
        private Label lblFuelType;
        private Label lblTransmission;
        private Label lblStatus;
        private DataGridView dgvCars;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label2;
    }
}