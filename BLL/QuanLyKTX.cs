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
        public PhanHoiBLL QLPhieuBaoHong { get; private set; }

        // keep DAL references so we can save on logout
        private SinhVienDAL svRepo;
        private PhongDAL phongRepo;
        private HopDongDAL hopDongRepo;
        private HoaDonDAL hoaDonRepo;
        private PhanHoiDAL phieuBaoHongRepo;

        private QuanLyKTX()
        {
            // Tạo DAL

            svRepo = new SinhVienDAL();
            phongRepo = new PhongDAL();
            hopDongRepo = new HopDongDAL();
            hoaDonRepo = new HoaDonDAL();
            phieuBaoHongRepo= new PhanHoiDAL();
            // Tạo Service
            // Service SV và Phòng phải được tạo trước
            QLSinhVien = new SinhVienBLL(svRepo);
            QLPhong = new PhongBLL(phongRepo);

            // Service Hợp đồng cần biết về 2 service kia để liên kết
            QLHopDong = new HopDongBLL(hopDongRepo, QLSinhVien.danhSachSinhVien(), QLPhong.danhSachPhong());
            QLHoaDon = new HoaDonBLL(hoaDonRepo,QLPhong.danhSachPhong());
            QLPhieuBaoHong = new PhanHoiBLL(phieuBaoHongRepo, QLSinhVien.danhSachSinhVien(),QLPhong.danhSachPhong());
        }
        public List<SinhVien> sapXepSinhVien()
        {
            return QLSinhVien.sapXep(QLPhong);
        }

        // Save all in-memory data to working files (called on logout)
        public void SaveAllData()
        {
            try
            {
                // Save students
                try { svRepo.SaveSinhVienToFile("SinhVien.txt", QLSinhVien.danhSachSinhVien()); } catch { }
                // Save rooms
                try { phongRepo.SavePhongToFile("Phong.txt", QLPhong.danhSachPhong()); } catch { }
                // Save contracts
                try { hopDongRepo.SaveHopDongToFile("HopDong.txt", QLHopDong.danhSachHopDong()); } catch { }
                // Save invoices
                try { hoaDonRepo.SaveHoaDonToFile("HoaDon.txt", QLHoaDon.danhSachHoaDon()); } catch { }
                // Save repair tickets
                try { phieuBaoHongRepo.SavePhieuBaoHongToFile("PhieuBaoHong.txt", QLPhieuBaoHong.danhSachPhanHoi()); } catch { }
            }
            catch (Exception ex)
            {
                // swallow exceptions to avoid blocking logout; in production consider logging
                Console.WriteLine("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }
    }
}
