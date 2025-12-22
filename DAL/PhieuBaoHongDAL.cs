using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Them thu vien nay de dung File
using WinFormsApp1.BLL;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class PhieuBaoHongDAL
    {
        public List<PhieuBaoHong> LoadPhieuBaoHongTuFile(string filePath, SinhVienBLL QLSinhVien, PhongBLL QLPhong)
        {
            List<PhieuBaoHong> danhSachPhieuBaoHong = new List<PhieuBaoHong>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Không tìm thấy file: {filePath}");
                    return danhSachPhieuBaoHong;
                }
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    // Sua 8 thanh 9 vi them cot MaPhong
                    if (parts.Length < 9) continue;
                    PhieuBaoHong pbh = new PhieuBaoHong()
                    {
                        maPhieu = parts[0].Trim(),
                        sv = QLSinhVien.timKiem(parts[1].Trim()),
                        
                        phong = QLPhong.timKiem(parts[2].Trim()),

                        // Cac cot sau day lui index len 1
                        thietBi = parts[3].Trim(),
                        moTa = parts[4].Trim(),
                        phanHoi = parts[5].Trim(),
                        ngayBaoHong = DateTime.Parse(parts[6].Trim()),

                        // Cot 7 la DaTiepNhan, Cot 8 la DaXuLy (theo thu tu file)
                        daTiepNhan = parts[7].Trim().ToLower() == "true" || parts[7].Trim() == "1",
                        daXuLy = parts[8].Trim().ToLower() == "true" || parts[8].Trim() == "1"
                    };

                    danhSachPhieuBaoHong.Add(pbh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }

            return danhSachPhieuBaoHong;
        }
    }
}