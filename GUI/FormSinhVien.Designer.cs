namespace WinFormsApp1.GUI
{
    partial class FormSinhVien
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
            splitContainer1 = new SplitContainer();
            btnHoaDon = new Button();
            btnNhanThan = new Button();
            btnDoiMatKhau = new Button();
            btnDangXuat = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label2 = new Label();
            groupBox1 = new GroupBox();
            splitContainer5 = new SplitContainer();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvDanhSach = new DataGridView();
            splitContainer6 = new SplitContainer();
            groupBox3 = new GroupBox();
            lblThongbao = new Label();
            txtThietBi = new TextBox();
            label6 = new Label();
            button1 = new Button();
            txtMoTa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            flpThongBao = new FlowLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnHoaDon);
            splitContainer1.Panel1.Controls.Add(btnNhanThan);
            splitContainer1.Panel1.Controls.Add(btnDoiMatKhau);
            splitContainer1.Panel1.Controls.Add(btnDangXuat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(795, 511);
            splitContainer1.SplitterDistance = 28;
            splitContainer1.TabIndex = 0;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Left;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(75, 0);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(75, 28);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanThan
            // 
            btnNhanThan.Dock = DockStyle.Left;
            btnNhanThan.FlatAppearance.BorderSize = 0;
            btnNhanThan.FlatStyle = FlatStyle.Flat;
            btnNhanThan.Location = new Point(0, 0);
            btnNhanThan.Name = "btnNhanThan";
            btnNhanThan.Size = new Size(75, 28);
            btnNhanThan.TabIndex = 2;
            btnNhanThan.Text = "Cá nhân";
            btnNhanThan.UseVisualStyleBackColor = true;
            btnNhanThan.Click += btnNhanThan_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Cursor = Cursors.Hand;
            btnDoiMatKhau.Dock = DockStyle.Right;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Location = new Point(622, 0);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(98, 28);
            btnDoiMatKhau.TabIndex = 1;
            btnDoiMatKhau.Text = "Đối mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Right;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Location = new Point(720, 0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 28);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer6);
            splitContainer2.Size = new Size(795, 479);
            splitContainer2.SplitterDistance = 212;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Size = new Size(795, 212);
            splitContainer3.SplitterDistance = 357;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(groupBox1);
            splitContainer4.Size = new Size(357, 212);
            splitContainer4.SplitterDistance = 25;
            splitContainer4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 2;
            label2.Text = "Thông tin:";
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.IsSplitterFixed = true;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label1);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(groupBox2);
            splitContainer5.Size = new Size(434, 212);
            splitContainer5.SplitterDistance = 25;
            splitContainer5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 22);
            label1.TabIndex = 1;
            label1.Text = "Danh sách bạn cùng phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSach);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 183);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.BackgroundColor = SystemColors.Control;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 17);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(428, 163);
            dgvDanhSach.TabIndex = 1;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.IsSplitterFixed = true;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(groupBox4);
            splitContainer6.Size = new Size(795, 263);
            splitContainer6.SplitterDistance = 357;
            splitContainer6.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblThongbao);
            groupBox3.Controls.Add(txtThietBi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(txtMoTa);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 263);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // lblThongbao
            // 
            lblThongbao.AutoSize = true;
            lblThongbao.Location = new Point(72, 139);
            lblThongbao.Name = "lblThongbao";
            lblThongbao.Size = new Size(0, 15);
            lblThongbao.TabIndex = 6;
            // 
            // txtThietBi
            // 
            txtThietBi.Location = new Point(72, 67);
            txtThietBi.Name = "txtThietBi";
            txtThietBi.Size = new Size(246, 21);
            txtThietBi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 70);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Thiết bị:";
            // 
            // button1
            // 
            button1.Location = new Point(120, 160);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 3;
            button1.Text = "Tạo phản hồi mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(72, 105);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(246, 21);
            txtMoTa.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Nội dung:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 0;
            label3.Text = "Phản hồi mới :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flpThongBao);
            groupBox4.Controls.Add(label5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(434, 263);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // flpThongBao
            // 
            flpThongBao.AutoScroll = true;
            flpThongBao.Dock = DockStyle.Fill;
            flpThongBao.Location = new Point(3, 39);
            flpThongBao.Name = "flpThongBao";
            flpThongBao.Size = new Size(428, 221);
            flpThongBao.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 17);
            label5.Name = "label5";
            label5.Size = new Size(173, 22);
            label5.TabIndex = 0;
            label5.Text = "Thông báo phản hồi";
            // 
            // FormSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 511);
            Controls.Add(splitContainer1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSinhVien";
            FormClosed += FormSinhVien_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnDoiMatKhau;
        private Button btnDangXuat;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private SplitContainer splitContainer6;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private TextBox txtMoTa;
        private Label label4;
        private Label label3;
        private Button btnHoaDon;
        private Button btnNhanThan;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanhSach;
        private Label label5;
        private FlowLayoutPanel flpThongBao;
        private Label label6;
        private TextBox txtThietBi;
        private Label lblThongbao;
    }
}