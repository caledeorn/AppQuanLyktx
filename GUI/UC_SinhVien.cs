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
using System.IO;

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
            var danhSach = QuanLyKTX.Instance.QLSinhVien.danhSachSinhVien();
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
            dgv.Columns["anhDaiDien"].Visible = false;
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
            dgvDanhSachSinhVien.DataSource = QuanLyKTX.Instance.QLSinhVien.sapXep(QuanLyKTX.Instance.QLPhong);
            var ds=QuanLyKTX.Instance.QLSinhVien.danhSachSinhVien();
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
                DataGridViewRow row = dgvDanhSachTimKiem.Rows[e.RowIndex];
                var sv = (WinFormsApp1.Model.SinhVien)row.DataBoundItem;
                if (sv == null) return;
                ShowSinhVien(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message);
            }
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgvDanhSachSinhVien.Rows[e.RowIndex];
                var sv = (WinFormsApp1.Model.SinhVien)row.DataBoundItem;
                if (sv == null) return;
                ShowSinhVien(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message);
            }
        }

        // Helper to populate UI fields and picture box from a SinhVien
        private void ShowSinhVien(SinhVien sv)
        {
            if (sv == null) return;

            // 1. Text
            txtMaSV.Text = sv.MaSV ?? "";
            txtHoTen.Text = sv.HoTen ?? "";
            txtSDT.Text = sv.SoDienThoai ?? "";

            // 2. Ngày sinh
            if (sv.NgaySinh > DateTime.MinValue)
            {
                dtpNgaySinh.Value = sv.NgaySinh;
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Today;
            }

            // 3. Giới tính
            radNam.Checked = sv.GioiTinh;
            radNu.Checked = !sv.GioiTinh;

            // 4. Ảnh đại diện
            picAnh.Image?.Dispose();
            picAnh.Image = null;
            picAnh.Tag = null;

            if (!string.IsNullOrWhiteSpace(sv.AnhDaiDien))
            {
                string fullPath = Path.Combine(Application.StartupPath, sv.AnhDaiDien);

                if (File.Exists(fullPath))
                {
                    // Cách an toàn: FromFile + Dispose ảnh cũ
                    picAnh.Image = Image.FromFile(fullPath);
                    picAnh.Tag = sv.AnhDaiDien;
                }
            }

            // 5. UX
            lblThongBao.Text = "";
            txtMaSV.Enabled = false;
            btnTao.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp|All files|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                string selected = ofd.FileName;

                // 1. Thư mục Images
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                // 2. Tạo tên file mới
                string maSV = txtMaSV.Text?.Trim();
                string ext = Path.GetExtension(selected);

                string destFileName = !string.IsNullOrEmpty(maSV)
                    ? maSV + ext
                    : Guid.NewGuid().ToString() + ext;

                string destFull = Path.Combine(imagesFolder, destFileName);

                try
                {
                    // 🔴 3. XÓA ẢNH CŨ NẾU CÓ
                    if (picAnh.Tag != null)
                    {
                        string oldRelative = picAnh.Tag.ToString();
                        string oldFull = Path.Combine(
                            Application.StartupPath,
                            oldRelative.TrimStart('\\', '/')
                        );

                        // Giải phóng ảnh đang hiển thị
                        picAnh.Image?.Dispose();
                        picAnh.Image = null;

                        if (File.Exists(oldFull))
                        {
                            File.Delete(oldFull);
                        }
                    }

                    // 4. Copy ảnh mới
                    File.Copy(selected, destFull, true);

                    // 5. Lưu đường dẫn tương đối
                    string relativePath = Path.Combine("Images", destFileName);
                    picAnh.Tag = relativePath;

                    // 6. Cập nhật model nếu đang sửa SV
                    if (!string.IsNullOrWhiteSpace(maSV))
                    {
                        var result = QuanLyKTX.Instance
                            .QLSinhVien
                            .CapNhatAnhSinhVien(maSV, relativePath);

                        lblThongBao.Text = result;
                        lblThongBao.ForeColor = Color.Green;
                    }

                    // 7. Hiển thị ảnh (KHÔNG dùng FromStream)
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    picAnh.Image = Image.FromFile(destFull);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xử lý ảnh: " + ex.Message);
                }
            }
        }

    }
}
