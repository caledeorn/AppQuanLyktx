using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class PhongDAL
    {
        public List<Phong> LoadPhongTuFile(string filePath)
        {
            List<Phong> danhSachPhong = new List<Phong>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Không tìm thấy file: {filePath}");
                    return danhSachPhong;
                }
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    if (parts.Length < 3) continue;
                    Phong p = new Phong
                    {
                        maPhong = parts[0].Trim(),
                        soLuong = int.Parse(parts[1].Trim()),
                        donGia = int.Parse(parts[2].Trim())
                    };
                    danhSachPhong.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            return danhSachPhong;
        }
       
    }
}
