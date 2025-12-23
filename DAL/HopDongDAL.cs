using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using System.IO;

namespace WinFormsApp1.DAL
{
    internal class HopDongDAL
    {
        public List<HopDong> LoadHopDongTuFile(string filePath,List<SinhVien> danhSachSV,List<Phong> danhSachPhong)
        {
            List<HopDong> danhSachHopDong = new List<HopDong>();
            try
            {
                string working = GetWorkingFilePath(filePath);
                string pathToRead = File.Exists(working) ? working : filePath;
                if (!File.Exists(pathToRead))
                {
                    Console.WriteLine($"Không tìm thấy file: {pathToRead}");
                    return danhSachHopDong;
                }
                var lines = File.ReadAllLines(pathToRead);
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

        // Save hop dong list to working file
        public void SaveHopDongToFile(string filePath, List<HopDong> danhSach)
        {
            try
            {
                var lines = new List<string>();
                foreach (var hd in danhSach)
                {
                    // Format: maSV;maPhong;ngayBatDau;ngayKetThuc
                    lines.Add($"{hd.sv?.MaSV};{hd.p?.maPhong};{hd.ngayBatDau:dd/MM/yyyy};{hd.ngayKetThuc:dd/MM/yyyy}");
                }

                string working = GetWorkingFilePath(filePath);
                string temp = working + ".tmp";
                File.WriteAllLines(temp, lines, Encoding.UTF8);
                if (File.Exists(working))
                {
                    string backup = working + ".bak";
                    try
                    {
                        File.Replace(temp, working, backup, true);
                        if (File.Exists(backup)) File.Delete(backup);
                    }
                    catch
                    {
                        File.Delete(working);
                        File.Move(temp, working);
                    }
                }
                else
                {
                    File.Move(temp, working);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ghi file HopDong: {ex.Message}");
            }
        }

        private string GetWorkingFilePath(string originalFilePath)
        {
            if (string.IsNullOrWhiteSpace(originalFilePath)) return originalFilePath;
            try
            {
                string dir = Path.GetDirectoryName(originalFilePath);
                string name = Path.GetFileNameWithoutExtension(originalFilePath);
                string ext = Path.GetExtension(originalFilePath);
                string workingName = name + "1" + ext; // e.g. HopDong -> HopDong1.txt
                if (string.IsNullOrEmpty(dir))
                    return workingName;
                return Path.Combine(dir, workingName);
            }
            catch
            {
                return originalFilePath;
            }
        }
    }
}
