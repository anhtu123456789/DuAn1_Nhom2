namespace PRL
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            dgv_SanPham = new DataGridView();
            ptb_SanPham = new PictureBox();
            txt_Search = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Search = new Button();
            btn_Reset = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cbb_NCC = new ComboBox();
            cbb_LoaiSP = new ComboBox();
            txt_SoLuong = new TextBox();
            dtp_Ngay = new DateTimePicker();
            label12 = new Label();
            txt_Ma = new TextBox();
            label8 = new Label();
            cbb_TrangThai = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Gia = new TextBox();
            txt_Mota = new TextBox();
            txt_Ten = new TextBox();
            groupBox3 = new GroupBox();
            cbb_tt = new ComboBox();
            cbb_Loai = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.AllowUserToAddRows = false;
            dgv_SanPham.AllowUserToDeleteRows = false;
            dgv_SanPham.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Location = new Point(7, 33);
            dgv_SanPham.Margin = new Padding(3, 4, 3, 4);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.ReadOnly = true;
            dgv_SanPham.RowHeadersWidth = 51;
            dgv_SanPham.Size = new Size(1470, 399);
            dgv_SanPham.TabIndex = 0;
            dgv_SanPham.CellClick += dgv_SanPham_CellClick;
            // 
            // ptb_SanPham
            // 
            ptb_SanPham.BackColor = Color.Maroon;
            ptb_SanPham.Location = new Point(19, 37);
            ptb_SanPham.Margin = new Padding(3, 4, 3, 4);
            ptb_SanPham.Name = "ptb_SanPham";
            ptb_SanPham.Size = new Size(368, 331);
            ptb_SanPham.TabIndex = 1;
            ptb_SanPham.TabStop = false;
            ptb_SanPham.Click += ptb_SanPham_Click;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 12F);
            txt_Search.Location = new Point(22, 79);
            txt_Search.Margin = new Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Nhập tên sản phẩm...";
            txt_Search.Size = new Size(387, 34);
            txt_Search.TabIndex = 6;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(255, 128, 255);
            btn_Them.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Them.ForeColor = Color.Black;
            
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(934, 59);
            btn_Them.Margin = new Padding(3, 4, 3, 4);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(167, 59);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "  Thêm mới";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(255, 128, 255);
            btn_Sua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Sua.ForeColor = Color.Black;

            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(1115, 59);
            btn_Sua.Margin = new Padding(3, 4, 3, 4);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(167, 59);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.FromArgb(255, 128, 255);
            btn_Search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Search.ForeColor = Color.Black;
            btn_Search.Image = (Image)resources.GetObject("btn_Search.Image");
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(753, 59);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(167, 59);
            btn_Search.TabIndex = 11;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.FromArgb(255, 128, 255);
            btn_Reset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Reset.ForeColor = Color.Black;
            
            btn_Reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reset.Location = new Point(1297, 59);
            btn_Reset.Margin = new Padding(3, 4, 3, 4);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(167, 59);
            btn_Reset.TabIndex = 12;
            btn_Reset.Text = "Làm mới";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_SanPham);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 621);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1490, 444);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng danh sách các sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_NCC);
            groupBox2.Controls.Add(cbb_LoaiSP);
            groupBox2.Controls.Add(txt_SoLuong);
            groupBox2.Controls.Add(dtp_Ngay);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txt_Ma);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbb_TrangThai);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_Gia);
            groupBox2.Controls.Add(txt_Mota);
            groupBox2.Controls.Add(txt_Ten);
            groupBox2.Controls.Add(ptb_SanPham);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1483, 401);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // cbb_NCC
            // 
            cbb_NCC.FormattingEnabled = true;
            cbb_NCC.Location = new Point(1115, 199);
            cbb_NCC.Margin = new Padding(3, 4, 3, 4);
            cbb_NCC.Name = "cbb_NCC";
            cbb_NCC.Size = new Size(321, 36);
            cbb_NCC.TabIndex = 36;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(1115, 92);
            cbb_LoaiSP.Margin = new Padding(3, 4, 3, 4);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(321, 36);
            cbb_LoaiSP.TabIndex = 35;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(768, 92);
            txt_SoLuong.Margin = new Padding(3, 4, 3, 4);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(322, 34);
            txt_SoLuong.TabIndex = 34;
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.Format = DateTimePickerFormat.Short;
            dtp_Ngay.Location = new Point(769, 199);
            dtp_Ngay.Margin = new Padding(3, 4, 3, 4);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(321, 34);
            dtp_Ngay.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(768, 159);
            label12.Name = "label12";
            label12.Size = new Size(148, 28);
            label12.TabIndex = 32;
            label12.Text = "Ngày cập nhật:";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(427, 92);
            txt_Ma.Margin = new Padding(3, 4, 3, 4);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.PlaceholderText = "Mã sản phẩm...";
            txt_Ma.ReadOnly = true;
            txt_Ma.Size = new Size(321, 34);
            txt_Ma.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 52);
            label8.Name = "label8";
            label8.Size = new Size(140, 28);
            label8.TabIndex = 30;
            label8.Text = "Mã sản phẩm:";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            cbb_TrangThai.Location = new Point(1115, 307);
            cbb_TrangThai.Margin = new Padding(3, 4, 3, 4);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(321, 36);
            cbb_TrangThai.TabIndex = 26;
            cbb_TrangThai.Text = "Chọn trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(769, 52);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 19;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(1115, 265);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 20;
            label4.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(1115, 156);
            label7.Name = "label7";
            label7.Size = new Size(142, 28);
            label7.TabIndex = 21;
            label7.Text = "Nhà cung cấp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(1115, 52);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 22;
            label6.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(769, 233);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 23;
            label3.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(427, 265);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 24;
            label2.Text = "Giá bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(427, 156);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 25;
            label1.Text = "Tên sản phẩm:";
            // 
            // txt_Gia
            // 
            txt_Gia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Gia.Location = new Point(427, 307);
            txt_Gia.Margin = new Padding(3, 4, 3, 4);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.PlaceholderText = "Giá bán...";
            txt_Gia.Size = new Size(321, 34);
            txt_Gia.TabIndex = 18;
            // 
            // txt_Mota
            // 
            txt_Mota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Mota.Location = new Point(769, 265);
            txt_Mota.Margin = new Padding(3, 4, 3, 4);
            txt_Mota.Multiline = true;
            txt_Mota.Name = "txt_Mota";
            txt_Mota.PlaceholderText = "Mô tả...";
            txt_Mota.Size = new Size(321, 79);
            txt_Mota.TabIndex = 17;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Ten.Location = new Point(427, 199);
            txt_Ten.Margin = new Padding(3, 4, 3, 4);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.PlaceholderText = "Tên sản phẩm...";
            txt_Ten.Size = new Size(321, 34);
            txt_Ten.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbb_tt);
            groupBox3.Controls.Add(cbb_Loai);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btn_Reset);
            groupBox3.Controls.Add(txt_Search);
            groupBox3.Controls.Add(btn_Sua);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 425);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1483, 167);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // cbb_tt
            // 
            cbb_tt.FormattingEnabled = true;
            cbb_tt.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            cbb_tt.Location = new Point(589, 79);
            cbb_tt.Margin = new Padding(3, 4, 3, 4);
            cbb_tt.Name = "cbb_tt";
            cbb_tt.Size = new Size(138, 36);
            cbb_tt.TabIndex = 16;
            // 
            // cbb_Loai
            // 
            cbb_Loai.FormattingEnabled = true;
            cbb_Loai.Location = new Point(429, 79);
            cbb_Loai.Margin = new Padding(3, 4, 3, 4);
            cbb_Loai.Name = "cbb_Loai";
            cbb_Loai.Size = new Size(133, 36);
            cbb_Loai.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(589, 33);
            label11.Name = "label11";
            label11.Size = new Size(107, 28);
            label11.TabIndex = 14;
            label11.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 35);
            label10.Name = "label10";
            label10.Size = new Size(149, 28);
            label10.TabIndex = 14;
            label10.Text = "Loại sản phẩm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 44);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 13;
            label9.Text = "Tên sản phẩm:";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1525, 1055);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_SanPham;
        private PictureBox ptb_SanPham;
        private TextBox txt_Search;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Search;
        private Button btn_Reset;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbb_TrangThai;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Gia;
        private TextBox txt_Mota;
        private TextBox txt_Ten;
        private TextBox txt_Ma;
        private Label label8;
        private GroupBox groupBox3;
        private ComboBox cbb_tt;
        private ComboBox cbb_Loai;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker dtp_Ngay;
        private Label label12;
        private TextBox txt_SoLuong;
        private ComboBox cbb_NCC;
        private ComboBox cbb_LoaiSP;
    }
}