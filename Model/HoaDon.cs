using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class HoaDon
    {
        public string maHoaDon {  get; set; }
        public Phong phong { get; set; }
        public int soDien {  get; set; }
        public int soNuoc { get; set; }
        public DateTime ngayLap { get; set; }
        public bool trangThai { get; set; } // true: da thanh toan, false: chua thanh toan
        public HoaDon()
        {
            
        }
    }
}
