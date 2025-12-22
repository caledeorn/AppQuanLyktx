namespace WinFormsApp1.GUI
{
    partial class CardPhieuBaoHong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            lblMaPhieu = new Label();
            lblNgayBao = new Label();
            lblTrangThai = new Label();
            lblThietBi = new Label();
            lblMaPhong = new Label();
            lblMaSV = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.OrangeRed;
            splitContainer1.Panel1.Controls.Add(lblMaPhieu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblNgayBao);
            splitContainer1.Panel2.Controls.Add(lblTrangThai);
            splitContainer1.Panel2.Controls.Add(lblThietBi);
            splitContainer1.Panel2.Controls.Add(lblMaPhong);
            splitContainer1.Panel2.Controls.Add(lblMaSV);
            splitContainer1.Size = new Size(160, 250);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 0;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(55, 18);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(0, 15);
            lblMaPhieu.TabIndex = 0;
            // 
            // lblNgayBao
            // 
            lblNgayBao.AutoSize = true;
            lblNgayBao.Location = new Point(14, 79);
            lblNgayBao.Name = "lblNgayBao";
            lblNgayBao.Size = new Size(61, 15);
            lblNgayBao.TabIndex = 4;
            lblNgayBao.Text = "Ngày báo:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(14, 144);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(63, 15);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Location = new Point(14, 113);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(50, 15);
            lblThietBi.TabIndex = 2;
            lblThietBi.Text = "Thiết bị:";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(14, 49);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(65, 15);
            lblMaPhong.TabIndex = 1;
            lblMaPhong.Text = "Mã phòng:";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(14, 20);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(43, 15);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // CardPhieuBaoHong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(splitContainer1);
            Name = "CardPhieuBaoHong";
            Size = new Size(160, 250);
            Click += CardPhieuBaoHong_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblMaPhieu;
        private Label lblMaPhong;
        private Label lblMaSV;
        private Label lblThietBi;
        private Label lblTrangThai;
        private Label lblNgayBao;
    }
}
