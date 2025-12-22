namespace WinFormsApp1.GUI
{
    partial class UC_PhieuBaoHong
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
            GroupBox groupBox2;
            flpDanhSach = new FlowLayoutPanel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            lblThongbao = new Label();
            cboThuocTinh = new ComboBox();
            txtThongTin = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnTimKiem = new Button();
            btnDonChuaXuLy = new Button();
            btnDonMoi = new Button();
            groupBox4 = new GroupBox();
            btnDaXuLy = new Button();
            lblTrangThai = new Label();
            lblThietBi = new Label();
            lblMoTa = new Label();
            lblNgay = new Label();
            lblMaPhong = new Label();
            lblMaSV = new Label();
            label12 = new Label();
            label14 = new Label();
            btnXacNhan = new Button();
            txtPhanHoi = new TextBox();
            label7 = new Label();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label = new Label();
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flpDanhSach);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(508, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(693, 552);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu báo hỏng";
            // 
            // flpDanhSach
            // 
            flpDanhSach.AutoScroll = true;
            flpDanhSach.Dock = DockStyle.Fill;
            flpDanhSach.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpDanhSach.Location = new Point(3, 25);
            flpDanhSach.Name = "flpDanhSach";
            flpDanhSach.Size = new Size(687, 524);
            flpDanhSach.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1201, 48);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblThongbao);
            groupBox3.Controls.Add(cboThuocTinh);
            groupBox3.Controls.Add(txtThongTin);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(btnDonChuaXuLy);
            groupBox3.Controls.Add(btnDonMoi);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(508, 150);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lblThongbao
            // 
            lblThongbao.AutoSize = true;
            lblThongbao.Location = new Point(202, 115);
            lblThongbao.Name = "lblThongbao";
            lblThongbao.Size = new Size(0, 15);
            lblThongbao.TabIndex = 7;
            // 
            // cboThuocTinh
            // 
            cboThuocTinh.FormattingEnabled = true;
            cboThuocTinh.Location = new Point(286, 77);
            cboThuocTinh.Name = "cboThuocTinh";
            cboThuocTinh.Size = new Size(121, 23);
            cboThuocTinh.TabIndex = 6;
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(286, 30);
            txtThongTin.Name = "txtThongTin";
            txtThongTin.Size = new Size(100, 23);
            txtThongTin.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 80);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 4;
            label9.Text = "Thuộc tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 33);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 3;
            label8.Text = "Thông tin:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(28, 113);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 31);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDonChuaXuLy
            // 
            btnDonChuaXuLy.Location = new Point(28, 54);
            btnDonChuaXuLy.Name = "btnDonChuaXuLy";
            btnDonChuaXuLy.Size = new Size(75, 51);
            btnDonChuaXuLy.TabIndex = 1;
            btnDonChuaXuLy.Text = "Đơn chưa xử lý";
            btnDonChuaXuLy.UseVisualStyleBackColor = true;
            btnDonChuaXuLy.Click += btnDonChuaGiaiQuyet_Click;
            // 
            // btnDonMoi
            // 
            btnDonMoi.Location = new Point(28, 17);
            btnDonMoi.Name = "btnDonMoi";
            btnDonMoi.Size = new Size(75, 31);
            btnDonMoi.TabIndex = 0;
            btnDonMoi.Text = "Đơn mới";
            btnDonMoi.UseVisualStyleBackColor = true;
            btnDonMoi.Click += btnDonMoi_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDaXuLy);
            groupBox4.Controls.Add(lblTrangThai);
            groupBox4.Controls.Add(lblThietBi);
            groupBox4.Controls.Add(lblMoTa);
            groupBox4.Controls.Add(lblNgay);
            groupBox4.Controls.Add(lblMaPhong);
            groupBox4.Controls.Add(lblMaSV);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(btnXacNhan);
            groupBox4.Controls.Add(txtPhanHoi);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 198);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(508, 402);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // btnDaXuLy
            // 
            btnDaXuLy.Location = new Point(180, 313);
            btnDaXuLy.Name = "btnDaXuLy";
            btnDaXuLy.Size = new Size(75, 23);
            btnDaXuLy.TabIndex = 17;
            btnDaXuLy.Text = "Đã xử lý";
            btnDaXuLy.UseVisualStyleBackColor = true;
            btnDaXuLy.Click += btnDaXuLy_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(338, 87);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 15);
            lblTrangThai.TabIndex = 16;
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Location = new Point(115, 131);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(0, 15);
            lblThietBi.TabIndex = 15;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(115, 173);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(0, 15);
            lblMoTa.TabIndex = 14;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(115, 87);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(0, 15);
            lblNgay.TabIndex = 13;
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(338, 40);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(0, 15);
            lblMaPhong.TabIndex = 12;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(115, 40);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(0, 15);
            lblMaSV.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(251, 87);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 10;
            label12.Text = "Trạng thái:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 131);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 9;
            label14.Text = "Thiết bị:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(28, 313);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtPhanHoi
            // 
            txtPhanHoi.Location = new Point(91, 245);
            txtPhanHoi.Name = "txtPhanHoi";
            txtPhanHoi.Size = new Size(272, 23);
            txtPhanHoi.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 248);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 5;
            label7.Text = "Phản hồi:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 173);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 4;
            label15.Text = "Mô tả:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 87);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 2;
            label13.Text = "Ngày lập đơn:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(251, 40);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 1;
            label11.Text = "Mã Phòng:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(28, 40);
            label.Name = "label";
            label.Size = new Size(43, 15);
            label.TabIndex = 0;
            label.Text = "Mã SV:";
            // 
            // UC_PhieuBaoHong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_PhieuBaoHong";
            Size = new Size(1201, 600);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpDanhSach;
        private GroupBox groupBox3;
        private Button btnTimKiem;
        private Button btnDonChuaXuLy;
        private Button btnDonMoi;
        private GroupBox groupBox4;
        private Label label;
        private Label label11;
        private Label label13;
        private Button btnXacNhan;
        private TextBox txtPhanHoi;
        private Label label7;
        private Label label15;
        private Label label9;
        private Label label8;
        private Label label14;
        private ComboBox cboThuocTinh;
        private TextBox txtThongTin;
        private Label label12;
        private Label lblTrangThai;
        private Label lblThietBi;
        private Label lblMoTa;
        private Label lblNgay;
        private Label lblMaPhong;
        private Label lblMaSV;
        private Button btnDaXuLy;
        private Label lblThongbao;
    }
}
