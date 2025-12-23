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
    public partial class UC_PhanHoi : UserControl
    {
        public UC_PhanHoi()
        {
            InitializeComponent();
            loadPhieuBaoHong(QuanLyKTX.Instance.QLPhieuBaoHong.danhSachPhanHoi());
            clear();
            cboThuocTinh.Items.Add("Mã phòng");
            cboThuocTinh.Items.Add("Loại phản hồi");
            cboThuocTinh.Items.Add("Mã SV");
            cboThuocTinh.Items.Add("Ngày lập đơn");
            btnTimKiem.Enabled = false;
        }
        private void loadPhieuBaoHong(List<PhanHoi> phieuBaoHongs)
        {

            flpDanhSach.Controls.Clear();
            foreach (var pbh in phieuBaoHongs)
            {
                var card = new CardPhanHoi();
                string trangThai;
                if (pbh.daTiepNhan == false)
                    trangThai = "Chưa tiếp nhận";
                else if (pbh.daXuLy == false)
                {
                    trangThai = "Chưa xử lý";
                }
                else
                {
                    trangThai = "Đã xử lý";
                    card.setData(pbh.maPhieu, pbh.phong.maPhong, pbh.sv.MaSV, pbh.loaiPhanHoi, pbh.ngayBaoHong.ToString("dd/MM/yyyy"), trangThai);
                    flpDanhSach.Controls.Add(card);
                    card.OnSelect += (s, e) =>
                    {
                        groupBox4.Text = pbh.maPhieu;
                        lblMaPhong.Text = pbh.phong.maPhong;
                        lblMaSV.Text = pbh.sv.MaSV;
                        lblMoTa.Text = pbh.noiDung;
                        lblNgay.Text = pbh.ngayBaoHong.ToString("dd/MM/yyyy");
                        lblThietBi.Text = pbh.loaiPhanHoi;
                        if (pbh.daTiepNhan == false)
                            lblTrangThai.Text = "Chưa tiếp nhận";
                        else if (pbh.daXuLy == false)
                        {
                            lblTrangThai.Text = "Chưa xử lý";

                        }
                        else lblTrangThai.Text = "Đã xử lý";
                        txtPhanHoi.Text = pbh.phanHoi;
                        btnDaXuLy.Enabled = true;
                        btnXacNhan.Enabled = true;
                    };
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            var maPhieu = groupBox4.Text;
            var pbh = QuanLyKTX.Instance.QLPhieuBaoHong.timKiem(maPhieu);
            pbh.phanHoi = txtPhanHoi.Text;
            pbh.daTiepNhan = true;
            clear();
        }
        private void clear()
        {
            lblMaPhong.Text = "";
            lblMaSV.Text = "";
            lblMoTa.Text = "";
            lblNgay.Text = "";
            lblThietBi.Text = "";
            lblTrangThai.Text = "";
            txtPhanHoi.Text = "";
            btnXacNhan.Enabled = false;
            btnDaXuLy.Enabled = false;
        }
        private void btnDaXuLy_Click(object sender, EventArgs e)
        {
            var maPhieu = groupBox4.Text;
            var pbh = QuanLyKTX.Instance.QLPhieuBaoHong.timKiem(maPhieu);
            pbh.daXuLy = true;
            pbh.daTiepNhan = true;
            pbh.phanHoi = txtPhanHoi.Text;
            clear();
        }

        private void btnDonMoi_Click(object sender, EventArgs e)
        {
            var result = QuanLyKTX.Instance.QLPhieuBaoHong.danhSachMoi();
            loadPhieuBaoHong(result);
            lblThongbao.Text = $"Tìm thấy {result.Count} phiếu mới.";
            lblThongbao.ForeColor = Color.Green;
        }

        private void btnDonChuaGiaiQuyet_Click(object sender, EventArgs e)
        {
            var result = QuanLyKTX.Instance.QLPhieuBaoHong.danhSachPhanHoiChuaXuLy();
            loadPhieuBaoHong(result);
            lblThongbao.Text = $"Tìm thấy {result.Count} phiếu chưa xử lý.";
            lblThongbao.ForeColor = Color.Green;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string thongTin = txtThongTin.Text.Trim();
            string thuocTinh = cboThuocTinh.Text;

            // Reset màu chữ về mặc định (ví dụ màu đen) mỗi khi bấm tìm kiếm
            lblThongbao.ForeColor = Color.Black;

            // 1. Kiểm tra nếu ô tìm kiếm trống
            if (string.IsNullOrEmpty(thongTin))
            {
                var allList = QuanLyKTX.Instance.QLPhieuBaoHong.danhSachPhanHoi();
                loadPhieuBaoHong(allList);
                lblThongbao.Text = "Hiển thị toàn bộ danh sách.";
                lblThongbao.ForeColor = Color.Black;
                return;
            }

            List<PhanHoi> result = new List<PhanHoi>();

            switch (thuocTinh)
            {
                case "Mã phòng":
                    result = QuanLyKTX.Instance.QLPhieuBaoHong.timKiemTheoPhong(thongTin);
                    break;

                case "Loại phản hồi":
                    result = QuanLyKTX.Instance.QLPhieuBaoHong.timKiemTheoLoaiPhanHoi(thongTin);
                    break;

                case "Mã SV":
                    result = QuanLyKTX.Instance.QLPhieuBaoHong.timKiemTheoSinhVien(thongTin);
                    break;

                case "Ngày lập đơn":
                    // --- KIỂM TRA NGÀY ---
                    DateTime dateValue;
                    bool isDate = DateTime.TryParseExact(thongTin, "dd/MM/yyyy",
                                                         System.Globalization.CultureInfo.InvariantCulture,
                                                         System.Globalization.DateTimeStyles.None,
                                                         out dateValue);

                    if (!isDate)
                    {
                        // Hiển thị lỗi lên lblThongbao thay vì MessageBox
                        lblThongbao.ForeColor = Color.Red; // Đổi màu chữ sang đỏ cho nổi bật
                        lblThongbao.Text = "Định dạng ngày sai! Hãy nhập dd/MM/yyyy (VD: 15/12/2025)";
                        return; // Dừng lại ngay
                    }

                    result = QuanLyKTX.Instance.QLPhieuBaoHong.timKiemTheoNgay(thongTin);
                    break;

                default:
                    lblThongbao.ForeColor = Color.Red;
                    lblThongbao.Text = "Vui lòng chọn thuộc tính tìm kiếm!";
                    return;
            }

            // 5. Hiển thị kết quả
            loadPhieuBaoHong(result);

            // Nếu không tìm thấy kết quả nào
            if (result.Count == 0)
            {
                lblThongbao.Text = "Không tìm thấy kết quả nào.";
            }
            else
            {
                lblThongbao.Text = $"Tìm thấy {result.Count} kết quả.";
                lblThongbao.ForeColor = Color.Green;
            }

        }

        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }
    }
}
