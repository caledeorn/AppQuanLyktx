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
    public partial class UCThongBao : UserControl
    {
        public UCThongBao()
        {
            InitializeComponent();
        }

        public void setData(DateTime ngay, string trangThai,string noiDung,string phanHoi)
        {
            lblNgay.Text += ngay.ToString("dd/MM/yyyy");
            lblTrangThai.Text += trangThai;
            lblNoiDung.Text += noiDung;
            lblPhanHoi.Text += phanHoi;
        }
    }
}
