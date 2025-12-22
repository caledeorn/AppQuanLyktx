namespace WinFormsApp1.GUI
{
    partial class UCNhanThan
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
            lblHoTen = new Label();
            lblMaSV = new Label();
            lblMaPhong = new Label();
            lblNgaySinh = new Label();
            lblSDT = new Label();
            lblHopDong = new Label();
            lblGioiTinh = new Label();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(103, 11);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(103, 39);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(43, 15);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã SV:";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(207, 39);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(65, 15);
            lblMaPhong.TabIndex = 2;
            lblMaPhong.Text = "Mã phòng:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(103, 110);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(64, 15);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(207, 74);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(76, 15);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblHopDong
            // 
            lblHopDong.AutoSize = true;
            lblHopDong.Location = new Point(103, 143);
            lblHopDong.Name = "lblHopDong";
            lblHopDong.Size = new Size(112, 15);
            lblHopDong.TabIndex = 5;
            lblHopDong.Text = "Thời hạn hợp đồng:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(103, 74);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(52, 15);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính";
            // 
            // UCNhanThan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGioiTinh);
            Controls.Add(lblHopDong);
            Controls.Add(lblSDT);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblMaPhong);
            Controls.Add(lblMaSV);
            Controls.Add(lblHoTen);
            Name = "UCNhanThan";
            Size = new Size(402, 194);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblMaSV;
        private Label lblMaPhong;
        private Label lblNgaySinh;
        private Label lblSDT;
        private Label lblHopDong;
        private Label lblGioiTinh;
    }
}
