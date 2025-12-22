using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.GUI;

namespace WinFormsApp1
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            // pnContent là tên cái Panel lớn màu trắng bạn đã tạo ở Bước 1
            pnContent.Controls.Clear(); // Xóa control cũ đang hiển thị (nếu có)
            uc.Dock = DockStyle.Fill;     // Cho UserControl lấp đầy Panel
            pnContent.Controls.Add(uc); // Thêm UserControl mới vào
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            // 1. Tạo một đối tượng (instance) của User Control Sinh Viên
            // (Đảm bảo tên UC_SinhVien là chính xác)
            UC_SinhVien uc = new UC_SinhVien();
            //uc.BackClick += Uc_BackClicked;
            // 2. Gọi hàm trợ giúp để tải nó lên
            LoadUserControl(uc);
        }
        private void Uc_BackClicked(object sender, EventArgs e)
        {
            // Xử lý tại đây, ví dụ: xóa UserControl khỏi Panel
            pnContent.Controls.Clear();

            // Hoặc bạn cũng có thể tải một UserControl "Trang chủ" (nếu có)
            // LoadUserControl(new UC_TrangChu());
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            UC_HopDong uc = new UC_HopDong();
            LoadUserControl(uc);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            UC_Phong uc = new UC_Phong();
            LoadUserControl(uc);
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_HoaDon uc = new UC_HoaDon();
            LoadUserControl(uc);
        }

        private void btnPBH_Click(object sender, EventArgs e)
        {
            UC_PhieuBaoHong uc = new UC_PhieuBaoHong();
            LoadUserControl(uc);
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
