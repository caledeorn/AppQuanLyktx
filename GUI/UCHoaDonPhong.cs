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
    public partial class UCHoaDonPhong : UserControl
    {
        public UCHoaDonPhong()
        {
            InitializeComponent();
        }
        public void setData(string maPhong, DateTime ngayLap,int soDien,int soNuoc,bool trangThai)
        {
            lblMaPhong.Text += " " + maPhong;
            lblNgay.Text += " " + ngayLap.ToString("dd/MM/yyyy");
            lblSoDien.Text += " " + soDien.ToString() + " kWh";
            lblSoNuoc.Text += " " + soNuoc.ToString() + " m³";
            lblTrangThai.Text += " " + (trangThai ? "Đã thanh toán" : "Chưa thanh toán");
            lblThanhTien.Text += " " + (soDien * 3000 + soNuoc * 5000).ToString("N0") + " VND";
        }
    }
}
