﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class DoanhThu
    {
        public int DoanhThuId { get; set; }

        public DateOnly? Ngay { get; set; }

        public decimal? TongDoanhThu { get; set; }

        public Guid? HoaDonId { get; set; }

        public virtual HoaDon? HoaDon { get; set; }
    }
}
// anhtu