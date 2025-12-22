using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Phong
    {
        internal int tienPhong;

        // Dùng thuộc tính public { get; set; }
        public string maPhong { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public List<SinhVien> danhSachSV { get; set; } = new List<SinhVien>();
        public bool gioiTinh { get; set; } // true: nam, false: nu
        public Phong(string maPhong, string moTa, int soLuong, int donGia)
        {
            this.maPhong = maPhong;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public Phong() { }
        public int SoNguoiHienTai { get { return danhSachSV.Count; } }
        public bool themSV(SinhVien sv)
        {
            if (SoNguoiHienTai == 0)
            {
                gioiTinh = sv.GioiTinh;
            }
            if (SoNguoiHienTai < soLuong && gioiTinh == sv.GioiTinh)
            {
                danhSachSV.Add(sv);
                sv.addPhong(this);
                return true;
            }
            return false;
        }
        public bool xoaSV(SinhVien sv)
        {
            if (danhSachSV.Remove(sv))
            {
                sv.Phong = null;
                return true;
            }
            return false;
        }
    }
}
