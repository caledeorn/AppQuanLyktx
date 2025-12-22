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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private string KiemTraDangNhapVaLayQuyen(string userNhap, string passNhap)
        {
            string path = "DangNhap.txt";

            if (!File.Exists(path)) return ""; // Không có file coi như sai

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');

                // Bây giờ chúng ta cần tách 3 phần: User, Pass, Role
                if (parts.Length >= 3)
                {
                    string u = parts[0].Trim();
                    string p = parts[1].Trim();
                    string role = parts[2].Trim(); // Lấy quyền ra

                    if (u == userNhap && p == passNhap)
                    {
                        return role; // Trả về quyền tìm thấy (Admin hoặc SinhVien)
                    }
                }
            }

            return ""; // Không tìm thấy
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text;
            string mk = txtPassword.Text;

            // Gọi hàm kiểm tra mới
            string quyen = KiemTraDangNhapVaLayQuyen(tk, mk);

            if (quyen == "")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else if (quyen == "1")
            {
                MessageBox.Show("Xin chào Quản trị viên!");
                // Mở Form Admin
                FormAdmin fAdmin = new FormAdmin();
                fAdmin.Show();
                this.Hide();
            }
            else if (quyen == "0")
            {
                MessageBox.Show("Xin chào Sinh viên!");
                // Mở Form Sinh Viên (có thể truyền mã SV sang để hiện thông tin)
                FormSinhVien fSV = new FormSinhVien(tk); // Truyền mã SV sang
                fSV.Show();
                this.Hide();
            }
            else
            {
                // Trường hợp file ghi quyền lạ
                MessageBox.Show("Lỗi quyền hạn không xác định!");
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
