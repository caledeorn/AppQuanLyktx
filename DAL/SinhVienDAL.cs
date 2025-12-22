using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class SinhVienDAL
    {
        public List<SinhVien> LoadSinhVienTuFile(string filePath)
        {
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Không tìm thấy file: {filePath}");
                    return danhSachSinhVien;
                }
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    if (parts.Length < 5) continue;
                    bool gioiTinh = false;
                    string gtRaw = parts[4].Trim().ToLower();
                    // chuyển đổi linh hoạt giữa text và số
                    if (gtRaw == "nam" || gtRaw == "1" || gtRaw == "true")
                        gioiTinh = true;
                    SinhVien sv = new SinhVien
                    {
                        MaSV = parts[1].Trim(),
                        HoTen = parts[0].Trim(),
                        NgaySinh = DateTime.Parse(parts[2].Trim()),
                        SoDienThoai = parts[3].Trim(),
                        GioiTinh = gioiTinh
                    };
                    danhSachSinhVien.Add(sv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            return danhSachSinhVien;
        }
    }
}
