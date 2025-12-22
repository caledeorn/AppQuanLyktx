namespace WinFormsApp1.GUI
{
    partial class CardHopDong
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
            lblTienPhong = new Label();
            lblNgayKT = new Label();
            lblNgayBD = new Label();
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
            splitContainer1.Panel1.Controls.Add(lblMaPhong);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(lblTienPhong);
            splitContainer1.Panel2.Controls.Add(lblNgayKT);
            splitContainer1.Panel2.Controls.Add(lblNgayBD);
            splitContainer1.Size = new Size(150, 200);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.TabIndex = 0;
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblMaPhong.Location = new Point(12, 11);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(10, 15);
            lblMaPhong.TabIndex = 5;
            lblMaPhong.Text = " ";
            // 
            // lblTienPhong
            // 
            lblTienPhong.AutoSize = true;
            lblTienPhong.Font = new Font("Times New Roman", 9F);
            lblTienPhong.Location = new Point(12, 106);
            lblTienPhong.Name = "lblTienPhong";
            lblTienPhong.Size = new Size(68, 15);
            lblTienPhong.TabIndex = 9;
            lblTienPhong.Text = "Tiền Phòng: ";
            // 
            // lblNgayKT
            // 
            lblNgayKT.AutoSize = true;
            lblNgayKT.Font = new Font("Times New Roman", 9F);
            lblNgayKT.Location = new Point(12, 66);
            lblNgayKT.Name = "lblNgayKT";
            lblNgayKT.Size = new Size(81, 15);
            lblNgayKT.TabIndex = 8;
            lblNgayKT.Text = "Ngày kết thúc: ";
            // 
            // lblNgayBD
            // 
            lblNgayBD.AutoSize = true;
            lblNgayBD.Font = new Font("Times New Roman", 9F);
            lblNgayBD.Location = new Point(12, 28);
            lblNgayBD.Name = "lblNgayBD";
            lblNgayBD.Size = new Size(77, 15);
            lblNgayBD.TabIndex = 7;
            lblNgayBD.Text = "Ngày bắt đầu: ";
            // 
            // CardHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(splitContainer1);
            Cursor = Cursors.Hand;
            Name = "CardHopDong";
            Size = new Size(150, 200);
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
        private Label lblTienPhong;
        private Label lblNgayKT;
        private Label lblNgayBD;
    }
}
