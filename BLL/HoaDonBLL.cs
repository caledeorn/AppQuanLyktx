using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class HoaDonBLL
    {
        private List<HoaDon> _danhSachHoaDon;
        private HoaDonDAL hdRepo;
        public HoaDonBLL(HoaDonDAL repository, List<Phong> danhSachPhong)
        {
            hdRepo = repository;
            _danhSachHoaDon = hdRepo.LoadHoaDonTuFile("HoaDon.txt", danhSachPhong);
        }
        public List<HoaDon> danhSachHoaDon()
        {
            return _danhSachHoaDon;
        }
        public string taoHoaDon( string maPhong, int soDien, int soNuoc, DateTime ngayLap, bool trangThai)
        {
            if (string.IsNullOrWhiteSpace(maPhong))
                return "Lỗi: Mã phong không được để trống.";
            Phong phong = QuanLyKTX.Instance.QLPhong.timKiem(maPhong);
            string maHoaDon = $"{maPhong}{ngayLap:MMyy}";
            if (phong == null)
                return "Lỗi: Không tìm thấy phòng với mã đã cho.";
            if (timKiem(maHoaDon) != null)
                return "Lỗi: Hóa đơn cho phòng này trong tháng đã tồn tại.";
            if(soDien < 0)
                return "Lỗi: Số điện không được âm.";
            if(soNuoc < 0) 
                return "Lỗi: Số nước không được âm.";
            if(ngayLap > DateTime.Now)
                return "Lỗi: Ngày lập hóa đơn không được sau ngày hiện tại.";
            HoaDon hd = new HoaDon
            {
                maHoaDon = maHoaDon,
                phong = phong,
                soDien = soDien,
                soNuoc = soNuoc,
                ngayLap = ngayLap.Date,
                trangThai = trangThai
            };
            
            _danhSachHoaDon.Add(hd);
            return "Thêm hóa đơn thành công.";
        }
        public HoaDon timKiem(string maHoaDon)
        {
            return _danhSachHoaDon.FirstOrDefault(hd => hd.maHoaDon == maHoaDon);
        }
        public List<HoaDon> timKiemTheoTrangThai(bool trangThai)
        {
            return _danhSachHoaDon.Where(hd => hd.trangThai == trangThai).ToList();
        }
        public string capNhatTrangThai(string maHoaDon, bool trangThai)
        {
            var hd = timKiem(maHoaDon);
            if (hd == null)
            {
                return "Lỗi: Không tìm thấy hóa đơn với mã đã cho.";
            }
            hd.trangThai = trangThai;
            return "Cập nhật trạng thái hóa đơn thành công.";
        }
        public string xoaHoaDon(string maHoaDon)
        {
            var hd = timKiem(maHoaDon);
            if (hd == null)
            {
                return "Lỗi: Không tìm thấy hóa đơn với mã đã cho.";
            }
            _danhSachHoaDon.Remove(hd);
            return "Xóa hóa đơn thành công.";
        }
        public string suaHoaDon(string maHoaDon, int soDien, int soNuoc,bool trangThai)
        {
            var hd = timKiem(maHoaDon);
            if (hd == null)
            {
                return "Lỗi: Không tìm thấy hóa đơn với mã đã cho.";
            }
            if(soDien < 0)
                return "Lỗi: Số điện không được âm.";
            if(soNuoc < 0) 
                return "Lỗi: Số nước không được âm.";
            hd.soDien = soDien;
            hd.soNuoc = soNuoc;
            hd.trangThai = trangThai;
            return "Cập nhật hóa đơn thành công.";
        }
        public List<HoaDon> timKiemHoaDon(string tuKhoa, string thuocTinh)
        {
            var ketQua = new List<HoaDon>();
            if(string.IsNullOrWhiteSpace(tuKhoa))
            {
                return _danhSachHoaDon;
            }
            tuKhoa = tuKhoa.Trim().ToLower();
            switch (thuocTinh)
            {
                case "Mã Hóa Đơn":
                    ketQua = _danhSachHoaDon.Where(hd => hd.maHoaDon.ToLower().Contains(tuKhoa)).ToList();
                    break;
                case "Mã Phòng":
                    ketQua = _danhSachHoaDon.Where(hd => hd.phong.maPhong.ToLower().Contains(tuKhoa)).ToList();
                    break;
                default:
                    ketQua = _danhSachHoaDon;
                    break;
            }

            return ketQua;
        }
        public HoaDon timKiemHoaDonTheoMaPhong(string maPhong)
        {
            return _danhSachHoaDon.FirstOrDefault(hd => hd.phong.maPhong==maPhong);
        }
    }
}
