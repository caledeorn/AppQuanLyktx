using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class VatChat
    {
        string maVatChat;
        string tenVatChat;
        Phong p;
        DateTime ngayNhap;
        string LichSuBaoTri;
        int donGia;
        public VatChat(string maVatChat, string tenVatChat, Phong p, DateTime ngayNhap, string lichSuBaoTri, int donGia)
        {
            this.maVatChat = maVatChat;
            this.tenVatChat = tenVatChat;
            this.p = p;
            this.ngayNhap = ngayNhap;
            LichSuBaoTri = lichSuBaoTri;
            this.donGia = donGia;
        }
    }
}
