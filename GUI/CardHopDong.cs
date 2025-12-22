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
    public partial class CardHopDong : UserControl
    {
        public event EventHandler OnSelect;
        public CardHopDong()
        {
            InitializeComponent();
            WireAllControls(this);
        }
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                // 1. Gán sự kiện Click cho control con (Label, Panel, Splitter...)
                ctl.Click += CardHopDong_Click;

                // 2. Nếu control này là container (như SplitContainer hay Panel)
                // thì đào sâu tiếp vào bên trong nó
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }
        private void CardHopDong_Load(object sender, EventArgs e)
        {
        }
        public void setData(string maPhong, string maSV, DateTime ngayBD, DateTime ngayKT, int tienPhong)
        {
            lblMaPhong.Text = maPhong + "-" + maSV;
            lblNgayBD.Text += ngayBD.ToString("dd/MM/yyyy");
            lblNgayKT.Text += ngayKT.ToString("dd/MM/yyyy");
            lblTienPhong.Text += tienPhong.ToString();
        }
        private void CardHopDong_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        

    }
}
