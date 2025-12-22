using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class CardThongTin : UserControl
    {
        public CardThongTin()
        {
            InitializeComponent();
        }

        public void setData(string maPhong, int soLuong,int tienPhong,bool gioiTinh,int soSinhVien,int soDonBaoHong)
        {
            lblMaPhong.Text = maPhong;
            lblSoLuong.Text += soLuong.ToString();
            lblTienPhong.Text += tienPhong.ToString();
            String gioiTinhStr = gioiTinh ? "Nam" : "Nữ";
            lblGioiTinh.Text += gioiTinh;
            lblSoSV.Text += soSinhVien.ToString();
            lblSoDBH.Text += soDonBaoHong.ToString();
        }
        
    }
}
