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
    public partial class CardPhieuBaoHong : UserControl
    {
        public event EventHandler OnSelect;
        public CardPhieuBaoHong()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        public void setData(string maPhieu,string maPhong, string maSV, string thietBi, string ngayBaoHong, string trangThai)
        {
            lblMaPhieu.Text += maPhieu;
            lblMaPhong.Text += maPhong;
            lblMaSV.Text += maSV;
            lblThietBi.Text += thietBi;
            lblNgayBao.Text += ngayBaoHong;
            lblTrangThai.Text += trangThai;
        }
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                // 1. Gán sự kiện Click cho control con (Label, Panel, Splitter...)
                ctl.Click += CardPhieuBaoHong_Click;

                // 2. Nếu control này là container (như SplitContainer hay Panel)
                // thì đào sâu tiếp vào bên trong nó
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void CardPhieuBaoHong_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
