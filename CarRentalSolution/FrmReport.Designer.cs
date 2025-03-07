namespace CarRentalSolutionUI
{
    partial class FrmReport
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
            dgvRental = new DataGridView();
            dgvPayment = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRental).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // dgvRental
            // 
            dgvRental.BackgroundColor = SystemColors.InactiveCaption;
            dgvRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRental.Location = new Point(46, 65);
            dgvRental.Name = "dgvRental";
            dgvRental.RowHeadersWidth = 51;
            dgvRental.Size = new Size(756, 131);
            dgvRental.TabIndex = 0;
            dgvRental.CellContentClick += dgvRental_CellContentClick;
            // 
            // dgvPayment
            // 
            dgvPayment.BackgroundColor = SystemColors.InactiveCaption;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(46, 257);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(756, 156);
            dgvPayment.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(165, 18);
            label1.TabIndex = 2;
            label1.Text = "Araç İşlem Geçmişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 223);
            label2.Name = "label2";
            label2.Size = new Size(187, 18);
            label2.TabIndex = 2;
            label2.Text = "Ödeme İşlem Geçmişi";
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1039, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPayment);
            Controls.Add(dgvRental);
            Name = "FrmReport";
            Text = "Report";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRental).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRental;
        private DataGridView dgvPayment;
        private Label label1;
        private Label label2;
    }
}