using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.BLL;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class HoaDonDAL
    {
        

        public List<HoaDon> LoadHoaDonTuFile(string filePath,PhongBLL QLPhong)
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Không tìm thấy file: {filePath}");
                    return danhSachHoaDon;
                }
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    if (parts.Length < 6) continue;
                    bool TrangThai = false;
                    if (parts[5].Trim().ToLower() == "true" || parts[5].Trim() == "1")
                        TrangThai = true;
                    HoaDon hoaDon = new HoaDon
                    {
                        maHoaDon = parts[0].Trim(),
                        phong = QLPhong.timKiem(parts[1].Trim()),
                        soDien = int.Parse(parts[2].Trim()),
                        soNuoc = int.Parse(parts[3].Trim()),
                        ngayLap = DateTime.Parse(parts[4].Trim()),
                        trangThai = TrangThai
                    } ;
                    danhSachHoaDon.Add(hoaDon);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            return danhSachHoaDon;
        }
    }
}
