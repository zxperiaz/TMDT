﻿using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class HopDong
    {
        public Guid Id { get; set; }
        public string MaHopDong { get; set; }
        public Guid IdNhanVien { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string ChuThich { get; set; }
        public double? Gia { get; set; }

        public NhanVien IdNhanVienNavigation { get; set; }
    }
}
