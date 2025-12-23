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
        public void setData(string hoTen,string MaSV, string maPhong, string soDienThoai,bool gioiTinh,DateTime ngaySinh, DateTime HopDong,string anhDaiDien)
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
            picAnh.Image?.Dispose();
            picAnh.Image = null;
            picAnh.Tag = null;

            if (!string.IsNullOrWhiteSpace(anhDaiDien))
            {
                string fullPath = Path.Combine( Application.StartupPath,anhDaiDien.TrimStart('\\', '/'));

                if (File.Exists(fullPath))
                {
                    // Cách an toàn: FromFile + Dispose ảnh cũ
                    picAnh.Image = Image.FromFile(fullPath);
                    picAnh.Tag = anhDaiDien;
                }
            }

        }
    }
}
