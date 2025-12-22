namespace WinFormsApp1.GUI
{
    partial class CardHoaDon
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
            lblMaHoaDon = new Label();
            lblMaPhong = new Label();
            lblNgay = new Label();
            lblSoDien = new Label();
            label1 = new Label();
            lblThanhTien = new Label();
            lblTrangthai = new Label();
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
            splitContainer1.Panel1.BackColor = Color.LightCoral;
            splitContainer1.Panel1.Controls.Add(lblMaHoaDon);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblTrangthai);
            splitContainer1.Panel2.Controls.Add(lblThanhTien);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(lblSoDien);
            splitContainer1.Panel2.Controls.Add(lblNgay);
            splitContainer1.Panel2.Controls.Add(lblMaPhong);
            splitContainer1.Size = new Size(140, 200);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.TabIndex = 0;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaHoaDon.Location = new Point(32, 11);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(49, 19);
            lblMaHoaDon.TabIndex = 0;
            lblMaHoaDon.Text = "label1";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(12, 4);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(65, 15);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(12, 28);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(38, 15);
            lblNgay.TabIndex = 1;
            lblNgay.Text = "Ngày:";
            lblNgay.Click += lblNgay_Click;
            // 
            // lblSoDien
            // 
            lblSoDien.AutoSize = true;
            lblSoDien.Location = new Point(12, 54);
            lblSoDien.Name = "lblSoDien";
            lblSoDien.Size = new Size(49, 15);
            lblSoDien.TabIndex = 2;
            lblSoDien.Text = "Số điện:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Số nước:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(12, 104);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(67, 15);
            lblThanhTien.TabIndex = 4;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // lblTrangthai
            // 
            lblTrangthai.AutoSize = true;
            lblTrangthai.Location = new Point(12, 130);
            lblTrangthai.Name = "lblTrangthai";
            lblTrangthai.Size = new Size(38, 15);
            lblTrangthai.TabIndex = 5;
            lblTrangthai.Text = "label2";
            // 
            // CardHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CardHoaDon";
            RightToLeft = RightToLeft.No;
            Size = new Size(140, 200);
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
        private Label lblMaHoaDon;
        private Label lblMaPhong;
        private Label lblNgay;
        private Label lblSoDien;
        private Label label1;
        private Label lblThanhTien;
        private Label lblTrangthai;
    }
}
