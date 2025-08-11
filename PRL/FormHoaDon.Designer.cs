namespace PRL
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            groupBox1 = new GroupBox();
            cbb_TenKH = new ComboBox();
            cbb_TenNV = new ComboBox();
            label19 = new Label();
            label16 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            btn_Loc = new Button();
            dtp_Engay = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtp_Fngay = new DateTimePicker();
            dgv_HoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            cbb_httt = new ComboBox();
            cbb_TrangThai = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            txt_TongTien = new TextBox();
            txt_MaGG = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txt_MaKH = new TextBox();
            label6 = new Label();
            txt_MaNV = new TextBox();
            label5 = new Label();
            dtp_Ngay = new DateTimePicker();
            label4 = new Label();
            txt_Ma = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txt_MaHDCT = new TextBox();
            txt_MaHD = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txt_SoLuong = new TextBox();
            txt_DonGia = new TextBox();
            txt_MaSP = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            dgv_HDCT = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_TenKH);
            groupBox1.Controls.Add(cbb_TenNV);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(btn_Loc);
            groupBox1.Controls.Add(dtp_Engay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtp_Fngay);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1490, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // cbb_TenKH
            // 
            cbb_TenKH.FormattingEnabled = true;
            cbb_TenKH.Location = new Point(303, 65);
            cbb_TenKH.Margin = new Padding(3, 4, 3, 4);
            cbb_TenKH.Name = "cbb_TenKH";
            cbb_TenKH.Size = new Size(235, 36);
            cbb_TenKH.TabIndex = 13;
            // 
            // cbb_TenNV
            // 
            cbb_TenNV.FormattingEnabled = true;
            cbb_TenNV.Location = new Point(26, 65);
            cbb_TenNV.Margin = new Padding(3, 4, 3, 4);
            cbb_TenNV.Name = "cbb_TenNV";
            cbb_TenNV.Size = new Size(235, 36);
            cbb_TenNV.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(303, 33);
            label19.Name = "label19";
            label19.Size = new Size(161, 28);
            label19.TabIndex = 11;
            label19.Text = "Mã Khách Hàng:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 33);
            label16.Name = "label16";
            label16.Size = new Size(147, 28);
            label16.TabIndex = 11;
            label16.Text = "Mã Nhân Viên:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Quá hạn", "Đã hủy" });
            comboBox1.Location = new Point(1051, 65);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 36);
            comboBox1.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1051, 33);
            label15.Name = "label15";
            label15.Size = new Size(107, 28);
            label15.TabIndex = 7;
            label15.Text = "Trạng thái:";
            // 
            // btn_Loc
            // 
            btn_Loc.BackColor = Color.Yellow;
            
            btn_Loc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Loc.Location = new Point(1322, 56);
            btn_Loc.Margin = new Padding(3, 4, 3, 4);
            btn_Loc.Name = "btn_Loc";
            btn_Loc.Size = new Size(144, 53);
            btn_Loc.TabIndex = 6;
            btn_Loc.Text = "Lọc";
            btn_Loc.UseVisualStyleBackColor = false;
            btn_Loc.Click += btn_Loc_Click;
            // 
            // dtp_Engay
            // 
            dtp_Engay.Format = DateTimePickerFormat.Short;
            dtp_Engay.Location = new Point(813, 65);
            dtp_Engay.Margin = new Padding(3, 4, 3, 4);
            dtp_Engay.Name = "dtp_Engay";
            dtp_Engay.Size = new Size(207, 34);
            dtp_Engay.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(813, 33);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(575, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 3;
            label1.Text = "Từ ngày:";
            // 
            // dtp_Fngay
            // 
            dtp_Fngay.Format = DateTimePickerFormat.Short;
            dtp_Fngay.Location = new Point(575, 65);
            dtp_Fngay.Margin = new Padding(3, 4, 3, 4);
            dtp_Fngay.Name = "dtp_Fngay";
            dtp_Fngay.Size = new Size(195, 34);
            dtp_Fngay.TabIndex = 2;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_HoaDon.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(7, 32);
            dgv_HoaDon.Margin = new Padding(3, 4, 3, 4);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.Size = new Size(1079, 452);
            dgv_HoaDon.TabIndex = 1;
            dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
            dgv_HoaDon.CellDoubleClick += dgv_HoaDon_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_httt);
            groupBox2.Controls.Add(cbb_TrangThai);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txt_TongTien);
            groupBox2.Controls.Add(txt_MaGG);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_MaKH);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_MaNV);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtp_Ngay);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_Ma);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(14, 169);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(391, 492);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // cbb_httt
            // 
            cbb_httt.FormattingEnabled = true;
            cbb_httt.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản ngân hàng", "Quẹt thẻ tín dụng" });
            cbb_httt.Location = new Point(146, 383);
            cbb_httt.Margin = new Padding(3, 4, 3, 4);
            cbb_httt.Name = "cbb_httt";
            cbb_httt.Size = new Size(230, 36);
            cbb_httt.TabIndex = 15;
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Quá hạn", "Đã hủy" });
            cbb_TrangThai.Location = new Point(145, 437);
            cbb_TrangThai.Margin = new Padding(3, 4, 3, 4);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(230, 36);
            cbb_TrangThai.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label18.Location = new Point(13, 383);
            label18.Name = "label18";
            label18.Size = new Size(65, 28);
            label18.TabIndex = 13;
            label18.Text = "HTTT:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label17.Location = new Point(7, 437);
            label17.Name = "label17";
            label17.Size = new Size(107, 28);
            label17.TabIndex = 13;
            label17.Text = "Trạng thái:";
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(146, 325);
            txt_TongTien.Margin = new Padding(3, 4, 3, 4);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.ReadOnly = true;
            txt_TongTien.Size = new Size(231, 34);
            txt_TongTien.TabIndex = 11;
            // 
            // txt_MaGG
            // 
            txt_MaGG.Location = new Point(146, 269);
            txt_MaGG.Margin = new Padding(3, 4, 3, 4);
            txt_MaGG.Name = "txt_MaGG";
            txt_MaGG.ReadOnly = true;
            txt_MaGG.Size = new Size(231, 34);
            txt_MaGG.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(7, 329);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 9;
            label8.Text = "Tổng tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(7, 273);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 8;
            label7.Text = "Mã giảm giá:";
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(146, 209);
            txt_MaKH.Margin = new Padding(3, 4, 3, 4);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.ReadOnly = true;
            txt_MaKH.Size = new Size(231, 34);
            txt_MaKH.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(7, 213);
            label6.Name = "label6";
            label6.Size = new Size(157, 28);
            label6.TabIndex = 6;
            label6.Text = "Mã khách hàng:";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(146, 151);
            txt_MaNV.Margin = new Padding(3, 4, 3, 4);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.ReadOnly = true;
            txt_MaNV.Size = new Size(231, 34);
            txt_MaNV.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(7, 155);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 4;
            label5.Text = "Mã Nhân Viên:";
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.Format = DateTimePickerFormat.Short;
            dtp_Ngay.Location = new Point(146, 93);
            dtp_Ngay.Margin = new Padding(3, 4, 3, 4);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(231, 34);
            dtp_Ngay.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 101);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 2;
            label4.Text = "Ngày lập:";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(146, 39);
            txt_Ma.Margin = new Padding(3, 4, 3, 4);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.ReadOnly = true;
            txt_Ma.Size = new Size(231, 34);
            txt_Ma.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(7, 43);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_MaHDCT);
            groupBox3.Controls.Add(txt_MaHD);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txt_SoLuong);
            groupBox3.Controls.Add(txt_DonGia);
            groupBox3.Controls.Add(txt_MaSP);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(13, 669);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(392, 393);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sản phẩm";
            // 
            // txt_MaHDCT
            // 
            txt_MaHDCT.Location = new Point(146, 37);
            txt_MaHDCT.Margin = new Padding(3, 4, 3, 4);
            txt_MaHDCT.Name = "txt_MaHDCT";
            txt_MaHDCT.ReadOnly = true;
            txt_MaHDCT.Size = new Size(231, 34);
            txt_MaHDCT.TabIndex = 10;
            // 
            // txt_MaHD
            // 
            txt_MaHD.Location = new Point(146, 93);
            txt_MaHD.Margin = new Padding(3, 4, 3, 4);
            txt_MaHD.Name = "txt_MaHD";
            txt_MaHD.ReadOnly = true;
            txt_MaHD.Size = new Size(231, 34);
            txt_MaHD.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(7, 39);
            label11.Name = "label11";
            label11.Size = new Size(103, 28);
            label11.TabIndex = 8;
            label11.Text = "Mã HĐCT:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(7, 95);
            label12.Name = "label12";
            label12.Size = new Size(127, 28);
            label12.TabIndex = 9;
            label12.Text = "Mã hóa đơn:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(146, 211);
            txt_SoLuong.Margin = new Padding(3, 4, 3, 4);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.ReadOnly = true;
            txt_SoLuong.Size = new Size(230, 34);
            txt_SoLuong.TabIndex = 7;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(146, 273);
            txt_DonGia.Margin = new Padding(3, 4, 3, 4);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.ReadOnly = true;
            txt_DonGia.Size = new Size(231, 34);
            txt_DonGia.TabIndex = 6;
            // 
            // txt_MaSP
            // 
            txt_MaSP.Location = new Point(146, 153);
            txt_MaSP.Margin = new Padding(3, 4, 3, 4);
            txt_MaSP.Name = "txt_MaSP";
            txt_MaSP.ReadOnly = true;
            txt_MaSP.Size = new Size(231, 34);
            txt_MaSP.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(7, 275);
            label14.Name = "label14";
            label14.Size = new Size(88, 28);
            label14.TabIndex = 0;
            label14.Text = "Đơn giá:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(6, 211);
            label13.Name = "label13";
            label13.Size = new Size(99, 28);
            label13.TabIndex = 0;
            label13.Text = "Số lượng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(7, 155);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 0;
            label9.Text = "Mã sản phẩm:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_HoaDon);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(411, 169);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(1099, 492);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hóa đơn";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_HDCT);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(418, 669);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(1093, 393);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hóa đơn chi tiết";
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(7, 35);
            dgv_HDCT.Margin = new Padding(3, 4, 3, 4);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 51;
            dgv_HDCT.Size = new Size(1072, 351);
            dgv_HDCT.TabIndex = 0;
            dgv_HDCT.CellClick += dgv_HDCT_CellClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;

            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 1055);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp_Fngay;
        private Button btn_Loc;
        private DateTimePicker dtp_Engay;
        private Label label2;
        private Label label1;
        private DataGridView dgv_HoaDon;
        private GroupBox groupBox2;
        private DateTimePicker dtp_Ngay;
        private Label label4;
        private TextBox txt_Ma;
        private Label label3;
        private TextBox txt_MaKH;
        private Label label6;
        private TextBox txt_MaNV;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox txt_DonGia;
        private TextBox txt_MaSP;
        private Label label14;
        private Label label13;
        private Label label9;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dgv_HDCT;
        private ComboBox comboBox1;
        private Label label15;
        private Label label17;
        private ComboBox cbb_TrangThai;
        private TextBox txt_TongTien;
        private TextBox txt_MaGG;
        private Label label8;
        private Label label7;
        private ComboBox cbb_httt;
        private Label label18;
        private Label label16;
        private Label label19;
        private ComboBox cbb_TenKH;
        private ComboBox cbb_TenNV;
        private TextBox txt_SoLuong;
        private TextBox txt_MaHDCT;
        private TextBox txt_MaHD;
        private Label label11;
        private Label label12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}