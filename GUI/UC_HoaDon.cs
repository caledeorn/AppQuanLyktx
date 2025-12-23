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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
            
            clear();
            btnTimKiem.Enabled = false;
            LoadComboBoxPhong();
            setting_cbo(cboMaPhong);
            cboThuocTinh.Items.Add("Mã Hóa Đơn");
            cboThuocTinh.Items.Add("Mã Phòng");

        }
        private void LoadComboBoxPhong()
        {
            var listMaPhong = QuanLyKTX.Instance.QLPhong.danhSachPhong().Select(p => p.maPhong).ToList();

            cboMaPhong.DataSource = null;
            cboMaPhong.DataSource = listMaPhong;
            cboMaPhong.SelectedIndex = -1;

        }
        private void setting_cbo(ComboBox cbo)
        {
            cbo.FormattingEnabled = true;
            cbo.DropDownStyle = ComboBoxStyle.DropDown;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            loadData(dgvDanhSachHoaDon, QuanLyKTX.Instance.QLHoaDon.danhSachHoaDon());
        }
        private void ThietLapCot(DataGridView dgv, string tenBien, string tieuDe, int doRong)
        {
            if (dgv.Columns.Contains(tenBien))
            {
                dgv.Columns[tenBien].HeaderText = tieuDe;
                dgv.Columns[tenBien].Width = doRong;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHoaDon = groupBox2.Text;
            // Xử lý sửa hóa đơn theo mã hóa đơn
            int soDien;
            int soNuoc;
            if (!int.TryParse(txtSoDien.Text, out soDien))
            {
                lblThongBao.Text = "Lỗi: Số điện phải là một số nguyên!";
                txtSoDien.Focus(); // Đưa con trỏ chuột về ô lỗi
                lblThongBao.ForeColor = Color.Red;
                return; // Dừng hàm lại ngay, không chạy tiếp
            }
            if (!int.TryParse(txtSoNuoc.Text, out soNuoc))
            {
                lblThongBao.Text = "Lỗi: Số nước phải là một số nguyên!";
                lblThongBao.ForeColor = Color.Red;
                txtSoNuoc.Focus();
                return;
            }
            bool trangThai = cbThanhToan.Checked ? true : false;
            var result = QuanLyKTX.Instance.QLHoaDon.suaHoaDon(maHoaDon, soDien, soNuoc, trangThai);
            if (result == "Cập nhật hóa đơn thành công.")
            {
                lblThongBao.Text = result;
                loadData(dgvDanhSachHoaDon, QuanLyKTX.Instance.QLHoaDon.danhSachHoaDon());
                lblThongBao.ForeColor = Color.Green;
                dgvDanhSachTimKiem.Focus();
            }
            else
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string maPhong = cboMaPhong.Text;
            int soDien;
            int soNuoc;
            DateTime ngayLap = dtpNgay.Value;
            bool trangThai = cbThanhToan.Checked ? true : false;
            if (!int.TryParse(txtSoDien.Text, out soDien))
            {
                lblThongBao.Text = "Lỗi: Số điện phải là một số nguyên!";
                lblThongBao.ForeColor = Color.Red;
                txtSoDien.Focus(); // Đưa con trỏ chuột về ô lỗi
                return; // Dừng hàm lại ngay, không chạy tiếp
            }
            if (!int.TryParse(txtSoNuoc.Text, out soNuoc))
            {
                lblThongBao.Text = "Lỗi: Số nước phải là một số nguyên!";
                lblThongBao.ForeColor = Color.Red;
                txtSoNuoc.Focus();
                return;
            }
            var result = QuanLyKTX.Instance.QLHoaDon.taoHoaDon(maPhong, soDien, soNuoc, ngayLap, trangThai);
            if (result == "Thêm hóa đơn thành công.")
            {
                lblThongBao.Text = result;
                loadData(dgvDanhSachHoaDon, QuanLyKTX.Instance.QLHoaDon.danhSachHoaDon());
                lblThongBao.ForeColor = Color.Green;
                txtSoDien.Text = "";
                txtSoNuoc.Text= "";
                cboMaPhong.SelectedIndex = -1;

            }
            else
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Red;
            }
        }
        private void loadData(DataGridView dgv, List<HoaDon> hoaDon)
        {
            dgv.DataSource = null;
            dgv.DataSource = hoaDon;
            dgv.Columns["phong"].Visible = false;   
            ThietLapCot(dgv, "maHoaDon", "Mã Hóa Đơn", 100);
            ThietLapCot(dgv, "maPhong", "Mã Phòng", 100);
            ThietLapCot(dgv, "soDien", "Số Điện", 80);
            ThietLapCot(dgv, "soNuoc", "Số Nước", 80);
            ThietLapCot(dgv, "ngayLap", "Ngày Lập", 120);
            ThietLapCot(dgv, "trangThai", "Thanh Toán", 100);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = groupBox2.Text;
            // Xử lý xóa hóa đơn theo mã hóa đơn
            var result = QuanLyKTX.Instance.QLHoaDon.xoaHoaDon(maHoaDon);
            if (result == "Xóa hóa đơn thành công.")
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Green;
                loadData(dgvDanhSachHoaDon, QuanLyKTX.Instance.QLHoaDon.danhSachHoaDon());
            }
            else
            {
                lblThongBao.Text = result;
                lblThongBao.ForeColor = Color.Red;
            }
        }

        // Khai báo giá tiền (Nên để hằng số để dễ sửa sau này)
        private const int GIA_DIEN = 3000;
        private const int GIA_NUOC = 5000;

        private void TinhTongTienTuDong()
        {
            // 1. Kiểm tra và lấy giá trị Số Điện
            int soDien = 0;
            bool isDienHopLe = int.TryParse(txtSoDien.Text.Trim(), out soDien);

            // 2. Kiểm tra và lấy giá trị Số Nước
            int soNuoc = 0;
            bool isNuocHopLe = int.TryParse(txtSoNuoc.Text.Trim(), out soNuoc);

            // 3. Logic: Chỉ tính khi CẢ HAI đều là số và KHÔNG ÂM
            if (isDienHopLe && isNuocHopLe && soDien >= 0 && soNuoc >= 0)
            {
                // Tính toán
                decimal tongTien = (soDien * GIA_DIEN) + (soNuoc * GIA_NUOC);

                // Hiển thị ra Label Tổng tiền (Format dạng tiền tệ: 1.000.000)
                lblThanhTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
            else
            {
                // Nếu nhập sai hoặc chưa nhập đủ, có thể reset về 0 hoặc giữ nguyên
                lblThanhTien.Text = "0 VNĐ";

                // (Tùy chọn) Có thể hiện thông báo lỗi ngay tại đây nếu muốn
                // lblThongBao.Text = "Vui lòng nhập số nguyên dương!";
            }
        }
        private void txtSoDien_TextChanged(object sender, EventArgs e)
        {
            TinhTongTienTuDong();
        }

        private void txtSoNuoc_TextChanged(object sender, EventArgs e)
        {
            TinhTongTienTuDong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtThongTin.Text;
            string thuocTinh = cboThuocTinh.SelectedItem.ToString();
            if (string.IsNullOrEmpty(thuocTinh))
            {
                lblTBTK.Text = "Vui lòng chọn thuộc tính để tìm kiếm.";
                lblTBTK.ForeColor = Color.Red;
                cboThuocTinh.Focus();
                return;
            }
            var ketQua = QuanLyKTX.Instance.QLHoaDon.timKiemHoaDon(tuKhoa, thuocTinh);
            loadData(dgvDanhSachTimKiem, ketQua);
            lblTBTK.Text = $"Tìm thấy {ketQua.Count} hóa đơn.";
            lblTBTK.ForeColor = Color.Green;
        }
        private void clear()
        {
            groupBox2.Text = "";
            txtSoDien.Text = "";
            txtSoNuoc.Text = "";
            dtpNgay.Value = DateTime.Now;
            cbThanhToan.Checked = false;
            lblThanhTien.Text = "0 VNĐ";
            lblThongBao.Text = "";
            cboMaPhong.SelectedIndex = -1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnClear.Enabled = false;
            dtpNgay.Enabled = true;
            cboMaPhong.Enabled = true;
        }
        private void selectDataFromDGV(DataGridView dgv)
        {
            // Sửa: Kiểm tra CurrentRow thay vì SelectedRows
            if (dgv.CurrentRow != null)
            {
                // Sửa: Lấy CurrentRow
                DataGridViewRow row = dgv.CurrentRow;

                // Đoạn này giữ nguyên logic của bạn
                // Kiểm tra null để tránh lỗi nếu dòng đó chưa có dữ liệu object
                if (row.DataBoundItem != null)
                {
                    HoaDon hd = (HoaDon)row.DataBoundItem;
                    groupBox2.Text = hd.maHoaDon; // Ví dụ

                    // Xử lý cboMaPhong an toàn
                    if (hd.phong != null) cboMaPhong.Text = hd.phong.maPhong;

                    txtSoDien.Text = hd.soDien.ToString();
                    txtSoNuoc.Text = hd.soNuoc.ToString();
                    dtpNgay.Value = hd.ngayLap;
                    cbThanhToan.Checked = hd.trangThai;
                    txtSoDien.Focus();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    cboMaPhong.Enabled = false;
                    dtpNgay.Enabled = false;
                    btnClear.Enabled = true;
                    lblThongBao.Text = "";
                }
            }
            
        }
        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectDataFromDGV(dgvDanhSachHoaDon);

        }

        private void dgvDanhSachHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Chặn hành động mặc định (không cho nhảy xuống dòng dưới)
                e.SuppressKeyPress = true;
                selectDataFromDGV(dgvDanhSachHoaDon);
            }

        }

        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void btnChuaThanhToan_Click(object sender, EventArgs e)
        {
            var ketQua = QuanLyKTX.Instance.QLHoaDon.timKiemTheoTrangThai(false);
            loadData(dgvDanhSachTimKiem, ketQua);
            lblTBTK.Text = $"{ketQua.Count} hóa đơn chưa thanh toán.";
            lblTBTK.ForeColor = Color.Green;
        }



        private void dgvDanhSachTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                selectDataFromDGV(dgvDanhSachTimKiem);
            }
        }

        private void dgvDanhSachTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectDataFromDGV(dgvDanhSachTimKiem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
