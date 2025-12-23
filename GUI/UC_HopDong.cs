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
    public partial class UC_HopDong : UserControl
    {
        public UC_HopDong()
        {
            InitializeComponent();
            clear();
            btnTimKiem.Enabled = false;
            loadData(QuanLyKTX.Instance.QLHopDong.danhSachHopDong(), flpDanhSachHopDong);
            LoadComboBoxPhong();
            LoadComboBoxSinhVien();
            setting_cbo(cboMaPhong);
            setting_cbo(cboMaSV);
            cboThuocTInh.Items.Add("Mã Phòng");
            cboThuocTInh.Items.Add("Mã Sinh Viên");
            cboThuocTInh.Items.Add("Ngày Bắt Đầu");
            cboThuocTInh.Items.Add("Ngày Kết Thúc");
            cboThuocTInh.Items.Add("Tiền Phòng");
            cboThuocTInh.SelectedIndex = -1;

        }

        private void UC_HopDong_Load(object sender, EventArgs e)
        {


        }
        private void LoadComboBoxPhong()
        {
            var listMaPhong = QuanLyKTX.Instance.QLPhong.danhSachPhong().Select(p => p.maPhong).ToList();

            cboMaPhong.DataSource = null;
            cboMaPhong.DataSource = listMaPhong;
            cboMaPhong.SelectedIndex = -1;

        }
        private void LoadComboBoxSinhVien()
        {
            var listMaSV = QuanLyKTX.Instance.QLSinhVien.danhSachSinhVien().Select(sv => sv.MaSV).ToList();

            cboMaSV.DataSource = null;
            cboMaSV.DataSource = listMaSV;
            cboMaSV.SelectedIndex = -1;
        }
        private void setting_cbo(ComboBox cbo)
        {
            cbo.FormattingEnabled = true;
            cbo.DropDownStyle = ComboBoxStyle.DropDown;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void loadData(List<HopDong> HopDong, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            foreach (var hd in HopDong)
            {
                CardHopDong card = new CardHopDong();
                card.setData(hd.p.maPhong, hd.sv.MaSV, hd.ngayBatDau, hd.ngayKetThuc, hd.tienPhong);
                card.OnSelect += (s, e) =>
                {
                    btnClear.Enabled = true;
                    btnXoa.Enabled = true;
                    cboMaPhong.Enabled = false;
                    cboMaSV.Enabled = false;
                    cboMaPhong.Text = hd.p.maPhong;
                    cboMaSV.Text = hd.sv.MaSV;
                    lblTienPhong.Text = hd.tienPhong.ToString();
                    dtpNgayBD.Value = Convert.ToDateTime(hd.ngayBatDau);
                    dtpNgayKT.Value = Convert.ToDateTime(hd.ngayKetThuc);
                };
                flp.Controls.Add(card);
            }
        }
       
        private void clear()
        {
            btnXoa.Enabled = false;

            txtText.Text = string.Empty;
            cboMaPhong.SelectedIndex=-1;
            cboMaSV.SelectedIndex = -1;
            cboThuocTInh.SelectedIndex = -1;
            lblTienPhong.Text = string.Empty;
            dtpNgayBD.DataBindings.Clear();
            dtpNgayKT.DataBindings.Clear();


        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void cboMaPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblTienPhong.Text = "";
            string maPhong = cboMaPhong.SelectedItem.ToString();
            var p = QuanLyKTX.Instance.QLPhong.timKiem(maPhong);
            if (p != null)
            {

                lblTienPhong.Text += p.tienPhong.ToString();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            Phong phong = QuanLyKTX.Instance.QLPhong.timKiem(cboMaPhong.Text);
            SinhVien sinhvien = QuanLyKTX.Instance.QLSinhVien.timKiem(cboMaSV.Text);
            DateTime ngayBD = dtpNgayBD.Value;
            DateTime ngayKT = dtpNgayKT.Value;
            var result = QuanLyKTX.Instance.QLHopDong.themHopDong(sinhvien, phong, ngayBD, ngayKT);
            lblThongBao.Text = result;
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            string thuocTinh = cboThuocTInh.SelectedItem.ToString();
            if (thuocTinh == "")
            {
                lblTBTK.Text = "Vui lòng chọn thuộc tính để tìm kiếm.";

                return;
            }
            if (thuocTinh == "Tiền Phong")
            {
                if (!int.TryParse(text, out int tienPhong))
                {
                    lblTBTK.Text = "Lỗi: Vui lòng nhập số hợp lệ.";
                    lblTBTK.ForeColor = Color.Red;
                    txtText.Focus();
                    return;
                }
            }
            if (thuocTinh == "Ngày Bắt Đầu" || thuocTinh == "Ngày Kết Thúc")
            {
                if (!DateTime.TryParse(text, out DateTime date))
                {
                    lblTBTK.Text = "Lỗi: Vui lòng nhập ngày hợp lệ.";
                    lblTBTK.ForeColor = Color.Red;
                    txtText.Focus();
                    return;
                }
            }
            List<HopDong> result = QuanLyKTX.Instance.QLHopDong.timKiemHopDong(text, thuocTinh);
            lblTBTK.Text = $"Tìm thấy {result.Count} hợp đồng.";
            lblTBTK.ForeColor = Color.Green;
            loadData(result, flpTimKiem);

        }

        private void cboThuocTInh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.Text;
            if (maSV.Length < 0)
            {
                lblThongBao.Text = "Vui lòng nhập mã sinh viên để thao tác";
                
            }
            string result = QuanLyKTX.Instance.QLHopDong.xoaHopDong(maSV);
            if (result == "Xóa hợp đồng thành công.")
            {
                
                clear();
                lblThongBao.Text += result;
                lblThongBao.ForeColor = Color.Green;
                flpTimKiem.Focus();
            }
            else
            {
                lblThongBao.Text += result;
                lblThongBao.ForeColor = Color.Red;
            }
            loadData(QuanLyKTX.Instance.QLHopDong.danhSachHopDong(), flpDanhSachHopDong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData(QuanLyKTX.Instance.QLHopDong.danhSachHopDong(), flpDanhSachHopDong);
        }
    }
}
