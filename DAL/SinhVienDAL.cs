using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAL
{
    internal class SinhVienDAL
    {
        // Load dữ liệu từ file
        public List<SinhVien> LoadSinhVienTuFile(string filePath)
        {
            List<SinhVien> ds = new List<SinhVien>();

            try
            {
                // Xác định file SinhVien1.txt
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);

                string file1 = Path.Combine(directory ?? "", fileName + "1" + extension);

                string fileToRead = filePath;

                // Ưu tiên file SinhVien1.txt nếu tồn tại và KHÔNG rỗng
                if (File.Exists(file1))
                {
                    var lines1 = File.ReadAllLines(file1, Encoding.UTF8);
                    if (lines1.Length > 0)
                    {
                        fileToRead = file1;
                    }
                }

                // Nếu file được chọn không tồn tại → trả danh sách rỗng
                if (!File.Exists(fileToRead))
                    return ds;

                var lines = File.ReadAllLines(fileToRead, Encoding.UTF8);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        var parts = line.Split(';');
                        if (parts.Length < 5) continue;

                        bool gioiTinh = parts[4].Trim().ToLower() == "nam";

                        DateTime ngaySinh;
                        try
                        {
                            ngaySinh = DateTime.ParseExact(
                                parts[2].Trim(),
                                "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            ngaySinh = DateTime.Parse(parts[2].Trim());
                        }

                        ds.Add(new SinhVien
                        {
                            HoTen = parts[0].Trim(),
                            MaSV = parts[1].Trim(),
                            NgaySinh = ngaySinh,
                            SoDienThoai = parts[3].Trim(),
                            GioiTinh = gioiTinh,
                            AnhDaiDien = parts.Length >= 6 ? parts[5].Trim() : ""
                        });
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch
            {
                // giữ im lặng nếu lỗi
            }

            return ds;
        }

        // Lưu dữ liệu vào file có số 1
        public void SaveSinhVienToFile(string filePath, List<SinhVien> danhSach)
        {
            try
            {
                // Tạo tên file với số 1 (VD: SinhVien.txt -> SinhVien1.txt)
                string directory = Path.GetDirectoryName(filePath);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);

                string workingFileName = fileNameWithoutExt + "1" + extension;
                string workingFilePath = string.IsNullOrEmpty(directory)? workingFileName: Path.Combine(directory, workingFileName);

                List<string> lines = new List<string>();

                foreach (SinhVien sv in danhSach)
                {
                    string gioiTinh = sv.GioiTinh ? "Nam" : "Nu";
                    string ngaySinh = sv.NgaySinh.ToString("dd/MM/yyyy");
                    string anhDaiDien = sv.AnhDaiDien ?? "";

                    string line = $"{sv.HoTen};{sv.MaSV};{ngaySinh};{sv.SoDienThoai};{gioiTinh};{anhDaiDien}";
                    lines.Add(line);
                }

                File.WriteAllLines(workingFilePath, lines, Encoding.UTF8);
            }
            catch
            {
                // Bỏ qua lỗi
            }
        }
    }
}