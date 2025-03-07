namespace CarRentalSolutionUI
{
    partial class FrmRental
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
            cmbCustomer = new ComboBox();
            cmbCar = new ComboBox();
            dtpRentDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            btnRentCar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            cmbPaymentMethod = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.Font = new Font("Verdana", 9F, FontStyle.Bold);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(250, 113);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(151, 26);
            cmbCustomer.TabIndex = 0;
            // 
            // cmbCar
            // 
            cmbCar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(250, 155);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(151, 26);
            cmbCar.TabIndex = 0;
            // 
            // dtpRentDate
            // 
            dtpRentDate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dtpRentDate.Location = new Point(250, 205);
            dtpRentDate.Name = "dtpRentDate";
            dtpRentDate.Size = new Size(269, 26);
            dtpRentDate.TabIndex = 1;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dtpReturnDate.Location = new Point(250, 263);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(269, 26);
            dtpReturnDate.TabIndex = 1;
            // 
            // btnRentCar
            // 
            btnRentCar.BackColor = SystemColors.HotTrack;
            btnRentCar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnRentCar.ForeColor = SystemColors.Control;
            btnRentCar.Location = new Point(156, 350);
            btnRentCar.Name = "btnRentCar";
            btnRentCar.Size = new Size(175, 104);
            btnRentCar.TabIndex = 2;
            btnRentCar.Text = "Kirala";
            btnRentCar.UseVisualStyleBackColor = false;
            btnRentCar.Click += btnRentCar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(107, 117);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 5;
            label1.Text = "Müşteri Seçimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(107, 159);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 5;
            label2.Text = "Araç Seçimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(107, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 5;
            label3.Text = "Alış Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(107, 263);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 5;
            label4.Text = "Dönüş Tarihi";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoEllipsis = true;
            lblTotalPrice.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalPrice.Location = new Point(751, 218);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(158, 71);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "Ödenecek Tutar:";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.HotTrack;
            btnCalculate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnCalculate.ForeColor = SystemColors.Control;
            btnCalculate.Location = new Point(751, 135);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(158, 57);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Ödeme Hesapla";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Verdana", 9F, FontStyle.Bold);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(352, 382);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(264, 26);
            cmbPaymentMethod.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(352, 350);
            label5.Name = "label5";
            label5.Size = new Size(246, 29);
            label5.TabIndex = 9;
            label5.Text = "Ödeme Türü";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(39, 504);
            label6.Name = "label6";
            label6.Size = new Size(782, 25);
            label6.TabIndex = 9;
            label6.Text = "*Ödeme Hesapla kısmına basarak ödeyeceğiniz tutarı görüntüleyebilirsiniz.";
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(39, 529);
            label7.Name = "label7";
            label7.Size = new Size(782, 25);
            label7.TabIndex = 9;
            label7.Text = "*Ödeme Türünü seçtikten sonra kirala butonuna basınız.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label8.Location = new Point(379, 25);
            label8.Name = "label8";
            label8.Size = new Size(357, 34);
            label8.TabIndex = 10;
            label8.Text = "KİRALAMA VE ÖDEME";
            // 
            // FrmRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1120, 597);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRentCar);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpRentDate);
            Controls.Add(cmbCar);
            Controls.Add(cmbCustomer);
            Name = "FrmRental";
            Text = "FrmRental";
            Load += FrmRental_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private ComboBox cmbCar;
        private DateTimePicker dtpRentDate;
        private DateTimePicker dtpReturnDate;
        private Button btnRentCar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalPrice;
        private Button btnCalculate;
        private ComboBox cmbPaymentMethod;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}