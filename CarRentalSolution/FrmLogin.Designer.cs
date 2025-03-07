namespace CarRentalSolutionUI
{
    partial class FrmLogin
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblMessage = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.HotTrack;
            lblUsername.Location = new Point(131, 118);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(201, 89);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            lblPassword.ForeColor = SystemColors.HotTrack;
            lblPassword.Location = new Point(131, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(215, 115);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre";
            lblPassword.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtUsername.Location = new Point(318, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 26);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtPassword.Location = new Point(318, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(166, 26);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(228, 307);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 86);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Verdana", 7.8F);
            lblMessage.Location = new Point(77, 396);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(491, 55);
            lblMessage.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label1.Location = new Point(269, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 34);
            label1.TabIndex = 6;
            label1.Text = "GİRİŞ";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(665, 488);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblMessage;
        private Label label1;
    }
}