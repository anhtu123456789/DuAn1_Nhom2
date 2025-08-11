namespace PRL
{
    partial class FormNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            groupBox3 = new GroupBox();
            cbb_SearcTT = new ComboBox();
            btn_Search = new Button();
            label9 = new Label();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txt_SearchTen = new TextBox();
            groupBox2 = new GroupBox();
            dgv_NhaCC = new DataGridView();
            groupBox1 = new GroupBox();
            txt_Ma = new TextBox();
            label1 = new Label();
            cbb_TrangThai = new ComboBox();
            txt_Email = new TextBox();
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Ten = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NhaCC).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbb_SearcTT);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(txt_SearchTen);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(89, 233);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1343, 125);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // cbb_SearcTT
            // 
            cbb_SearcTT.FormattingEnabled = true;
            cbb_SearcTT.Items.AddRange(new object[] { "Đang hợp tác", "Ngưng hợp tác" });
            cbb_SearcTT.Location = new Point(893, 60);
            cbb_SearcTT.Margin = new Padding(3, 4, 3, 4);
            cbb_SearcTT.Name = "cbb_SearcTT";
            cbb_SearcTT.Size = new Size(211, 36);
            cbb_SearcTT.TabIndex = 21;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Yellow;
            
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(1159, 43);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(165, 56);
            btn_Search.TabIndex = 20;
            btn_Search.Text = "Lọc";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(893, 32);
            label9.Name = "label9";
            label9.Size = new Size(111, 28);
            label9.TabIndex = 18;
            label9.Text = "Trạng Thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(639, 32);
            label8.Name = "label8";
            label8.Size = new Size(177, 28);
            label8.TabIndex = 17;
            label8.Text = "Tên nhà cung cấp:";
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(43, 43);
            button5.Name = "button5";
            button5.Size = new Size(165, 56);
            button5.TabIndex = 13;
            button5.Text = "Thêm ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Fuchsia;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(240, 43);
            button6.Name = "button6";
            button6.Size = new Size(165, 56);
            button6.TabIndex = 14;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Fuchsia;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(441, 43);
            button7.Name = "button7";
            button7.Size = new Size(165, 56);
            button7.TabIndex = 15;
            button7.Text = "Làm mới";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // txt_SearchTen
            // 
            txt_SearchTen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_SearchTen.Location = new Point(639, 63);
            txt_SearchTen.Name = "txt_SearchTen";
            txt_SearchTen.PlaceholderText = "Tìm kiếm...";
            txt_SearchTen.Size = new Size(235, 31);
            txt_SearchTen.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_NhaCC);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(662, 367);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(758, 564);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgv_NhaCC
            // 
            dgv_NhaCC.AllowUserToAddRows = false;
            dgv_NhaCC.AllowUserToDeleteRows = false;
            dgv_NhaCC.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgv_NhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NhaCC.Location = new Point(7, 36);
            dgv_NhaCC.Name = "dgv_NhaCC";
            dgv_NhaCC.ReadOnly = true;
            dgv_NhaCC.RowHeadersWidth = 51;
            dgv_NhaCC.Size = new Size(744, 521);
            dgv_NhaCC.TabIndex = 20;
            dgv_NhaCC.CellClick += dgv_NhaCC_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Ma);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbb_TrangThai);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_DiaChi);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(89, 367);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(515, 564);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txt_Ma
            // 
            txt_Ma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Ma.Location = new Point(161, 92);
            txt_Ma.Margin = new Padding(3, 4, 3, 4);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(330, 34);
            txt_Ma.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 92);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 26;
            label1.Text = "Mã NCC:";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Đang hợp tác", "Ngưng hợp tác" });
            cbb_TrangThai.Location = new Point(161, 401);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(330, 36);
            cbb_TrangThai.TabIndex = 25;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Email.Location = new Point(161, 341);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(330, 34);
            txt_Email.TabIndex = 24;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_SDT.Location = new Point(161, 216);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(330, 34);
            txt_SDT.TabIndex = 23;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_DiaChi.Location = new Point(161, 280);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(330, 34);
            txt_DiaChi.TabIndex = 22;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Ten.Location = new Point(161, 153);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(330, 34);
            txt_Ten.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(34, 405);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 19;
            label7.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(34, 341);
            label10.Name = "label10";
            label10.Size = new Size(65, 28);
            label10.TabIndex = 18;
            label10.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(34, 224);
            label11.Name = "label11";
            label11.Size = new Size(53, 28);
            label11.TabIndex = 17;
            label11.Text = "SĐT:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(34, 280);
            label12.Name = "label12";
            label12.Size = new Size(78, 28);
            label12.TabIndex = 16;
            label12.Text = "Địa chỉ:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(34, 153);
            label14.Name = "label14";
            label14.Size = new Size(93, 28);
            label14.TabIndex = 14;
            label14.Text = "Tên NCC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(569, 80);
            label2.Name = "label2";
            label2.Size = new Size(634, 67);
            label2.TabIndex = 28;
            label2.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNhaCungCap";
            Load += FormNhaCungCap_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_NhaCC).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private Button btn_Search;
        private Label label9;
        private Label label8;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txt_SearchTen;
        private GroupBox groupBox2;
        private DataGridView dgv_NhaCC;
        private GroupBox groupBox1;
        private ComboBox cbb_TrangThai;
        private TextBox txt_Email;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_Ten;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox txt_Ma;
        private Label label1;
        private Label label2;
        private ComboBox cbb_SearcTT;
        private PictureBox pictureBox1;
    }
}