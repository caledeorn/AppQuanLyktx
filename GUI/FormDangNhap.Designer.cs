namespace WinFormsApp1.GUI
{
    partial class FormDangNhap
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
            lblTen = new Label();
            label1 = new Label();
            label2 = new Label();
            btnDangNhap = new Button();
            panel2 = new Panel();
            txtPassword = new TextBox();
            panel1 = new Panel();
            txtUserName = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblTen.Location = new Point(35, 83);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(97, 22);
            lblTen.TabIndex = 0;
            lblTen.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(35, 126);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 1;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 21);
            label2.Name = "label2";
            label2.Size = new Size(207, 26);
            label2.TabIndex = 2;
            label2.Text = "Ký túc xá sinh viên";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(138, 166);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(117, 29);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(139, 126);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(117, 18);
            panel2.TabIndex = 1;
            panel2.TabStop = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(1, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(115, 14);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(txtUserName);
            panel1.Location = new Point(140, 83);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(116, 18);
            panel1.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(1, 1);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 14);
            txtUserName.TabIndex = 1;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 229);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTen);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FormDangNhap_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private Label label1;
        private Label label2;
        private Button btnDangNhap;
        private Panel panel2;
        private TextBox txtPassword;
        private Panel panel1;
        private TextBox txtUserName;
    }
}