using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class HopDong
    {
        public SinhVien sv { get; set; }
        public Phong p { get; set; }
        public string MSSV
        {
            get { return sv.MaSV; }
        }
        public string MaPhong
        {
            get { return p.maPhong; }
        }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        
        public int tienPhong
        {
            get { return p.tienPhong; }
        }
        public HopDong(SinhVien sv, Phong p, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.sv = sv;
            this.p = p;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
        public HopDong()
        {
        }
        //public HopDong taoHopDong( SinhVien sv, Phong p, DateTime ngayBatDau, DateTime ngayKetThuc)
        //{
        //    if(p.themSV(sv) == false)
        //    {
        //        return null;
        //    }
        //    HopDong hd = new HopDong( sv, p, ngayBatDau, ngayKetThuc);
        //    return hd;
        //}
        
    }
}
