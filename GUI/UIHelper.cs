using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp1.GUI
{
    internal enum AlertType
    {
        Info,
        Success,
        Error
    }

    internal static class UIHelper
    {
        public static void ShowAlert(Label lbl, string text, AlertType type = AlertType.Info)
        {
            if (lbl == null) return;
            lbl.Text = text;
            switch (type)
            {
                case AlertType.Success:
                    lbl.ForeColor = Color.Green;
                    break;
                case AlertType.Error:
                    lbl.ForeColor = Color.Red;
                    break;
                default:
                    lbl.ForeColor = Color.Black;
                    break;
            }
        }

        // Map common property/column names to Vietnamese headers with diacritics and spaces
        public static void LocalizeDataGridView(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            var map = new Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
            {
                { "MaSV", "Mã sinh viên" },
                { "HoTen", "H? và tên" },
                { "SoDienThoai", "S? ?i?n tho?i" },
                { "NgaySinh", "Ngày sinh" },
                { "GioiTinhHienThi", "Gi?i tính" },
                { "MaPhong", "Mã phòng" },
                { "maHoaDon", "Mã hóa ??n" },
                { "soDien", "S? ?i?n" },
                { "soNuoc", "S? n??c" },
                { "ngayLap", "Ngày l?p" },
                { "trangThai", "Tr?ng thái" },
                { "tenPhong", "Tên phòng" },
                { "soLuong", "S? l??ng" },
                { "donGia", "??n giá" },
                // add more mappings as needed
            };

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (string.IsNullOrWhiteSpace(col.Name)) continue;
                if (map.TryGetValue(col.Name, out string header))
                {
                    col.HeaderText = header;
                }
                else
                {
                    // Try to prettify by inserting spaces before capital letters if no mapping
                    col.HeaderText = PrettifyColumnName(col.Name);
                }
            }
        }

        private static string PrettifyColumnName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return name;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (i > 0 && char.IsUpper(c) && name[i - 1] != ' ')
                {
                    sb.Append(' ');
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
