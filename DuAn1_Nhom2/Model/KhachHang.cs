using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class KhachHang
    {
        public string KhachHangId { get; set; } = null!;

        public string? HoTen { get; set; }

        public DateOnly? NgaySinh { get; set; }

        public string? DiaChi { get; set; }

        public string? DienThoai { get; set; }

        public string? Email { get; set; }

        public byte? TrangThai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }

}
