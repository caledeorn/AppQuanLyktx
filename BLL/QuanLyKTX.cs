using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WinFormsApp1.Model;
using WinFormsApp1.DAL;


namespace WinFormsApp1.BLL
{
    internal class QuanLyKTX
    {
        private static QuanLyKTX _instance;
        public static QuanLyKTX Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QuanLyKTX();
                return _instance;
            }
        }
        public SinhVienBLL QLSinhVien { get; private set; }
        public PhongBLL QLPhong { get; private set; }
        public HopDongBLL QLHopDong { get; private set; } 
        public HoaDonBLL QLHoaDon { get; private set; }
        public PhieuBaoHongBLL QLPhieuBaoHong { get; private set; }
        private QuanLyKTX()
        {
            // Tạo DAL

            var svRepo = new SinhVienDAL();
            var phongRepo = new PhongDAL();
            var hopDongRepo = new HopDongDAL();
            var hoaDonRepo = new HoaDonDAL();
            var phieuBaoHongRepo= new PhieuBaoHongDAL();
            // Tạo Service
            // Service SV và Phòng phải được tạo trước
            QLSinhVien = new SinhVienBLL(svRepo);
            QLPhong = new PhongBLL(phongRepo);

            // Service Hợp đồng cần biết về 2 service kia để liên kết
            QLHopDong = new HopDongBLL(hopDongRepo, QLSinhVien.danhSachSinhVien(), QLPhong.danhSachPhong());
            QLHoaDon = new HoaDonBLL(hoaDonRepo,QLPhong);
            QLPhieuBaoHong = new PhieuBaoHongBLL(phieuBaoHongRepo, QLSinhVien,QLPhong);
        }
        public List<SinhVien> sapXepSinhVien()
        {
            return QLSinhVien.sapXep(QLPhong);
        }
    }
}
