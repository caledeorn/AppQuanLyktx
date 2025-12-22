using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class PhieuBaoHong
    {
        public string maPhieu { get; set; }
        public SinhVien sv { get; set; }
        public Phong phong { get; set; }
        public string thietBi { get; set; }
        public string moTa { get; set; }
        public string phanHoi { get; set; }
        public DateTime ngayBaoHong { get; set; }
        public bool daXuLy { get; set; }
        public bool daTiepNhan{ get; set; }
        public PhieuBaoHong()
        {
            
        }
    }
}
