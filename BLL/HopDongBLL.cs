using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Model;

namespace WinFormsApp1.BLL
{
    internal class HopDongBLL
    {
        private List<HopDong> _danhSachHopDong;
        private HopDongDAL hdRepo;
        public HopDongBLL(HopDongDAL repository, List<SinhVien> danhSachSV, List<Phong> danhSachPhong)
        {
            hdRepo = repository;
            _danhSachHopDong = hdRepo.LoadHopDongTuFile("HopDong.txt", danhSachSV, danhSachPhong);
            foreach (var hd in _danhSachHopDong)
            {
                hd.sv.Phong = hd.p;
                hd.p.danhSachSV.Add(hd.sv);

            }
        }
        public List<HopDong> danhSachHopDong()
        {
            return _danhSachHopDong;
        }
        public string themHopDong(SinhVien sv, Phong p, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (p == null)
                return "Lỗi: Mã phòng không được để trống.";
            if (sv == null)
                return "Lỗi: Mã sinh viên không được để trống.";
            
            if (ngayKetThuc <= ngayBatDau)
                return "Lỗi: Ngày kết thúc phải sau ngày bắt đầu.";
            if(sv.Phong != null)
                return "Lỗi: Sinh viên đã có phòng.";
            if(p.SoNguoiHienTai >= p.soLuong)
                return "Lỗi: Phòng đã đầy.";
            //if (lookupHopDong.ContainsKey(maHopDong))
            //{
            //    return "Lỗi: Mã hợp đồng này đã tồn tại.";
            //}
            HopDong hd = new HopDong(sv, p, ngayBatDau, ngayKetThuc);
            p.themSV(sv);
            _danhSachHopDong.Add(hd);
            return "Thêm hợp đồng thành công.";
        }
        public SinhVien timKiem(string maSV)
        {
            var hd = _danhSachHopDong.FirstOrDefault(h => h.sv.MaSV == maSV);
            if (hd != null)
            {
                return hd.sv;
            }
            return null;
        }
        public string xoaHopDong(string maSV)
        {
            var hd = _danhSachHopDong.FirstOrDefault(h => h.sv.MaSV == maSV);
            if (hd == null)
            {
                return "Lỗi: Không tìm thấy hợp đồng với mã sinh viên đã cho.";
            }
            hd.p.xoaSV(hd.sv);
            _danhSachHopDong.Remove(hd);
            return "Xóa hợp đồng thành công.";
        }
        public List<HopDong> danhSachHopDongHetHan(DateTime ngayHienTai)
        {
            return _danhSachHopDong.Where(hd => hd.ngayKetThuc < ngayHienTai).ToList();
        }
        public List<HopDong> danhSachHopDongSapHetHan(DateTime ngayHienTai, int soNgayCanhBao)
        {
            DateTime ngayCanhBao = ngayHienTai.AddDays(soNgayCanhBao);
            return _danhSachHopDong.Where(hd => hd.ngayKetThuc >= ngayHienTai && hd.ngayKetThuc <= ngayCanhBao).ToList();
        }
        public List<HopDong> timKiemHopDong(string tuKhoa,string thuocTinh)
        {
            var result = new List<HopDong>();
            tuKhoa = tuKhoa.Trim().ToLower();
            if(tuKhoa == "")
            {
                return _danhSachHopDong;
            }
            switch (thuocTinh)
            {
                case "Mã Sinh Viên":
                    result = _danhSachHopDong.Where(hd => hd.sv.MaSV.ToLower().Contains(tuKhoa)).ToList();
                    break;
                case "Mã Phòng":
                    result = _danhSachHopDong.Where(hd => hd.p.maPhong.ToLower().Contains(tuKhoa)).ToList();
                    break;
                case "Ngày Bắt Đầu":
                    if (DateTime.TryParse(tuKhoa, out DateTime ngayBD))
                    {
                        result = _danhSachHopDong.Where(hd => hd.ngayBatDau.Date == ngayBD.Date).ToList();
                    }
                    break;
                case "Ngày Kết Thúc":
                    if (DateTime.TryParse(tuKhoa, out DateTime ngayKT))
                    {
                        result = _danhSachHopDong.Where(hd => hd.ngayKetThuc.Date == ngayKT.Date).ToList();
                    }
                    break;
                case "Tiền Phòng":
                    if (decimal.TryParse(tuKhoa, out decimal tienPhong))
                    {
                        result = _danhSachHopDong.Where(hd => hd.tienPhong == tienPhong).ToList();
                    }
                    break;
            }
            return result;
        }
        public HopDong timKiemHopDongTheoMaSV(string maSV)
        {
            return _danhSachHopDong.FirstOrDefault(hd => hd.sv.MaSV == maSV);
        }

    }
}
