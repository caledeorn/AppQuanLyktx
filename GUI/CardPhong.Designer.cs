namespace WinFormsApp1.GUI
{
    partial class CardPhong
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
            lblMaphong = new Label();
            lblSodon = new Label();
            lblSosv = new Label();
            lblSogiuong = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            splitContainer1.Panel1.Controls.Add(lblMaphong);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblSodon);
            splitContainer1.Panel2.Controls.Add(lblSosv);
            splitContainer1.Panel2.Controls.Add(lblSogiuong);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(120, 160);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.TabIndex = 0;
            // 
            // lblMaphong
            // 
            lblMaphong.AutoSize = true;
            lblMaphong.FlatStyle = FlatStyle.Flat;
            lblMaphong.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaphong.Location = new Point(34, 13);
            lblMaphong.Name = "lblMaphong";
            lblMaphong.Size = new Size(47, 17);
            lblMaphong.TabIndex = 0;
            lblMaphong.Text = "label1";
            // 
            // lblSodon
            // 
            lblSodon.AutoSize = true;
            lblSodon.Location = new Point(103, 77);
            lblSodon.Name = "lblSodon";
            lblSodon.Size = new Size(38, 15);
            lblSodon.TabIndex = 5;
            lblSodon.Text = "label7";
            // 
            // lblSosv
            // 
            lblSosv.AutoSize = true;
            lblSosv.Location = new Point(79, 47);
            lblSosv.Name = "lblSosv";
            lblSosv.Size = new Size(38, 15);
            lblSosv.TabIndex = 4;
            lblSosv.Text = "label6";
            // 
            // lblSogiuong
            // 
            lblSogiuong.AutoSize = true;
            lblSogiuong.Location = new Point(79, 16);
            lblSogiuong.Name = "lblSogiuong";
            lblSogiuong.Size = new Size(38, 15);
            lblSogiuong.TabIndex = 3;
            lblSogiuong.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 78);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 2;
            label4.Text = "Số đơn báo hỏng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 47);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Số sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Số giường:";
            // 
            // CardPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(splitContainer1);
            Cursor = Cursors.Hand;
            Name = "CardPhong";
            Size = new Size(120, 160);
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
        private Label lblMaphong;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblSodon;
        private Label lblSosv;
        private Label lblSogiuong;
    }
}
