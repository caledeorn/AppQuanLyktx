namespace WinFormsApp1
{
    partial class UC_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SinhVien));
            groupBox1 = new GroupBox();
            button5 = new Button();
            label4 = new Label();
            btnTaiAnh = new Button();
            picAnh = new PictureBox();
            groupBox4 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtSDT = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            lblThongBao = new Label();
            lblTBTK = new Label();
            btnTimKiem = new Button();
            cboThuocTinh = new ComboBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            btnLamMoi = new Button();
            label10 = new Label();
            label11 = new Label();
            splitter1 = new Splitter();
            splitContainer2 = new SplitContainer();
            dgvDanhSachSinhVien = new DataGridView();
            dgvDanhSachTimKiem = new DataGridView();
            btnTao = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTimKiem).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1200, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(6, 17);
            button5.Name = "button5";
            button5.Size = new Size(42, 38);
            button5.TabIndex = 3;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(412, 17);
            label4.Name = "label4";
            label4.Size = new Size(298, 32);
            label4.TabIndex = 0;
            label4.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(533, 133);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(90, 33);
            btnTaiAnh.TabIndex = 5;
            btnTaiAnh.Text = "Tải Ảnh";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // picAnh
            // 
            picAnh.BackgroundImage = (Image)resources.GetObject("picAnh.BackgroundImage");
            picAnh.BackgroundImageLayout = ImageLayout.Zoom;
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(533, 16);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(90, 111);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 6;
            picAnh.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radNu);
            groupBox4.Controls.Add(radNam);
            groupBox4.Location = new Point(244, 73);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(172, 42);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giới Tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(89, 16);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 11;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(6, 16);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 10;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(333, 128);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(118, 23);
            txtSDT.TabIndex = 4;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(71, 88);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(154, 23);
            txtMaSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(71, 44);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(380, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.KeyDown += txtHoTen_KeyDown;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(71, 128);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(154, 23);
            dtpNgaySinh.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 131);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.Location = new Point(29, 91);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "MSSV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 134);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(lblThongBao);
            groupBox2.Controls.Add(lblTBTK);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(cboThuocTinh);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnTaiAnh);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(picAnh);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(txtMaSV);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 67);
            groupBox2.Margin = new Padding(10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1200, 172);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(445, 91);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 24);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(71, 154);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 13;
            // 
            // lblTBTK
            // 
            lblTBTK.AutoSize = true;
            lblTBTK.Location = new Point(914, 154);
            lblTBTK.Name = "lblTBTK";
            lblTBTK.Size = new Size(0, 15);
            lblTBTK.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(806, 137);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 35);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm KIếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboThuocTinh
            // 
            cboThuocTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuocTinh.FormattingEnabled = true;
            cboThuocTinh.Location = new Point(806, 88);
            cboThuocTinh.Name = "cboThuocTinh";
            cboThuocTinh.Size = new Size(152, 23);
            cboThuocTinh.TabIndex = 12;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(806, 44);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(312, 23);
            txtTimKiem.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(729, 91);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 10;
            label9.Text = "Thuộc Tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 47);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 9;
            label8.Text = "Thông Tin Cần Tìm: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(684, 19);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 8;
            label7.Text = "TÌM KIẾM ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(185, 19);
            label6.TabIndex = 4;
            label6.Text = "THÔNG TIN SINH VIÊN";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 292);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            splitContainer1.Panel1.Controls.Add(splitter1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1200, 309);
            splitContainer1.SplitterDistance = 35;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(btnLamMoi);
            splitContainer3.Panel1.Controls.Add(label10);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(label11);
            splitContainer3.Size = new Size(1197, 35);
            splitContainer3.SplitterDistance = 598;
            splitContainer3.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Right;
            btnLamMoi.Location = new Point(487, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(111, 35);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(208, 21);
            label10.TabIndex = 0;
            label10.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(181, 21);
            label11.TabIndex = 1;
            label11.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 35);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.ButtonHighlight;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvDanhSachSinhVien);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvDanhSachTimKiem);
            splitContainer2.Size = new Size(1200, 270);
            splitContainer2.SplitterDistance = 600;
            splitContainer2.TabIndex = 0;
            // 
            // dgvDanhSachSinhVien
            // 
            dgvDanhSachSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSinhVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSinhVien.Dock = DockStyle.Fill;
            dgvDanhSachSinhVien.Location = new Point(0, 0);
            dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            dgvDanhSachSinhVien.RowHeadersWidth = 51;
            dgvDanhSachSinhVien.Size = new Size(600, 270);
            dgvDanhSachSinhVien.TabIndex = 0;
            dgvDanhSachSinhVien.CellClick += dgvDanhSachSinhVien_CellClick;
            dgvDanhSachSinhVien.DataError += dgvDanhSachSinhVien_DataError;
            // 
            // dgvDanhSachTimKiem
            // 
            dgvDanhSachTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachTimKiem.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTimKiem.Dock = DockStyle.Fill;
            dgvDanhSachTimKiem.Location = new Point(0, 0);
            dgvDanhSachTimKiem.Name = "dgvDanhSachTimKiem";
            dgvDanhSachTimKiem.RowHeadersWidth = 51;
            dgvDanhSachTimKiem.Size = new Size(596, 270);
            dgvDanhSachTimKiem.TabIndex = 0;
            dgvDanhSachTimKiem.CellClick += dgvDanhSachTimKiem_CellClick;
            dgvDanhSachTimKiem.DataError += dgvDanhSachTimKiem_DataError;
            // 
            // btnTao
            // 
            btnTao.Location = new Point(71, 8);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(120, 45);
            btnTao.TabIndex = 6;
            btnTao.Text = "Thêm Sinh Viên";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(530, 8);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 45);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 8);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 45);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnTao);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1200, 53);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // UC_SinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(splitContainer1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "UC_SinhVien";
            Size = new Size(1200, 601);
            Load += UC_SinhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTimKiem).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private CheckedListBox checkedListBox1;
        private TextBox txtSDT;
        private RadioButton radNam;
        private GroupBox groupBox4;
        private RadioButton radNu;
        private Button btnTaiAnh;
        private PictureBox picAnh;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private ComboBox cboThuocTinh;
        private TextBox txtTimKiem;
        private Button button5;
        private Button btnTimKiem;
        private SplitContainer splitContainer1;
        private Label label11;
        private Label label10;
        private SplitContainer splitContainer2;
        private DataGridView dgvDanhSachSinhVien;
        private DataGridView dgvDanhSachTimKiem;
        private SplitContainer splitContainer3;
        private Splitter splitter1;
        private Button btnTao;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox3;
        private Label lblTBTK;
        private Label lblThongBao;
        private Button btnClear;
    }
}
