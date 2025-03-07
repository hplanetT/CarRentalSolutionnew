namespace CarRentalSolutionUI
{
    partial class FrmMain
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
            btnCustomers = new Button();
            btnCars = new Button();
            btnRentals = new Button();
            btnLogout = new Button();
            btnReport = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.HotTrack;
            btnCustomers.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnCustomers.ForeColor = SystemColors.Control;
            btnCustomers.Location = new Point(55, 113);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(192, 91);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCars
            // 
            btnCars.BackColor = SystemColors.HotTrack;
            btnCars.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnCars.ForeColor = SystemColors.Control;
            btnCars.Location = new Point(359, 113);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(192, 91);
            btnCars.TabIndex = 0;
            btnCars.Text = "Arabalar";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = SystemColors.HotTrack;
            btnRentals.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnRentals.ForeColor = SystemColors.Control;
            btnRentals.Location = new Point(55, 252);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new Size(192, 96);
            btnRentals.TabIndex = 0;
            btnRentals.Text = "Kiralama";
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.HotTrack;
            btnLogout.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(208, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(204, 100);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = SystemColors.HotTrack;
            btnReport.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnReport.ForeColor = SystemColors.Control;
            btnReport.Location = new Point(359, 252);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(192, 96);
            btnReport.TabIndex = 3;
            btnReport.Text = "Raporlar";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label1.Location = new Point(208, 27);
            label1.Name = "label1";
            label1.Size = new Size(186, 34);
            label1.TabIndex = 4;
            label1.Text = "ANA MENÜ";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(617, 547);
            Controls.Add(label1);
            Controls.Add(btnReport);
            Controls.Add(btnLogout);
            Controls.Add(btnRentals);
            Controls.Add(btnCars);
            Controls.Add(btnCustomers);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomers;
        private Button btnCars;
        private Button btnRentals;
        private Button btnLogout;
        private Button btnReport;
        private Label label1;
    }
}