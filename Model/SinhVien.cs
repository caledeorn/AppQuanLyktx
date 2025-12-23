using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public bool GioiTinh { get; set; }
        public Phong? Phong { get; set; }
        // path to image relative to app folder (e.g. "Images\sv001.jpg")
        public string AnhDaiDien { get; set; }
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string soDienThoai, bool gioiTinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            GioiTinh = gioiTinh;
            AnhDaiDien = string.Empty;
        }
        public SinhVien() { AnhDaiDien = string.Empty; }
        public void addPhong(Phong p)
        {
            Phong = p;
        }
        public string GioiTinhHienThi
        {
            get
            {
                if (GioiTinh == true)
                {
                    return "Nam";
                }
                else
                {
                    return "Nữ";
                }
            }
        }
        public string MaPhong
        {
            get
            {
                if (Phong == null)
                    return "Chưa xếp phòng";

                return Phong.maPhong;
            }
        }
        
    }
}
