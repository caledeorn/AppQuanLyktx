using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class SinhVienBLL
    {
        private List<SinhVien> _danhSachSinhVien;
        private SinhVienDAL svRepo;
        public SinhVienBLL(SinhVienDAL repository)
        {
            svRepo = repository;
            _danhSachSinhVien = svRepo.LoadSinhVienTuFile("SinhVien.txt");
        }
        public List<SinhVien> danhSachSinhVien()
        {
            return _danhSachSinhVien;
        }
        public string themSinhVien(string maSV, string hoTen, DateTime ngaySinh,string SDT,bool gioiTinh)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return "Lỗi: Mã SV không được để trống.";
            if (string.IsNullOrWhiteSpace(hoTen))
                return "Lỗi: Tên không được để trống.";

            maSV = maSV.Trim();
            //if (lookupSinhVien.ContainsKey(maSV))
            //{
            //    return "Lỗi: Mã sinh viên này đã tồn tại.";
            //}

            SinhVien sv = new SinhVien
            {
                MaSV = maSV,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                SoDienThoai = SDT,
                GioiTinh = gioiTinh
            };
            _danhSachSinhVien.Add(sv);
            // Save to file
            //svRepo.SaveSinhVienToFile("SinhVien.txt", _danhSachSinhVien);
            return "Thêm sinh viên thành công.";
        }
        public string CapNhatAnhSinhVien(string maSV, string anhDuongDan)
        {
            var sv = _danhSachSinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv == null) return "Lỗi: Không tìm thấy sinh viên.";
            sv.AnhDaiDien = anhDuongDan ?? string.Empty;
            //svRepo.SaveSinhVienToFile("SinhVien.txt", _danhSachSinhVien);
            return "Cập nhật ảnh thành công.";
        }
        public string xoaSinhVien(string maSV)
        {
            var sv = _danhSachSinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv == null)
            {
                return "Lỗi: Không tìm thấy sinh viên với mã đã cho.";
            }
            if (sv.Phong != null)
            {
                return "Lỗi: Sinh viên đang có phòng, không thể xóa.";
            }

            _danhSachSinhVien.Remove(sv);
            //svRepo.SaveSinhVienToFile("SinhVien.txt", _danhSachSinhVien);
            return "Xóa sinh viên thành công.";

        }
        public string suaSinhVien(string maSV, string hoTen, DateTime ngaySinh, string SDT, bool gioiTinh)
        {
            var sv = _danhSachSinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv == null)
            {
                return "Lỗi: Không tìm thấy sinh viên với mã đã cho.";
            }
            
            if (string.IsNullOrWhiteSpace(hoTen))
                return "Lỗi: Tên không được để trống.";

            sv.HoTen = hoTen;
            sv.NgaySinh = ngaySinh;
            sv.SoDienThoai = SDT;
            sv.GioiTinh = gioiTinh;
            //svRepo.SaveSinhVienToFile("SinhVien.txt", _danhSachSinhVien);
            return "Sửa sinh viên thành công.";
        }
        public List<SinhVien> sapXep(PhongBLL QLPhong)
        {
            List<SinhVien> ListSV = new List<SinhVien>();
            foreach (var phong in QLPhong.danhSachPhong())
            {
                SapXepTheoTen_InsertionSort(phong.danhSachSV);
                
                ListSV.AddRange(phong.danhSachSV);
            }
            return ListSV;
        }
        public static void SapXepTheoTen_InsertionSort(List<SinhVien> ds)
        {
            for (int i = 1; i < ds.Count; i++)
            {
                SinhVien key = ds[i];
                string tenKey = LayTen(key.HoTen);

                int j = i - 1;
                while (j >= 0 && string.Compare(LayTen(ds[j].HoTen), tenKey, StringComparison.CurrentCulture) > 0)
                {
                    ds[j + 1] = ds[j];
                    j--;
                }
                ds[j + 1] = key;
            }
        }
        public List<SinhVien> timKiemSinhVien(string tuKhoa, string tieuChi)
        {
            // 1. Nếu không nhập gì thì trả về danh sách gốc (hoặc rỗng tùy bạn)
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return _danhSachSinhVien;
            }

            // 2. Chuẩn hóa dữ liệu: Chuyển về chữ thường + Xóa khoảng trắng thừa
            // Để gõ "  nam  " vẫn tìm ra "Nam"
            tuKhoa = tuKhoa.Trim().ToLower();

            List<SinhVien> ketQua = new List<SinhVien>();

            // 3. Lọc theo tiêu chí người dùng chọn trong ComboBox
            switch (tieuChi)
            {
                case "Tên":
                    // Tìm gần đúng (Contains) trong Họ Tên
                    ketQua = _danhSachSinhVien.Where(sv => sv.HoTen.ToLower().Contains(tuKhoa)).ToList();
                    break;

                case "Mã SV":
                    ketQua = _danhSachSinhVien.Where(sv => sv.MaSV.ToLower().Contains(tuKhoa)).ToList();
                    break;

                case "Số điện thoại":
                    // Cần kiểm tra null vì có thể sinh viên chưa có SĐT
                    ketQua = _danhSachSinhVien.Where(sv => sv.SoDienThoai != null && sv.SoDienThoai.Contains(tuKhoa)).ToList();
                    break;

                case "Giới tính":
                    // Xử lý thông minh: Người dùng gõ "nam" -> tìm true, "nữ" -> tìm false
                    // (Giả sử trong Model, GioiTinh là bool: true = Nam, false = Nữ)
                    bool timNam = tuKhoa.Contains("nam");
                    bool timNu = tuKhoa.Contains("nữ") || tuKhoa.Contains("nu");

                    if (timNam)
                        ketQua = _danhSachSinhVien.Where(sv => sv.GioiTinh == true).ToList();
                    else if (timNu)
                        ketQua = _danhSachSinhVien.Where(sv => sv.GioiTinh == false).ToList();
                    break;

                case "Ngày sinh":
                    // Mẹo: Chuyển ngày sinh sang chuỗi dd/MM/yyyy rồi so sánh chuỗi
                    // Ví dụ: gõ "2003" sẽ ra hết người sinh năm 2003
                    ketQua = _danhSachSinhVien.Where(sv => sv.NgaySinh.ToString("dd/MM/yyyy").Contains(tuKhoa)).ToList();
                    break;

                case "Phòng":
                    // Tìm theo tên phòng (Lưu ý kiểm tra sv.Phong != null để không bị lỗi crash)
                    ketQua = _danhSachSinhVien.Where(sv => sv.Phong != null && sv.Phong.maPhong.ToLower().Contains(tuKhoa)).ToList();
                    break;

                default:
                    // Mặc định tìm theo Tên nếu tiêu chí lạ
                    ketQua = _danhSachSinhVien.Where(sv => sv.HoTen.ToLower().Contains(tuKhoa)).ToList();
                    break;
            }

            return ketQua;
        }
        public SinhVien timKiem(string maSV)
        {
            return _danhSachSinhVien.FirstOrDefault(s => s.MaSV == maSV);
        }
        private static string LayTen(string hoTen)
        {
            var parts = hoTen.Trim().Split(' ');
            return parts[parts.Length - 1];
        }

    }
}
