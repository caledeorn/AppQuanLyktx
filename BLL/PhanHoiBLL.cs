using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class PhanHoiBLL
    {
        List<PhanHoi> _phanHoi;
        private PhanHoiDAL PhanHoiRepo;
        public PhanHoiBLL(PhanHoiDAL rerepository,List<SinhVien> danhSachSinhVien,List<Phong> danhSachPhong)
        {
            PhanHoiRepo = rerepository;
            _phanHoi = PhanHoiRepo.LoadPhanHoiTuFile("PhanHoi.txt", danhSachSinhVien, danhSachPhong);
        }
        public List<PhanHoi> danhSachPhanHoi()
        {
            return _phanHoi;
        }
        public string taoPhanHoi(SinhVien sv,string loaiPhanHoi,string noiDung,DateTime ngayLap) {
            PhanHoi pbh = new PhanHoi
            {
                maPhieu = TaoMaPhieuTuDong(_phanHoi.Count > 0 ? _phanHoi.Max(p => p.maPhieu) : null),
                sv = sv,
                phong = sv.Phong,
                loaiPhanHoi = loaiPhanHoi,
                noiDung = noiDung,
                phanHoi = "Chưa có phản hồi",
                ngayBaoHong=ngayLap,
                daTiepNhan=false,
                daXuLy=false
            };
            _phanHoi.Add(pbh);
            return "";
        }
        public string TaoMaPhieuTuDong(string maPhieuCuoiCung)
        {
            // Cấu hình tiền tố
            const string TIEN_TO = "PH";

            // Trường hợp 1: Nếu chưa có dữ liệu nào (database rỗng)
            if (string.IsNullOrEmpty(maPhieuCuoiCung))
            {
                return "PH001";
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
        public List<PhanHoi> danhSachPhanHoiChuaXuLy()
        {
            return _phanHoi.Where(pbh => !pbh.daXuLy).ToList();
        }
        public PhanHoi timKiem(string maPhieu)
        {
            return _phanHoi.FirstOrDefault(pbh => pbh.maPhieu == maPhieu);
        }
        public List<PhanHoi> timKiemTheoSinhVien(string maSV)
        {
            return _phanHoi.Where(pbh => pbh.sv != null && pbh.sv.MaSV == maSV).ToList();
        }
        public List<PhanHoi> timKiemTheoLoaiPhanHoi(string loaiPhanHoi)
        {
            return _phanHoi.Where(pbh => pbh.loaiPhanHoi != null && pbh.loaiPhanHoi.IndexOf(loaiPhanHoi, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
        public List<PhanHoi> timKiemTheoPhong(string maPhong)
        {
            return _phanHoi.Where(pbh => pbh.phong != null && pbh.phong.maPhong == maPhong).ToList();
        }
        public List<PhanHoi> timKiemTheoNgay(string ngay)
        {
            return _phanHoi.Where(p => p.ngayBaoHong.ToString("dd/MM/yyyy").Contains(ngay)).ToList();
        }
        public List<PhanHoi> danhSachMoi()
        {
            return _phanHoi.Where(pbh => !pbh.daTiepNhan).ToList();
        }
    }
}
