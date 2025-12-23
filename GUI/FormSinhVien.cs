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

namespace WinFormsApp1.GUI
{
    public partial class FormSinhVien : Form
    {
        SinhVien sv;

        public FormSinhVien(string tk)
        {
            InitializeComponent();
            sv = QuanLyKTX.Instance.QLSinhVien.timKiem(tk);
            if (sv.Phong == null)
            {
                lblDanhSach.Text = "Chưa có phòng";
                btnHoaDon.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                loadDanhSach();
                loadThongBao();
            }
            loadNhanThan();
        }
        private void loadDanhSach()
        {
            // 1. Kiểm tra nếu sinh viên chưa có phòng
            if (sv.Phong == null)
            {
                lblDanhSach.Text = "Bạn chưa có phòng.";
                // Xóa dữ liệu cũ trên lưới nếu có
                dgvDanhSach.DataSource = null;
                return;
            }
            try
            {
                // 2. Lấy danh sách sinh viên
                var listSV = sv.Phong.danhSachSV;

                // 3. KIỂM TRA AN TOÀN: Nếu danh sách null hoặc rỗng thì dừng lại
                // Nếu không có dữ liệu, không cần format cột làm gì cho lỗi
                if (listSV == null || listSV.Count == 0)
                {
                    dgvDanhSach.DataSource = null;
                    return;
                }

                // 4. Gán nguồn dữ liệu
                // Lưu ý: Đừng dùng dgvDanhSach.Controls.Clear(), nó sai mục đích.
                // Để reset dữ liệu, chỉ cần gán DataSource mới là được.
                dgvDanhSach.DataSource = listSV;

                // 5. Cấu hình cột (Dùng toán tử ?. để tránh lỗi nếu cột không tìm thấy)
                // Cách viết: dgv.Columns["Ten"]?.ThuocTinh = ...

                if (dgvDanhSach.Columns["Phong"] != null)
                    dgvDanhSach.Columns["Phong"].Visible = false;

                if (dgvDanhSach.Columns["GioiTinh"] != null)
                    dgvDanhSach.Columns["GioiTinh"].Visible = false;

                if (dgvDanhSach.Columns["GioiTinhHienThi"] != null)
                    dgvDanhSach.Columns["GioiTinhHienThi"].Visible = false;

                if (dgvDanhSach.Columns["anhDaiDien"] != null)
                    dgvDanhSach.Columns["anhDaiDien"].Visible = false;

                // Format HeaderText
                if (dgvDanhSach.Columns["NgaySinh"] != null)
                    dgvDanhSach.Columns["NgaySinh"].HeaderText = "Ngày Sinh";

                if (dgvDanhSach.Columns["MaPhong"] != null)
                    dgvDanhSach.Columns["MaPhong"].HeaderText = "Mã Phòng";

                if (dgvDanhSach.Columns["MaSV"] != null)
                    dgvDanhSach.Columns["MaSV"].HeaderText = "Mã SV";

                if (dgvDanhSach.Columns["HoTen"] != null)
                {
                    dgvDanhSach.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvDanhSach.Columns["HoTen"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                if (dgvDanhSach.Columns["SoDienThoai"] != null)
                    dgvDanhSach.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";

                // Tự động giãn dòng
                dgvDanhSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi tải danh sách sinh viên: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void loadThongBao()
        {
            flpThongBao.Controls.Clear();
            var danhSachTB = QuanLyKTX.Instance.QLPhieuBaoHong.timKiemTheoSinhVien(sv.MaSV);
            foreach (var tb in danhSachTB)
            {
                string trangThai = "";
                if (tb.daTiepNhan == false) trangThai = "Chưa tiếp nhận";
                else if (tb.daXuLy == false) trangThai = "Đã tiếp nhận";
                else trangThai = "Đã xư lý";
                UCThongBao uc = new UCThongBao();
                uc.setData(tb.ngayBaoHong, trangThai, tb.noiDung, tb.phanHoi);
                flpThongBao.Controls.Add(uc);
            }
        }
        private void loadNhanThan()
        {
            groupBox1.Controls.Clear();
            UCNhanThan uc = new UCNhanThan();
            string maPhong;
            DateTime ngayKetThuc;
            if (sv.Phong == null)
            {
                maPhong = "";
                ngayKetThuc = DateTime.Now;

            }
            else { maPhong = sv.Phong.maPhong;
                ngayKetThuc=QuanLyKTX.Instance.QLHopDong.timKiemHopDongTheoMaSV(sv.MaSV).ngayKetThuc;
            }
            uc.setData(sv.HoTen, sv.MaSV, maPhong, sv.SoDienThoai, sv.GioiTinh, sv.NgaySinh, ngayKetThuc, sv.AnhDaiDien);
            uc.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(uc);
        }

        private void loadHoaDon()
        {
            groupBox1.Controls.Clear();
            UCHoaDonPhong uc = new UCHoaDonPhong();
            var hoaDon = QuanLyKTX.Instance.QLHoaDon.timKiemHoaDonTheoMaPhong(sv.Phong.maPhong);
            uc.setData(hoaDon.phong.maPhong, hoaDon.ngayLap, hoaDon.soDien, hoaDon.soNuoc, hoaDon.trangThai);
            uc.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(uc);
        }
        private void FormSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyKTX.Instance.SaveAllData();
            Application.Exit();
        }

        private void btnNhanThan_Click(object sender, EventArgs e)
        {
            loadNhanThan();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
            string loaiPhanHoi = txtLoaiPhanHoi.Text;
            string noiDung= txtMoTa.Text;
            DateTime ngayLap = DateTime.Now.Date;
            if (txtLoaiPhanHoi.Text == "")
            {
                lblThongbao.Text = "Loại phản hồi không được để trống.";
                lblThongbao.ForeColor = Color.Red;
                txtLoaiPhanHoi.Focus();
                return;
            }
            else if (txtMoTa.Text == "")
            {
                lblThongbao.Text = "Nội dung không được để trống.";
                lblThongbao.ForeColor = Color.Red;
                txtMoTa.Focus();
                return;
            }
            QuanLyKTX.Instance.QLPhieuBaoHong.taoPhanHoi(sv, loaiPhanHoi, noiDung, ngayLap);
            lblThongbao.Text = "Tạo phiếu báo hỏng thành công.";
            lblThongbao.ForeColor = Color.Green;
            loadThongBao();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // 1. Hỏi người dùng có chắc muốn đăng xuất không
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Thông báo",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // 2. Nếu chọn Yes thì đăng xuất
            if (traloi == DialogResult.Yes)
            {
                QuanLyKTX.Instance.SaveAllData(); // Lưu dữ liệu trước khi đăng xuất
                Application.Restart(); // Khởi động lại ứng dụng
                Environment.Exit(0);   // Đảm bảo đóng hoàn toàn luồng cũ
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
