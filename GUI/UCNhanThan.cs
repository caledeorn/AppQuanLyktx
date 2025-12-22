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
    public partial class UCNhanThan : UserControl
    {
        public UCNhanThan()
        {
            InitializeComponent();
        }
        public void setData(string hoTen,string MaSV, string maPhong, string soDienThoai,bool gioiTinh,DateTime ngaySinh, DateTime HopDong)
        {
            lblHoTen.Text+= " "+hoTen;
            lblMaSV.Text += " " + MaSV;
            if(maPhong==null || maPhong=="")
            {
                lblMaPhong.Text += " Chưa có phòng";
                lblHopDong.Text += " ";
            }
            else { 
                lblMaPhong.Text += " " + maPhong;
                lblHopDong.Text += " " + HopDong.ToString("dd/MM/yyyy");
        }
        lblSDT.Text += " " + soDienThoai;
            lblGioiTinh.Text += " " + (gioiTinh ? "Nam" : "Nữ");
            lblNgaySinh.Text += " " + ngaySinh.ToString("dd/MM/yyyy");

            
        }
    }
}
