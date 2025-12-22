using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class PhongBLL
    {
        private List<Phong> _danhSachPhong;
        private PhongDAL phongRepo;
        public PhongBLL(PhongDAL repository)
        {
            phongRepo = repository;
            _danhSachPhong = phongRepo.LoadPhongTuFile("Phong.txt");
        }
        public List<Phong> danhSachPhong()
        {
            return _danhSachPhong;
        }
        public string themPhong(string maPhong, int soLuong, int donGia)
        {
            if (string.IsNullOrWhiteSpace(maPhong))
                return "Lỗi: Mã phòng không được để trống.";
            if (soLuong <= 0)
                return "Lỗi: Số lượng phải lớn hơn 0.";
            if (donGia <= 0)
                return "Lỗi: Đơn giá phải lớn hơn 0.";
            maPhong = maPhong.Trim();
            //if (lookupPhong.ContainsKey(maPhong))
            //{
            //    return "Lỗi: Mã phòng này đã tồn tại.";
            //}
            Phong p = new Phong
            {
                maPhong = maPhong,
                soLuong = soLuong,
                donGia = donGia
            };
            _danhSachPhong.Add(p);
            return "Thêm phòng thành công.";
        }
        public string xoaPhong(string maPhong)
        {
            var p = timKiem(maPhong);
            if (p == null)
            {
                return "Lỗi: Không tìm thấy phòng với mã đã cho.";
            }
            if (p.SoNguoiHienTai > 0)
            {
                return "Lỗi: Phòng đang có sinh viên, không thể xóa.";
            }
            _danhSachPhong.Remove(p);
            return "Xóa phòng thành công.";
        }
        public Phong timKiem(string maPhong)
        {
            var p = _danhSachPhong.FirstOrDefault(ph => ph.maPhong == maPhong);
            return p;
        }
        public string suaPhong(string maPhong, int soLuong, int donGia)
        {
            var p = timKiem(maPhong);
            if (p == null)
            {
                return "Lỗi: Không tìm thấy phòng với mã đã cho.";
            }
            if (soLuong < p.SoNguoiHienTai)
            {
                return "Lỗi: Số lượng mới nhỏ hơn số sinh viên hiện tại trong phòng.";
            }
            p.soLuong = soLuong;
            p.donGia = donGia;
            return "Sửa phòng thành công.";
        }
        public List<Phong> TimKiemPhong(string tuKhoa,string thuocTinh)
        {
            if (tuKhoa == null)
            {
                return _danhSachPhong;
            }
            tuKhoa = tuKhoa.Trim().ToLower();
            List<Phong> ketQua = new List<Phong>();
            switch (thuocTinh)
            {
                case "Mã Phòng":
                    ketQua = _danhSachPhong.Where(p => p.maPhong != null &&p.maPhong.ToLower().Contains(tuKhoa)).ToList();
                    break;
                case "Số giường":
                    if (int.TryParse(tuKhoa, out int soGiuong))
                    {
                        ketQua = _danhSachPhong.Where(p => p.soLuong == soGiuong).ToList();
                    }
                    break;
                case "Giới tính":
                    bool? gioiTinh = null;
                    if (tuKhoa == "nam") gioiTinh = true;
                    if (tuKhoa == "nữ" || tuKhoa == "nu") gioiTinh = false;

                    if (gioiTinh != null)
                    {
                        ketQua = _danhSachPhong.Where(p => p.SoNguoiHienTai > 0 &&p.gioiTinh == gioiTinh).ToList();
                    }
                    break;
                case "Số sinh viên":
                    if (int.TryParse(tuKhoa, out int soSV))
                    {
                        ketQua = _danhSachPhong.Where(p => p.SoNguoiHienTai == soSV).ToList();
                    }

                    break;
            }
            return ketQua;
        }
    }
}
