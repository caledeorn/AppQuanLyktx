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
    public partial class CardPhong : UserControl
    {
        public event EventHandler OnSelect;
        public CardPhong()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        public void setData(string maPhong, int soSV, int soGiuong, int soDon)
        {
            lblMaphong.Text = maPhong;
            lblSodon.Text = soDon.ToString();
            lblSosv.Text = soSV.ToString();
            lblSogiuong.Text = soGiuong.ToString();

        }
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                // 1. Gán sự kiện Click cho control con (Label, Panel, Splitter...)
                ctl.Click += CardPhong_Click;

                // 2. Nếu control này là container (như SplitContainer hay Panel)
                // thì đào sâu tiếp vào bên trong nó
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void CardPhong_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
