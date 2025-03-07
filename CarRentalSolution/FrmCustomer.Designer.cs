namespace CarRentalSolutionUI
{
    partial class FrmCustomer
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblTCNo = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTCNo = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            dgvCustomers = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(64, 128);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(30, 18);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Ad";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(57, 176);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 18);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyad";
            // 
            // lblTCNo
            // 
            lblTCNo.AutoSize = true;
            lblTCNo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblTCNo.Location = new Point(58, 224);
            lblTCNo.Name = "lblTCNo";
            lblTCNo.Size = new Size(84, 18);
            lblTCNo.TabIndex = 1;
            lblTCNo.Text = "TC Kimlik";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(58, 272);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(68, 18);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "Telefon";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(58, 318);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 18);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtFirstName.Location = new Point(212, 128);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(172, 26);
            txtFirstName.TabIndex = 2;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtLastName.Location = new Point(212, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 26);
            txtLastName.TabIndex = 2;
            // 
            // txtTCNo
            // 
            txtTCNo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtTCNo.Location = new Point(212, 217);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(172, 26);
            txtTCNo.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(212, 265);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(172, 26);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(212, 315);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 26);
            txtEmail.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(503, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 102);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(687, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 102);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = SystemColors.InactiveCaption;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(32, 385);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(921, 161);
            dgvCustomers.TabIndex = 4;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label1.Location = new Point(389, 24);
            label1.Name = "label1";
            label1.Size = new Size(269, 34);
            label1.TabIndex = 5;
            label1.Text = "MÜŞTERİ KAYIT";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1073, 581);
            Controls.Add(label1);
            Controls.Add(dgvCustomers);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtTCNo);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblTCNo);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblTCNo;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTCNo;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private DataGridView dgvCustomers;
        private Label label1;
    }
}