using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class NhanVien
    {
        public string NhanVienId { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? HoTen { get; set; }

        public string? DienThoai { get; set; }

        public byte? ChucVu { get; set; }

        public byte? TrangThai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }

}
