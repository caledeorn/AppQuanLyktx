namespace WinFormsApp1.GUI
{
    partial class UCHoaDonPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaPhong = new Label();
            lblNgay = new Label();
            lblSoDien = new Label();
            lblSoNuoc = new Label();
            label5 = new Label();
            lblThanhTien = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(15, 11);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(45, 15);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Phòng:";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(141, 11);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(38, 15);
            lblNgay.TabIndex = 1;
            lblNgay.Text = "Ngày:";
            // 
            // lblSoDien
            // 
            lblSoDien.AutoSize = true;
            lblSoDien.Location = new Point(15, 39);
            lblSoDien.Name = "lblSoDien";
            lblSoDien.Size = new Size(49, 15);
            lblSoDien.TabIndex = 2;
            lblSoDien.Text = "Số điện:";
            // 
            // lblSoNuoc
            // 
            lblSoNuoc.AutoSize = true;
            lblSoNuoc.Location = new Point(141, 39);
            lblSoNuoc.Name = "lblSoNuoc";
            lblSoNuoc.Size = new Size(53, 15);
            lblSoNuoc.TabIndex = 3;
            lblSoNuoc.Text = "Số nước:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 68);
            label5.Name = "label5";
            label5.Size = new Size(217, 15);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá: 3000VND/kwh,5000VND/khối   ";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(15, 95);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(67, 15);
            lblThanhTien.TabIndex = 5;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(15, 124);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(63, 15);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // UCHoaDonPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTrangThai);
            Controls.Add(lblThanhTien);
            Controls.Add(label5);
            Controls.Add(lblSoNuoc);
            Controls.Add(lblSoDien);
            Controls.Add(lblNgay);
            Controls.Add(lblMaPhong);
            Name = "UCHoaDonPhong";
            Size = new Size(312, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhong;
        private Label lblNgay;
        private Label lblSoDien;
        private Label lblSoNuoc;
        private Label label5;
        private Label lblThanhTien;
        private Label lblTrangThai;
    }
}
