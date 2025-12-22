namespace WinFormsApp1
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMenu = new Panel();
            btnPBH = new Button();
            btnHoaDon = new Button();
            btnHopDong = new Button();
            btnPhong = new Button();
            btnSinhVien = new Button();
            pnContent = new Panel();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = SystemColors.AppWorkspace;
            pnMenu.BackgroundImageLayout = ImageLayout.Center;
            pnMenu.Controls.Add(btnPBH);
            pnMenu.Controls.Add(btnHoaDon);
            pnMenu.Controls.Add(btnHopDong);
            pnMenu.Controls.Add(btnPhong);
            pnMenu.Controls.Add(btnSinhVien);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(175, 686);
            pnMenu.TabIndex = 0;
            pnMenu.Paint += pnMenu_Paint;
            // 
            // btnPBH
            // 
            btnPBH.Dock = DockStyle.Top;
            btnPBH.FlatAppearance.BorderSize = 0;
            btnPBH.FlatStyle = FlatStyle.Flat;
            btnPBH.Location = new Point(0, 124);
            btnPBH.Name = "btnPBH";
            btnPBH.Size = new Size(175, 31);
            btnPBH.TabIndex = 7;
            btnPBH.Text = "Phiếu báo hỏng";
            btnPBH.TextAlign = ContentAlignment.MiddleLeft;
            btnPBH.UseVisualStyleBackColor = true;
            btnPBH.Click += btnPBH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(0, 93);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(175, 31);
            btnHoaDon.TabIndex = 6;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += button6_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.Dock = DockStyle.Top;
            btnHopDong.FlatAppearance.BorderSize = 0;
            btnHopDong.FlatStyle = FlatStyle.Flat;
            btnHopDong.Location = new Point(0, 62);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Size = new Size(175, 31);
            btnHopDong.TabIndex = 2;
            btnHopDong.Text = "Hợp Đồng";
            btnHopDong.TextAlign = ContentAlignment.MiddleLeft;
            btnHopDong.UseVisualStyleBackColor = true;
            btnHopDong.Click += btnHopDong_Click;
            // 
            // btnPhong
            // 
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Location = new Point(0, 31);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(175, 31);
            btnPhong.TabIndex = 1;
            btnPhong.Text = "Phòng";
            btnPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.Dock = DockStyle.Top;
            btnSinhVien.FlatAppearance.BorderSize = 0;
            btnSinhVien.FlatStyle = FlatStyle.Flat;
            btnSinhVien.Location = new Point(0, 0);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(175, 31);
            btnSinhVien.TabIndex = 0;
            btnSinhVien.Text = "Sinh Viên";
            btnSinhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // pnContent
            // 
            pnContent.BackColor = SystemColors.ButtonHighlight;
            pnContent.Dock = DockStyle.Fill;
            pnContent.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnContent.Location = new Point(175, 0);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1142, 686);
            pnContent.TabIndex = 1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 686);
            Controls.Add(pnContent);
            Controls.Add(pnMenu);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý ký túc xá";
            FormClosed += FormAdmin_FormClosed;
            pnMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnContent;
        private Button btnSinhVien;
        private Button btnPBH;
        private Button btnHoaDon;
        private Button btnPhong;
        private Button btnHopDong;
    }
}