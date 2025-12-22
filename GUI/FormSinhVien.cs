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
            loadDanhSach();
            loadThongBao();
            loadNhanThan();
        }
        private void loadDanhSach()
        {
            dgvDanhSach.Controls.Clear();
            dgvDanhSach.DataSource = sv.Phong.danhSachSV;
            dgvDanhSach.Columns["Phong"].Visible = false;
            dgvDanhSach.Columns["GioiTinh"].Visible = false;
            dgvDanhSach.Columns["GioiTinhHienThi"].Visible = false;
            dgvDanhSach.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDanhSach.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvDanhSach.Columns["MaSV"].HeaderText = "Mã SV";
            dgvDanhSach.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDanhSach.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            // 1. Cho phép cột "HoTen" tự xuống dòng khi chữ quá dài
            // Lưu ý: Chữ "HoTen" trong ngoặc phải đúng y hệt tên cột (Name) hoặc DataPropertyName bạn đặt
            dgvDanhSach.Columns["HoTen"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 2. Bắt buộc hàng phải tự giãn chiều cao để chứa đủ chữ (QUAN TRỌNG)
            dgvDanhSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
                uc.setData(tb.ngayBaoHong, trangThai, tb.moTa, tb.phanHoi);
                flpThongBao.Controls.Add(uc);
            }
        }
        private void loadNhanThan()
        {
            groupBox1.Controls.Clear();
            UCNhanThan uc = new UCNhanThan();
            uc.setData(sv.HoTen, sv.MaSV, sv.Phong.maPhong, sv.SoDienThoai, sv.GioiTinh, sv.NgaySinh, QuanLyKTX.Instance.QLHopDong.timKiemHopDongTheoMaSV(sv.MaSV).ngayKetThuc);
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
            string thietBi = txtThietBi.Text;
            string moTa = txtMoTa.Text;
            DateTime ngayLap = DateTime.Now.Date;
            if (txtThietBi.Text == "")
            {
                lblThongbao.Text = "Thiết bị không được để trống.";
                lblThongbao.ForeColor = Color.Red;
                txtThietBi.Focus();
                return;
            }
            else if (txtMoTa.Text == "")
            {
                lblThongbao.Text = "Mô tả không được để trống.";
                lblThongbao.ForeColor = Color.Red;
                txtMoTa.Focus();
                return;
            }
            QuanLyKTX.Instance.QLPhieuBaoHong.taoPhieuBaoHong(sv, thietBi, moTa, ngayLap);
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
                Application.Restart(); // Khởi động lại ứng dụng
                Environment.Exit(0);   // Đảm bảo đóng hoàn toàn luồng cũ
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
