namespace PRL
{
    partial class cbb_LoaiHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txt_SearchTen = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            cbb_MaKH = new ComboBox();
            label3 = new Label();
            btn_TaoHoaDon = new Button();
            groupBox3 = new GroupBox();
            dgv_HDCT = new DataGridView();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl_ttsp = new Label();
            label5 = new Label();
            label4 = new Label();
            cbb_Voucher = new ComboBox();
            cbb_PTTT = new ComboBox();
            lbl_tthd = new Label();
            txt_TienKhach = new TextBox();
            txt_TienThua = new TextBox();
            btn_HuyHD = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_SearchTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(666, 46);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(409, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(337, 52);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên Loại";
            // 
            // txt_SearchTen
            // 
            txt_SearchTen.Location = new Point(118, 47);
            txt_SearchTen.Name = "txt_SearchTen";
            txt_SearchTen.Size = new Size(194, 27);
            txt_SearchTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Sản Phẩm:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 152);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(804, 607);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(cbb_MaKH);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btn_TaoHoaDon);
            groupBox2.Location = new Point(844, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 261);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 139);
            dataGridView1.TabIndex = 3;
            // 
            // cbb_MaKH
            // 
            cbb_MaKH.FormattingEnabled = true;
            cbb_MaKH.Location = new Point(291, 44);
            cbb_MaKH.Name = "cbb_MaKH";
            cbb_MaKH.Size = new Size(156, 28);
            cbb_MaKH.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 47);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã KH:";
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.Location = new Point(17, 36);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(185, 40);
            btn_TaoHoaDon.TabIndex = 0;
            btn_TaoHoaDon.Text = "     Tạo hóa đơn";
            btn_TaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_HDCT);
            groupBox3.Location = new Point(844, 279);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 181);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.BackgroundColor = SystemColors.MenuHighlight;
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(14, 36);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 51;
            dgv_HDCT.Size = new Size(438, 128);
            dgv_HDCT.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(btn_HuyHD);
            groupBox4.Controls.Add(txt_TienThua);
            groupBox4.Controls.Add(txt_TienKhach);
            groupBox4.Controls.Add(lbl_tthd);
            groupBox4.Controls.Add(cbb_PTTT);
            groupBox4.Controls.Add(cbb_Voucher);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(lbl_ttsp);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(852, 470);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 305);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tổng Hợp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 179);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 6;
            label10.Text = "Tiền khách đưa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 215);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 5;
            label9.Text = "Tiền thừa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 143);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 4;
            label8.Text = "Tổng tiền hóa đơn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 112);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 3;
            label7.Text = "Phương thức:";
            // 
            // lbl_ttsp
            // 
            lbl_ttsp.AutoSize = true;
            lbl_ttsp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ttsp.Location = new Point(248, 23);
            lbl_ttsp.Name = "lbl_ttsp";
            lbl_ttsp.Size = new Size(32, 38);
            lbl_ttsp.TabIndex = 2;
            lbl_ttsp.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 73);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 1;
            label5.Text = "Voucher:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 0;
            label4.Text = "Tổng tiền sản phẩm:";
            // 
            // cbb_Voucher
            // 
            cbb_Voucher.FormattingEnabled = true;
            cbb_Voucher.Location = new Point(157, 70);
            cbb_Voucher.Name = "cbb_Voucher";
            cbb_Voucher.Size = new Size(256, 28);
            cbb_Voucher.TabIndex = 7;
            // 
            // cbb_PTTT
            // 
            cbb_PTTT.FormattingEnabled = true;
            cbb_PTTT.Location = new Point(157, 104);
            cbb_PTTT.Name = "cbb_PTTT";
            cbb_PTTT.Size = new Size(256, 28);
            cbb_PTTT.TabIndex = 8;
            // 
            // lbl_tthd
            // 
            lbl_tthd.AutoSize = true;
            lbl_tthd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tthd.Location = new Point(248, 135);
            lbl_tthd.Name = "lbl_tthd";
            lbl_tthd.Size = new Size(32, 38);
            lbl_tthd.TabIndex = 9;
            lbl_tthd.Text = "0";
            // 
            // txt_TienKhach
            // 
            txt_TienKhach.Location = new Point(157, 176);
            txt_TienKhach.Name = "txt_TienKhach";
            txt_TienKhach.Size = new Size(256, 27);
            txt_TienKhach.TabIndex = 10;
            txt_TienKhach.Text = "0";
            // 
            // txt_TienThua
            // 
            txt_TienThua.Location = new Point(157, 215);
            txt_TienThua.Name = "txt_TienThua";
            txt_TienThua.Size = new Size(256, 27);
            txt_TienThua.TabIndex = 11;
            txt_TienThua.Text = "0";
            // 
            // btn_HuyHD
            // 
            btn_HuyHD.Location = new Point(127, 260);
            btn_HuyHD.Name = "btn_HuyHD";
            btn_HuyHD.Size = new Size(120, 45);
            btn_HuyHD.TabIndex = 12;
            btn_HuyHD.Text = "HỦY";
            btn_HuyHD.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(297, 260);
            button5.Name = "button5";
            button5.Size = new Size(116, 45);
            button5.TabIndex = 13;
            button5.Text = "button4";
            button5.UseVisualStyleBackColor = true;
            // 
            // cbb_LoaiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 787);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Name = "cbb_LoaiHang";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_SearchTen;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Button btn_TaoHoaDon;
        private Label label3;
        private ComboBox cbb_MaKH;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private DataGridView dgv_HDCT;
        private GroupBox groupBox4;
        private Label lbl_ttsp;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lbl_tthd;
        private ComboBox cbb_PTTT;
        private ComboBox cbb_Voucher;
        private TextBox txt_TienThua;
        private TextBox txt_TienKhach;
        private Button button5;
        private Button btn_HuyHD;
    }
}
