using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BLL;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class UC_SinhVien : UserControl
    {
        public UC_SinhVien()
        {
            InitializeComponent();
        }
        private void UC_SinhVien_Load(object sender, EventArgs e)

        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Nếu bạn muốn chọn xong tự tìm luôn thì gọi nút Tìm kiếm
            // 1. Xóa cũ
            cboThuocTinh.Items.Clear();

            // 2. Thêm mới đầy đủ các trường
            cboThuocTinh.Items.Add("Tên");
            cboThuocTinh.Items.Add("Mã SV");
            cboThuocTinh.Items.Add("Số điện thoại");
            cboThuocTinh.Items.Add("Giới tính");
            cboThuocTinh.Items.Add("Ngày sinh");
            cboThuocTinh.Items.Add("Phòng");

            // 3. Chọn mặc định
            cboThuocTinh.SelectedIndex = 0;
            btnLamMoi_Click(sender, e);

        }
        // Viết hàm này 1 lần dùng cho cả 2 bảng
        private void DinhDangCotBang(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;

            // Ẩn cột thừa
            string[] cotAn = { "GioiTinh", "Phong" };
            foreach (string tenCot in cotAn)
            {
                if (dgv.Columns.Contains(tenCot)) dgv.Columns[tenCot].Visible = false;
            }

            // Định dạng cột hiển thị
            ThietLapCot(dgv, "MaSV", "Mã SV", 70);
            ThietLapCot(dgv, "HoTen", "Họ và Tên", 140);
            ThietLapCot(dgv, "SoDienThoai", "Số ĐT", 80);
            ThietLapCot(dgv, "NgaySinh", "Ngày Sinh", 70);
            ThietLapCot(dgv, "GioiTinhHienThi", "Giới Tính", 60);
            ThietLapCot(dgv, "MaPhong", "Phòng", 50);
            if (dgv.Columns.Contains("NgaySinh"))
                dgv.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Hàm phụ trợ cho gọn
        private void ThietLapCot(DataGridView dgv, string tenBien, string tieuDe, int doRong)
        {
            if (dgv.Columns.Contains(tenBien))
            {
                dgv.Columns[tenBien].HeaderText = tieuDe;
                dgv.Columns[tenBien].Width = doRong;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            string timKiem = txtTimKiem.Text;
            string thuocTinh = cboThuocTinh.SelectedItem.ToString();
            if (thuocTinh == null)
            {
                lblTBTK.Text = "Vui lòng chọn thuộc tính để tìm kiếm.";
                lblTBTK.ForeColor = Color.Red;
            }
            List<SinhVien> ketQua = QuanLyKTX.Instance.QLSinhVien.timKiemSinhVien(timKiem, thuocTinh);
            if (ketQua.Count > 0)
            {
                lblTBTK.Text = $"Tìm thấy {ketQua.Count} sinh viên.";
                lblTBTK.ForeColor = Color.Green;
                dgvDanhSachTimKiem.DataSource = null;
                dgvDanhSachTimKiem.DataSource = ketQua;
                DinhDangCotBang(dgvDanhSachTimKiem);
            }
            else
            {
                lblTBTK.Text = "Không tìm thấy sinh viên nào.";
                lblTBTK.ForeColor = Color.Red;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDanhSachSinhVien.DataSource = null;
            dgvDanhSachSinhVien.DataSource = QuanLyKTX.Instance.QLSinhVien.sapXep(QuanLyKTX.Instance.QLPhong); ;
            DinhDangCotBang(dgvDanhSachSinhVien);
        }


        private void btnTao_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string soDienThoai = txtSDT.Text;
            bool gioiTinh = radNam.Checked;
            string result = QuanLyKTX.Instance.QLSinhVien.themSinhVien(maSV, hoTen, ngaySinh, soDienThoai, gioiTinh);
            if (result == "Thêm sinh viên thành công.")
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Green;
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                radNam.Checked = true;
                picAnh.Image = null;
                picAnh.Tag = null;
                txtHoTen.Focus();
            }
            else
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Red;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string result = QuanLyKTX.Instance.QLSinhVien.xoaSinhVien(maSV);
            if (result == "Xóa sinh viên thành công.")
            {
                //MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                radNam.Checked = true;
                //picAnh.Image = null;
                //picAnh.Tag = null;
                dgvDanhSachTimKiem.Focus();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnClear.Enabled = false;
                btnTao.Enabled = true;
                txtMaSV.Enabled = true;
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                // 2. Lấy đối tượng SinhVien nằm trong dòng vừa chọn
                // (Cách này hay hơn cách lấy row.Cells["TenCot"].Value vì nó lấy đúng kiểu dữ liệu gốc)
                DataGridViewRow row = dgvDanhSachTimKiem.Rows[e.RowIndex];

                // Ép kiểu dữ liệu về Class SinhVien của bạn
                var sv = (WinFormsApp1.Model.SinhVien)row.DataBoundItem;

                if (sv == null) return;

                // 3. Đổ dữ liệu lên các ô nhập (TextBox)
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                txtSDT.Text = sv.SoDienThoai;

                // 4. Xử lý Ngày tháng (DateTimePicker)
                // Cần kiểm tra null hoặc ngày hợp lệ để tránh lỗi
                if (sv.NgaySinh != null)
                {
                    dtpNgaySinh.Value = sv.NgaySinh;
                }

                // 5. Xử lý Giới tính (RadioButton)
                // Giả sử trong Model GioiTinh là bool (true = Nam)
                if (sv.GioiTinh == true)
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                // 6. Xử lý Ảnh (PictureBox)
                // Giả sử sv.AnhDaiDien lưu tên file (ví dụ: "sv001.jpg")
                string folderPath = Application.StartupPath + "\\Images\\";
                // string fullPath = folderPath + sv.AnhDaiDien; // Hoặc sv.TenFileAnh tùy model bạn

                //if (!string.IsNullOrEmpty(sv.AnhDaiDien) && System.IO.File.Exists(fullPath))
                //{
                //    // Dùng FileStream để load ảnh mà không khóa file (giúp bạn xóa/sửa ảnh được sau này)
                //    using (System.IO.FileStream fs = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                //    {
                //        picAnh.Image = Image.FromStream(fs);
                //    }
                //    picAnh.Tag = fullPath; // Lưu đường dẫn vào Tag để dùng khi cần
                //}
                //else
                //{
                //    picAnh.Image = null; // Nếu không có ảnh thì xóa trắng PictureBox
                //    picAnh.Tag = null;
                //}

                // 7. Quản lý trạng thái các nút (UX)
                txtMaSV.Enabled = false; // Khóa Mã SV lại (không cho sửa khóa chính)
                btnTao.Enabled = false; // Tắt nút Thêm
                btnSua.Enabled = true;   // Bật nút Sửa
                btnXoa.Enabled = true;   // Bật nút Xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message);
            }

        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMaSV.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            picAnh.Image = null;
            picAnh.Tag = null;
            txtHoTen.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnClear.Enabled = false;
            btnTao.Enabled = true;
            txtMaSV.Enabled = true;
        }



        private void dgvDanhSachSinhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvDanhSachTimKiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string soDienThoai = txtSDT.Text;
            bool gioiTinh = radNam.Checked;
            string result = QuanLyKTX.Instance.QLSinhVien.suaSinhVien(maSV, hoTen, ngaySinh, soDienThoai, gioiTinh);
            if (result == "Sửa sinh viên thành công.")
            {
                //MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Green;
                btnClear_Click(sender, e);
            }
            else
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
