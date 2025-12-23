using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.BLL;
using WinFormsApp1.Model;
using System.IO;

namespace WinFormsApp1.DAL
{
    internal class HoaDonDAL
    {
        public List<HoaDon> LoadHoaDonTuFile(string filePath,List<Phong> danhSachPhong) 
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            try
            {
                string working = GetWorkingFilePath(filePath);

                // If working file missing, copy original -> working so we always load from working file
                EnsureWorkingFileExists(filePath, working);

                string pathToRead = File.Exists(working) ? working : filePath;
                if (!File.Exists(pathToRead))
                {
                    Console.WriteLine($"Không tìm thấy file: {pathToRead}");
                    return danhSachHoaDon;
                }
                var lines = File.ReadAllLines(pathToRead);
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
                        phong = danhSachPhong.FirstOrDefault(ph => ph.maPhong == parts[1].Trim()),
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

        // Save hoa don to working file
        public void SaveHoaDonToFile(string filePath, List<HoaDon> danhSach)
        {
            try
            {
                var lines = new List<string>();
                foreach (var hd in danhSach)
                {
                    // Format: maHoaDon;maPhong;soDien;soNuoc;ngayLap;trangThai
                    lines.Add($"{hd.maHoaDon};{hd.phong?.maPhong};{hd.soDien};{hd.soNuoc};{hd.ngayLap:dd/MM/yyyy};{(hd.trangThai?1:0)}");
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
                Console.WriteLine($"Lỗi khi ghi file HoaDon: {ex.Message}");
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
                string workingName = name + "1" + ext; // e.g. HoaDon -> HoaDon1.txt
                if (string.IsNullOrEmpty(dir))
                    return workingName;
                return Path.Combine(dir, workingName);
            }
            catch
            {
                return originalFilePath;
            }
        }

        private void EnsureWorkingFileExists(string original, string working)
        {
            try
            {
                if (File.Exists(working)) return;
                if (File.Exists(original))
                {
                    File.Copy(original, working);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo file làm việc: {ex.Message}");
            }
        }
    }
}
