using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class PhongDAL
    {
        // --- ĐÃ SỬA: Ưu tiên đọc file có đuôi "1" (File làm việc) ---
        public List<Phong> LoadPhongTuFile(string filePath)
        {
            List<Phong> danhSachPhong = new List<Phong>();
            try
            {
                // 1. Xác định đường dẫn file làm việc (VD: Phong1.txt)
                string working = GetWorkingFilePath(filePath);

                // 2. Quyết định đọc file nào: Ưu tiên file working, nếu không có thì đọc file gốc
                string pathToRead = File.Exists(working) ? working : filePath;

                // 3. Kiểm tra lần cuối xem file có tồn tại không
                if (!File.Exists(pathToRead))
                {
                    // Nếu muốn debug thì bật dòng này, WinForms thì nên comment lại
                    // Console.WriteLine($"Không tìm thấy file: {pathToRead}");
                    return danhSachPhong;
                }

                var lines = File.ReadAllLines(pathToRead);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    // Expect format: maPhong;soLuong;tienPhong (e.g. P101;4;1200000)
                    if (parts.Length < 3) continue;

                    var maPhong = parts[0].Trim();
                    if (!int.TryParse(parts[1].Trim(), out int soLuong)) continue;
                    if (!int.TryParse(parts[2].Trim(), out int tienPhong)) continue;

                    Phong p = new Phong
                    {
                        maPhong = maPhong,
                        soLuong = soLuong,
                        donGia = tienPhong
                    };

                    // Đoạn này giữ nguyên logic cũ của bạn (dùng Reflection để gán biến private nếu cần)
                    try
                    {
                        p.GetType().GetField("tienPhong", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)?.SetValue(p, tienPhong);
                    }
                    catch { }

                    danhSachPhong.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            return danhSachPhong;
        }

        // Save phong list to working file (name1.txt) using atomic replace
        public void SavePhongToFile(string filePath, List<Phong> danhSach)
        {
            try
            {
                var lines = new List<string>();
                foreach (var p in danhSach)
                {
                    // Format: maPhong;soLuong;donGia
                    lines.Add($"{p.maPhong};{p.soLuong};{p.donGia}");
                }

                // Luôn lưu vào file working (file có số 1)
                string working = GetWorkingFilePath(filePath);

                // Ghi thẳng vào file working (đơn giản hóa quy trình replace phức tạp nếu không cần thiết)
                // Hoặc giữ nguyên logic Replace an toàn như dưới đây:
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
                Console.WriteLine($"Lỗi khi ghi file phong: {ex.Message}");
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
                string workingName = name + "1" + ext; // e.g. Phong -> Phong1.txt
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