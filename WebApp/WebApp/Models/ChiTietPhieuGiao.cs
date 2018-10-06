﻿using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class ChiTietPhieuGiao
    {
        public Guid IdPhieuGiao { get; set; }
        public Guid IdSanPham { get; set; }
        public int? SoLuong { get; set; }
        public Guid IdHoaHong { get; set; }
        public double? Gia { get; set; }

        public HoaHong IdHoaHongNavigation { get; set; }
        public PhieuGiao IdPhieuGiaoNavigation { get; set; }
        public SanPham IdSanPhamNavigation { get; set; }
    }
}
