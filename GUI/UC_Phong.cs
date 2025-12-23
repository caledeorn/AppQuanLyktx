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
using WinFormsApp1.GUI;

namespace WinFormsApp1.GUI
{
    public partial class UC_Phong : UserControl
    {
        public UC_Phong()
        {
            InitializeComponent();
            LoadDanhSachPhong(QuanLyKTX.Instance.QLPhong.danhSachPhong());
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            btnClear.Enabled = false;
            cboThuocTinh.Items.Add("Mã Phòng");
            cboThuocTinh.Items.Add("Số giường");
            cboThuocTinh.Items.Add("Giới tính");
            cboThuocTinh.Items.Add("Số sinh viên");
        }
        private void LoadDanhSachPhong(List<Phong> Phong)
        {
            flpDanhSachPhong.Controls.Clear();
            foreach (var phong in Phong)
            {
                CardPhong card = new CardPhong();
                card.setData(phong.maPhong, phong.SoNguoiHienTai, phong.soLuong, 0);
                card.OnSelect += (s, e) =>
                {
                    HienThiThongTinPhong(phong);
                    btnClear.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    txtMaPhong.Text = phong.maPhong;
                    txtSoLuong.Text = phong.soLuong.ToString();
                    txtDonGia.Text = phong.donGia.ToString();
                    lblThongbao.Text = "";
                    // gioiTinh is non-nullable bool in model
                    if (phong.gioiTinh)
                    {
                        radNam.Checked = true;
                        radNu.Checked = false;
                    }
                    else
                    {
                        radNu.Checked = true;
                        radNam.Checked = false;
                    }
                };
                flpDanhSachPhong.Controls.Add(card);
            }
        }
        private void HienThiThongTinPhong(Model.Phong phong)
        {
            lblDanhSach.Text = "Danh sách sinh viên";
            flpThongTin.Controls.Clear();
            CardThongTin card = new CardThongTin();
            card.setData(phong.maPhong, phong.soLuong, phong.donGia, phong.gioiTinh, phong.SoNguoiHienTai);
            flpThongTin.Controls.Add(card);
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = phong.danhSachSV;
            dgvDanhSach.Columns["NgaySinh"].Visible = false;
            dgvDanhSach.Columns["GioiTinh"].Visible = false;
            dgvDanhSach.Columns["Phong"].Visible = false;
            dgvDanhSach.Columns["GioiTinhHienThi"].Visible = false;
            dgvDanhSach.Columns["MaPhong"].Visible = false;
            dgvDanhSach.Columns["AnhDaiDien"].Visible = false;
            ThietLapCot(dgvDanhSach, "MaSV", "Mã Sv", 80);
            ThietLapCot(dgvDanhSach, "HoTen", "Họ và tên ", 150);
            ThietLapCot(dgvDanhSach, "SoDienThoai", "Số điện thoại ", 100);

            // Localize headers
            UIHelper.LocalizeDataGridView(dgvDanhSach);
        }
        private void ThietLapCot(DataGridView dgv, string tenBien, string tieuDe, int doRong)
        {
            if (dgv.Columns.Contains(tenBien))
            {
                dgv.Columns[tenBien].HeaderText = tieuDe;
                dgv.Columns[tenBien].Width = doRong;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong(QuanLyKTX.Instance.QLPhong.danhSachPhong());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string soLuongText = txtSoLuong.Text;
            string donGiaText = txtDonGia.Text;
            if (!int.TryParse(soLuongText, out int soLuong))
            {
                lblThongbao.Text = "Lỗi: Số lượng phải là một số nguyên hợp lệ.";
                txtDonGia.Focus();
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (!int.TryParse(donGiaText, out int donGia))
            {
                lblThongbao.Text = "Lỗi: Đơn giá phải là một số nguyên hợp lệ.";
                txtDonGia.Focus();
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            string ketQua = QuanLyKTX.Instance.QLPhong.themPhong(maPhong, soLuong, donGia);
            lblThongbao.Text = ketQua;
            if (ketQua.StartsWith("Thêm phòng thành công"))
            {
                lblThongbao.ForeColor = Color.Green;
                lblThongbao.Text = ketQua;
                txtMaPhong.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();
                radNam.Checked = true;
            }
        }
        private void clear()
        {
            txtMaPhong.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            radNam.Checked = true;
            btnClear.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            lblThongbao.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string soLuongText = txtSoLuong.Text;
            string donGiaText = txtDonGia.Text;
            if (!int.TryParse(soLuongText, out int soLuong))
            {
                lblThongbao.Text = "Lỗi: Số lượng phải là một số nguyên hợp lệ.";
                lblThongbao.ForeColor = Color.Red;
                txtSoLuong.Focus();
                return;
            }
            if (!int.TryParse(donGiaText, out int donGia))
            {
                lblThongbao.Text = "Lỗi: Đơn giá phải là một số nguyên hợp lệ.";
                lblThongbao.ForeColor = Color.Red;
                txtDonGia.Focus();
                return;
            }
            string result = QuanLyKTX.Instance.QLPhong.suaPhong(maPhong, soLuong, donGia);
            if (result.StartsWith("Sửa phòng thành công"))
            {
                lblThongbao.Text = result;
                lblThongbao.ForeColor = Color.Green;
                LoadDanhSachPhong(QuanLyKTX.Instance.QLPhong.danhSachPhong());
                clear();
            }
            else
            {
                lblThongbao.Text = result;
                lblThongbao.ForeColor = Color.Red;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string result = QuanLyKTX.Instance.QLPhong.xoaPhong(maPhong);
            if (result.StartsWith("Xóa phòng thành công"))
            {
                lblThongbao.Text = result;
                lblThongbao.ForeColor = Color.Green;
                LoadDanhSachPhong(QuanLyKTX.Instance.QLPhong.danhSachPhong());
                clear();
            }
            else
            {
                lblThongbao.Text = result;
                lblThongbao.ForeColor = Color.Red;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtText.Text;
            string thuocTinh = cboThuocTinh.SelectedItem.ToString();
            if(thuocTinh== "Số giường" || thuocTinh== "Số sinh viên")
            {
                if(!int.TryParse(timKiem, out int soLuong))
                {
                    lblTBTK.Text = "Lỗi: Vui lòng nhập số hợp lệ.";
                    txtText.Focus();
                    lblTBTK.ForeColor = Color.Red;
                    return;
                }
            }
            List<Phong> result= QuanLyKTX.Instance.QLPhong.TimKiemPhong(timKiem, thuocTinh);

            LoadDanhSachPhong(result);
            lblTBTK.Text = $"Tìm thấy {result.Count} phòng.";
            lblTBTK.ForeColor = Color.Green;
        }
        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }
    }
}
