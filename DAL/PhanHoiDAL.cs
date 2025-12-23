using WinFormsApp1.Model;

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
    internal class PhanHoiDAL
    {
        public List<PhanHoi> LoadPhanHoiTuFile(string filePath, List<SinhVien> danhSachSinhVien, List<Phong> danhSachPhong)
        {
            List<PhanHoi> danhSachPhanHoi = new List<PhanHoi>();
            try
            {
                string working = GetWorkingFilePath(filePath);
                string pathToRead = File.Exists(working) ? working : filePath;
                if (!File.Exists(pathToRead))
                {
                    return danhSachPhanHoi;
                }
                var lines = File.ReadAllLines(pathToRead);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    // Expecting 9 columns: maPhieu;maSV;maPhong;thietBi;moTa;phanHoi;ngayBaoHong;daTiepNhan;daXuLy
                    if (parts.Length < 9) continue;

                    var maPhieu = parts[0].Trim();
                    var maSV = parts[1].Trim();
                    var maPhong = parts[2].Trim();
                    var thietBi = parts[3].Trim();
                    var moTa = parts[4].Trim();
                    var phanHoi = parts[5].Trim();
                    var ngayStr = parts[6].Trim();
                    var daTiepNhanStr = parts[7].Trim();
                    var daXuLyStr = parts[8].Trim();

                    // Safe lookups
                    var svObj = danhSachSinhVien.FirstOrDefault(sv=>sv.MaSV==maSV);
                    var phongObj = danhSachPhong?.FirstOrDefault(p => string.Equals(p.maPhong?.Trim(), maPhong, StringComparison.OrdinalIgnoreCase));

                    // Parse date safely
                    DateTime ngayBaoHong;
                    if (!DateTime.TryParse(ngayStr, out ngayBaoHong))
                    {
                        // fallback value or skip record; here we set MinValue
                        ngayBaoHong = DateTime.MinValue;
                    }

                    bool ParseBool(string s)
                    {
                        if (string.IsNullOrWhiteSpace(s)) return false;
                        s = s.Trim().ToLowerInvariant();
                        if (s == "1" || s == "true" || s == "yes" || s == "y") return true;
                        return false;
                    }

                    PhanHoi pbh = new PhanHoi()
                    {
                        maPhieu = maPhieu,
                        sv = svObj,
                        phong = phongObj,
                        loaiPhanHoi = thietBi,
                        noiDung = moTa,
                        phanHoi = phanHoi,
                        ngayBaoHong = ngayBaoHong,
                        daTiepNhan = ParseBool(daTiepNhanStr),
                        daXuLy = ParseBool(daXuLyStr)
                    };

                    danhSachPhanHoi.Add(pbh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }

            return danhSachPhanHoi;
        }

        // Save PhieuBaoHong list to working file
        public void SavePhieuBaoHongToFile(string filePath, List<PhanHoi> danhSach)
        {
            try
            {
                var lines = new List<string>();
                foreach (var p in danhSach)
                {
                    // maPhieu;maSV;maPhong;thietBi;moTa;phanHoi;ngayBaoHong;daTiepNhan;daXuLy
                    lines.Add($"{p.maPhieu};{p.sv?.MaSV};{p.phong?.maPhong};{p.loaiPhanHoi};{p.noiDung};{p.phanHoi};{p.ngayBaoHong:dd/MM/yyyy};{(p.daTiepNhan?1:0)};{(p.daXuLy?1:0)}");
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
                Console.WriteLine($"Lỗi khi ghi file PhieuBaoHong: {ex.Message}");
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
                string workingName = name + "1" + ext; // e.g. PhieuBaoHong -> PhieuBaoHong1.txt
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