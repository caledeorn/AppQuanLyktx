namespace WinFormsApp1.GUI
{
    partial class CardThongTin
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
            lblMaPhong = new Label();
            lblGioiTinh = new Label();
            lblTienPhong = new Label();
            lblSoSV = new Label();
            lblSoLuong = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(lblMaPhong);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblGioiTinh);
            splitContainer1.Panel2.Controls.Add(lblTienPhong);
            splitContainer1.Panel2.Controls.Add(lblSoSV);
            splitContainer1.Panel2.Controls.Add(lblSoLuong);
            splitContainer1.Size = new Size(150, 218);
            splitContainer1.SplitterDistance = 33;
            splitContainer1.TabIndex = 0;
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhong.Location = new Point(50, 10);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(47, 17);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "label1";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(12, 97);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(58, 15);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblTienPhong
            // 
            lblTienPhong.AutoSize = true;
            lblTienPhong.Location = new Point(12, 58);
            lblTienPhong.Name = "lblTienPhong";
            lblTienPhong.Size = new Size(71, 15);
            lblTienPhong.TabIndex = 2;
            lblTienPhong.Text = "Tiền phòng:";
            // 
            // lblSoSV
            // 
            lblSoSV.AutoSize = true;
            lblSoSV.Location = new Point(12, 130);
            lblSoSV.Name = "lblSoSV";
            lblSoSV.Size = new Size(76, 15);
            lblSoSV.TabIndex = 1;
            lblSoSV.Text = "Số sinh viên: ";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(12, 16);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(67, 15);
            lblSoLuong.TabIndex = 0;
            lblSoLuong.Text = "Số giường: ";
            // 
            // CardThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CardThongTin";
            Size = new Size(150, 218);
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
        private Label lblMaPhong;
        private Label lblGioiTinh;
        private Label lblTienPhong;
        private Label lblSoSV;
        private Label lblSoLuong;
    }
}
