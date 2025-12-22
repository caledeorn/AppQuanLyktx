namespace WinFormsApp1.GUI
{
    partial class UCThongBao
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
            lblNgay = new Label();
            lblNoiDung = new Label();
            lblPhanHoi = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(3, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(38, 15);
            lblNgay.TabIndex = 0;
            lblNgay.Text = "Ngày:";
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(3, 15);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(60, 15);
            lblNoiDung.TabIndex = 1;
            lblNoiDung.Text = "Nội dung:";
            // 
            // lblPhanHoi
            // 
            lblPhanHoi.AutoSize = true;
            lblPhanHoi.Location = new Point(3, 30);
            lblPhanHoi.Name = "lblPhanHoi";
            lblPhanHoi.Size = new Size(57, 15);
            lblPhanHoi.TabIndex = 2;
            lblPhanHoi.Text = "Phản hồi:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(157, 3);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(66, 15);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái: ";
            // 
            // UCThongBao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTrangThai);
            Controls.Add(lblPhanHoi);
            Controls.Add(lblNoiDung);
            Controls.Add(lblNgay);
            Name = "UCThongBao";
            Size = new Size(339, 53);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgay;
        private Label lblNoiDung;
        private Label lblPhanHoi;
        private Label lblTrangThai;
    }
}
