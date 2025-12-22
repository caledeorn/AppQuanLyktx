using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class HopDongDAL
    {
        public List<HopDong> LoadHopDongTuFile(string filePath,List<SinhVien> danhSachSV,List<Phong> danhSachPhong)
        {
            List<HopDong> danhSachHopDong = new List<HopDong>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Không tìm thấy file: {filePath}");
                    return danhSachHopDong;
                }
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    if (parts.Length < 4) continue;
                    string maSV = parts[0].Trim();
                    string maPhong = parts[1].Trim();
                    DateTime ngayBatDau = DateTime.Parse(parts[2].Trim()); 
                    DateTime ngayKetThuc = DateTime.Parse(parts[3].Trim());
                    SinhVien sv = danhSachSV.FirstOrDefault(s => s.MaSV.Trim() == maSV);
                    Phong p = danhSachPhong.FirstOrDefault(ph => ph.maPhong.Trim() == maPhong);
                    if (sv != null && p != null)
                    {
                        HopDong hd = new HopDong( sv, p, ngayBatDau, ngayKetThuc);
                        danhSachHopDong.Add(hd);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            return danhSachHopDong;
        }

    }
}
