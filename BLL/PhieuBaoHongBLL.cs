using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class PhieuBaoHongBLL
    {
        List<PhieuBaoHong> _phieuBaoHong;
        private PhieuBaoHongDAL PhieuBaoHongRepo;
        public PhieuBaoHongBLL(PhieuBaoHongDAL rerepository,SinhVienBLL QLSinhVien,PhongBLL QLPhong)
        {
            PhieuBaoHongRepo = rerepository;
            _phieuBaoHong = PhieuBaoHongRepo.LoadPhieuBaoHongTuFile("PhieuBaoHong.txt",QLSinhVien,QLPhong);
        }
        public List<PhieuBaoHong> danhSachPhieuBaoHong()
        {
            return _phieuBaoHong;
        }
        public string taoPhieuBaoHong(SinhVien sv,string thietBi,string moTa,DateTime ngayLap) {
            PhieuBaoHong pbh = new PhieuBaoHong
            {
                maPhieu = TaoMaPhieuTuDong(_phieuBaoHong.Count > 0 ? _phieuBaoHong.Max(p => p.maPhieu) : null),
                sv = sv,
                phong = sv.Phong,
                thietBi = thietBi,
                moTa = moTa,
                phanHoi = "Chưa có phản hồi",
                ngayBaoHong=ngayLap,
                daTiepNhan=false,
                daXuLy=false
            };
            _phieuBaoHong.Add(pbh);
            return "";
        }
        public string TaoMaPhieuTuDong(string maPhieuCuoiCung)
        {
            // Cấu hình tiền tố
            const string TIEN_TO = "PBH";

            // Trường hợp 1: Nếu chưa có dữ liệu nào (database rỗng)
            if (string.IsNullOrEmpty(maPhieuCuoiCung))
            {
                return "PBH001";
            }

            // Trường hợp 2: Đã có dữ liệu, lấy mã cuối cùng để tăng lên
            // maPhieuCuoiCung ví dụ là "PBH008"

            // Cắt bỏ phần "PBH", lấy phần số "008"
            string phanSoStr = maPhieuCuoiCung.Substring(TIEN_TO.Length);

            int soMoi = 0;
            // Chuyển "008" thành số 8 và cộng thêm 1
            if (int.TryParse(phanSoStr, out int soHienTai))
            {
                soMoi = soHienTai + 1;
            }

            // Ghép lại thành chuỗi, D3 nghĩa là đảm bảo luôn có 3 chữ số (VD: 9 -> 009)
            string maMoi = TIEN_TO + soMoi.ToString("D3");

            return maMoi;
        }
        public List<PhieuBaoHong> danhSachPhieuBaoHongChuaXuLy()
        {
            return _phieuBaoHong.Where(pbh => !pbh.daXuLy).ToList();
        }
        public PhieuBaoHong timKiem(string maPhieu)
        {
            return _phieuBaoHong.FirstOrDefault(pbh => pbh.maPhieu == maPhieu);
        }
        public List<PhieuBaoHong> timKiemTheoSinhVien(string maSV)
        {
            return _phieuBaoHong.Where(pbh => pbh.sv != null && pbh.sv.MaSV == maSV).ToList();
        }
        public List<PhieuBaoHong> timKiemTheoThietBi(string thietBi)
        {
            return _phieuBaoHong.Where(pbh => pbh.thietBi != null && pbh.thietBi.IndexOf(thietBi, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
        public List<PhieuBaoHong> timKiemTheoPhong(string maPhong)
        {
            return _phieuBaoHong.Where(pbh => pbh.phong != null && pbh.phong.maPhong == maPhong).ToList();
        }
        public List<PhieuBaoHong> timKiemTheoNgay(string ngay)
        {
            return _phieuBaoHong.Where(p => p.ngayBaoHong.ToString("dd/MM/yyyy").Contains(ngay)).ToList();
        }
        public List<PhieuBaoHong> danhSachMoi()
        {
            return _phieuBaoHong.Where(pbh => !pbh.daTiepNhan).ToList();
        }
    }
}
