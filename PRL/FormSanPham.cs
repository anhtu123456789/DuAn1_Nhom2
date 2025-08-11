using BUS.Servisces;
using DAL.Model;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormSanPham : Form
    {
        LoaiHangServices _servicesLH;
        NhaCungCapServices _servicesNCC;
        SanPhamServisces _service;

        public FormSanPham()
        {
            _servicesLH = new LoaiHangServices();
            _servicesNCC = new NhaCungCapServices();
            _service = new SanPhamServisces();
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            cbb_LoaiSP.DataSource = _servicesLH.GetLoaiHangIDs();
            cbb_NCC.DataSource = _servicesNCC.GetMaNCC();
            cbb_Loai.DataSource = _servicesLH.GetLoaiHangIDs();

            txt_Ma.ReadOnly = true;
            ptb_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadData();
        }

        private void ptb_SanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ptb_SanPham.Image = Image.FromFile(dialog.FileName);
                    ptb_SanPham.ImageLocation = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở hình ảnh: {ex.Message}");
                }
            }
        }

        private string TaoMaSanPhamTuDong()
        {
            var allProducts = _service.GetALL();
            int max = 0;
            foreach (var sp in allProducts)
            {
                if (sp.SanPhamId.StartsWith("SP") &&
                    int.TryParse(sp.SanPhamId.Substring(2), out int num))
                {
                    max = Math.Max(max, num);
                }
            }
            return "SP" + (max + 1).ToString("D3"); // VD: SP001
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = TaoMaSanPhamTuDong();
                txt_Ma.Text = ma;

                string ten = txt_Ten.Text;
                decimal gia = Convert.ToDecimal(txt_Gia.Text);
                int soluong = Convert.ToInt32(txt_SoLuong.Text);
                string mota = txt_Mota.Text;
                string loai = cbb_LoaiSP.Text;
                string ncc = cbb_NCC.Text;
                DateOnly ngay = DateOnly.FromDateTime(dtp_Ngay.Value);
                string anh = ptb_SanPham.ImageLocation;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                SanPham sp = new SanPham()
                {
                    SanPhamId = ma,
                    TenSanPham = ten,
                    Gia = gia,
                    SoLuong = soluong,
                    MoTa = mota,
                    LoaiSanPhamId = loai,
                    MaNhaCungCap = ncc,
                    NgayCapNhat = ngay,
                    Anh = anh,
                    TrangThai = trangthai
                };

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(_service.Create(sp));
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Đã hủy thêm.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
            }
        }

        public void LoadData()
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.BorderStyle = BorderStyle.None;
            var allDatas = _service.GetALL();

            dgv_SanPham.ColumnCount = 11;
            dgv_SanPham.Columns[0].HeaderText = "STT";
            dgv_SanPham.Columns[1].HeaderText = "Mã SP";
            dgv_SanPham.Columns[2].HeaderText = "Tên SP";
            dgv_SanPham.Columns[3].HeaderText = "Mã Loại";
            dgv_SanPham.Columns[4].HeaderText = "Mã NCC";
            dgv_SanPham.Columns[5].HeaderText = "Giá";
            dgv_SanPham.Columns[6].HeaderText = "SL";
            dgv_SanPham.Columns[7].HeaderText = "Ảnh";
            dgv_SanPham.Columns[8].HeaderText = "Mô Tả";
            dgv_SanPham.Columns[9].HeaderText = "Ngày";
            dgv_SanPham.Columns[10].HeaderText = "Trạng Thái";

            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                int rowIndex = dgv_SanPham.Rows.Add(i, data.SanPhamId, data.TenSanPham, data.LoaiSanPhamId,
                    data.MaNhaCungCap, data.Gia, data.SoLuong, data.Anh, data.MoTa, data.NgayCapNhat, data.TrangThai);

                if (data.SoLuong > 0 && data.SoLuong <= 20)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                else if (data.SoLuong <= 40)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                else if (data.SoLuong <= 60)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_SanPham.Rows.Count)
            {
                DataGridViewRow row = dgv_SanPham.Rows[e.RowIndex];

                txt_Ma.Text = row.Cells[1].Value.ToString();
                txt_Ten.Text = row.Cells[2].Value.ToString();
                cbb_LoaiSP.Text = row.Cells[3].Value.ToString();
                cbb_NCC.Text = row.Cells[4].Value.ToString();
                txt_Gia.Text = row.Cells[5].Value.ToString();
                txt_SoLuong.Text = row.Cells[6].Value.ToString();

                string img = row.Cells[7].Value?.ToString();
                if (!string.IsNullOrEmpty(img) && System.IO.File.Exists(img))
                    ptb_SanPham.ImageLocation = img;
                else
                    ptb_SanPham.Image = null;

                txt_Mota.Text = row.Cells[8].Value.ToString();
                dtp_Ngay.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[10].Value);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_Ma.Text;
                string ten = txt_Ten.Text;
                decimal gia = Convert.ToDecimal(txt_Gia.Text);
                int soluong = Convert.ToInt32(txt_SoLuong.Text);
                string mota = txt_Mota.Text;
                string loai = cbb_LoaiSP.Text;
                string ncc = cbb_NCC.Text;
                DateOnly ngay = DateOnly.FromDateTime(DateTime.Now);
                string anh = ptb_SanPham.ImageLocation;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                SanPham sp = new SanPham()
                {
                    SanPhamId = ma,
                    TenSanPham = ten,
                    Gia = gia,
                    SoLuong = soluong,
                    MoTa = mota,
                    LoaiSanPhamId = loai,
                    MaNhaCungCap = ncc,
                    NgayCapNhat = ngay,
                    Anh = anh,
                    TrangThai = trangthai
                };

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(_service.Updatee(sp, ma));
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Đã hủy sửa.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi dữ liệu: " + ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            cbb_LoaiSP.SelectedIndex = -1;
            cbb_NCC.SelectedIndex = -1;
            txt_Gia.Text = "";
            txt_SoLuong.Text = "";
            ptb_SanPham.Image = null;
            txt_Mota.Text = "";
            dtp_Ngay.Value = DateTime.Now;
            cbb_TrangThai.SelectedIndex = 0;
            txt_Ma.ReadOnly = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int trangthai = cbb_tt.SelectedIndex;
            string ten = txt_Search.Text.ToLower();
            string loai = cbb_Loai.Text;

            var result = _service.GetALL().Where(sp =>
                (trangthai == -1 || sp.TrangThai == trangthai) &&
                (string.IsNullOrEmpty(ten) || sp.TenSanPham.ToLower().Contains(ten)) &&
                (string.IsNullOrEmpty(loai) || sp.LoaiSanPhamId == loai)).ToList();

            if (!result.Any())
            {
                MessageBox.Show($"Không tìm thấy sản phẩm với tên: {ten}, loại: {loai}, trạng thái: {cbb_tt.Text}");
            }

            dgv_SanPham.Rows.Clear();
            int i = 0;
            foreach (var data in result)
            {
                i++;
                int rowIndex = dgv_SanPham.Rows.Add(i, data.SanPhamId, data.TenSanPham, data.LoaiSanPhamId, data.MaNhaCungCap, data.Gia, data.SoLuong, data.Anh, data.MoTa, data.NgayCapNhat, data.TrangThai);
                if (data.SoLuong > 0 && data.SoLuong <= 20)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                else if (data.SoLuong <= 40)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                else if (data.SoLuong <= 60)
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
            }

            txt_Search.Text = "";
            cbb_tt.SelectedIndex = -1;
            cbb_Loai.SelectedIndex = -1;
        }
    }
}
