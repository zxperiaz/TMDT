﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.BusinessLogicLayer;
using Models.Database;

namespace SneakerC2C.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class SanPhamController : BaseController
    {
        const int pageSize = 11;
        int pageNumber = 1;
        private readonly QLBanGiayContext ctx;
        public SanPhamController(QLBanGiayContext context)
        {
            ctx = context;
        }
        public IActionResult Index(string id)
        {
            string idd = id ?? "B77D9CF5-E9A2-4D31-9490-25E4E3971C61";
            //BUS
            SanPhamBUS sanphambus = new SanPhamBUS();
            SizeSanPhamBUS sizesanphambus = new SizeSanPhamBUS();
            GioHangBUS giohangbus = new GioHangBUS();
            SanPham sanpham = sanphambus.GetSanPham(idd);
            List<SizeSanPham> listsizesanpham = sizesanphambus.GetSize(idd);
            ViewBag.ListSizeSanPham = listsizesanpham;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View(sanpham);
        }
        //trang list san pham
        public IActionResult List(int? pagenumber)
        {
            //List<SanPham> list = ctx.SanPham.Where(x => x.PhanLoai == ploai).ToList();
            //List<SanPham> list = ctx.SanPham.Where(sp => sp.PhanLoai == ploai)
            //                                .Include(sp=>sp.IdTaiKhoanNavigation)
            //                                .Include(sp=>sp.IdHangSanPhamNavigation)
            //                                .ToList();
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            //Trang
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.GetSanPhams(pageNumber, pageSize);
            List<SanPham> tong = sanphambus.GetSanPhams();
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TrangThai = "index";
            return View(list);
        }

        public IActionResult PhanLoai(string ploai, int? pagenumber)
        {
            ploai = ploai == "Nam" ? "Nam" : "Nữ";
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            //Trang
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.GetSanPhams(ploai, pageNumber, pageSize);
            List<SanPham> tong = sanphambus.GetSanPhams(ploai);
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.PhanLoai = ploai == "Nam" ?  "Nam" : "Nu";
            ViewBag.TrangThai = "ploai";
            return View("List", list);
        }

        public IActionResult ThuongHieu(string mahang, int? pagenumber)
        {
            List<HangSanPham> listhang = ctx.HangSanPham.ToList();
            //Trang
            pageNumber = pagenumber ?? 1;
            List<SanPham> list = ctx.SanPham.Where(sp => sp.IdHangSanPhamNavigation.MaHang == mahang)
                                            .Include(sp => sp.IdTaiKhoanNavigation)
                                            .Include(sp => sp.IdHangSanPhamNavigation)
                                            .Skip((pageNumber - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToList();
            List<SanPham> tong = ctx.SanPham.Where(sp => sp.IdHangSanPhamNavigation.MaHang == mahang)
                                            .Include(sp => sp.IdTaiKhoanNavigation)
                                            .Include(sp => sp.IdHangSanPhamNavigation)
                                            .ToList();
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TrangThai = "thuonghieu";
            ViewBag.ThuongHieu = mahang;
            ViewBag.Hang = listhang;
            return View("List",list);
        }

        public IActionResult Sort(string sortorder, int? pagenumber)
        {
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.Sort(sortorder, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.Sort(sortorder);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "sort";
            ViewBag.Sort = sortorder;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult Search(string search, int? pagenumber)
        {
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.Search(search, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.Search(search, pageSize);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "search";
            ViewBag.Search = search;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult Filter(string filter, int? pagenumber)
        {
            float minprice = float.Parse(filter.Substring(filter.IndexOf('đ') + 1, filter.IndexOf(' ') - 1));
            float maxprice = float.Parse(filter.Substring(filter.LastIndexOf('đ') + 1));
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.Filter(minprice, maxprice, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.Filter(minprice, maxprice);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "filter";
            ViewBag.Filter = filter;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult FilterAndSearch(string search, string ploai, string mahang, string filter, int? pagenumber)
        {
            float minprice = float.Parse(filter.Substring(filter.IndexOf('đ') + 1, filter.IndexOf(' ') - 1));
            float maxprice = float.Parse(filter.Substring(filter.LastIndexOf('đ') + 1));
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.FilterAndSearch(minprice, maxprice, search, ploai, mahang, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.FilterAndSearch(minprice, maxprice, search, ploai, mahang);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "filterandsearch";
            ViewBag.Filter = filter;
            ViewBag.Search = search;
            ViewBag.ThuongHieu = mahang;
            if(ploai != null && ploai != "")
            {
                ViewBag.Loai = ploai == "Nam" ? "Nam" : "Nu";
            }
            else
            {
                ViewBag.PhanLoai = ploai;
            }
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult FilterAndSearchAndSort(string search, string ploai, string mahang, string filter, string sortorder, int? pagenumber)
        {
            float minprice = float.Parse(filter.Substring(filter.IndexOf('đ') + 1, filter.IndexOf(' ') - 1));
            float maxprice = float.Parse(filter.Substring(filter.LastIndexOf('đ') + 1));
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.FilterAndSearchAndSort(minprice, maxprice, search, ploai, mahang, sortorder, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.FilterAndSearchAndSort(minprice, maxprice, search, ploai, mahang, sortorder);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "filterandsearchandsort";
            ViewBag.Filter = filter;
            ViewBag.Search = search;
            ViewBag.Sort = sortorder;
            ViewBag.ThuongHieu = mahang;
            if (ploai != null && ploai != "")
            {
                ViewBag.Loai = ploai == "Nam" ? "Nam" : "Nu";
            }
            else
            {
                ViewBag.PhanLoai = ploai;
            }
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult SearchAndSort(string search, string sortorder, int? pagenumber)
        {
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.SearchAndSort(search, sortorder, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.SearchAndSort(search, sortorder, pageSize);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "searchandsort";
            ViewBag.Search = search;
            ViewBag.Sort = sortorder;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult ClassifyAndSort(string ploai, string sortorder, int? pagenumber)
        {
            ploai = ploai == "Nam" ? "Nam" : "Nữ";
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.ClassifyAndSort(ploai, sortorder, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.ClassifyAndSort(ploai, sortorder, pageSize);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "classifyandsort";
            ViewBag.PhanLoai = ploai == "Nam" ? "Nam" : "Nu";
            ViewBag.Sort = sortorder;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public IActionResult BrandAndSort(string mahang, string sortorder, int? pagenumber)
        {
            pageNumber = pagenumber ?? 1;
            SanPhamBUS sanphambus = new SanPhamBUS();
            List<SanPham> list = sanphambus.BrandAndSort(mahang, sortorder, pageSize, pageNumber);
            List<SanPham> tong = sanphambus.BrandAndSort(mahang, sortorder, pageSize);
            ViewBag.TrangHienTai = pageNumber;
            ViewBag.TongTrang = TongTrang(tong);
            ViewBag.TrangThai = "brandandsort";
            ViewBag.ThuongHieu = mahang;
            ViewBag.Sort = sortorder;
            List<HangSanPham> hang = ctx.HangSanPham.ToList();
            ViewBag.Hang = hang;
            return View("List", list);
        }

        public int TongTrang(List<SanPham> list)
        {
            return ((list.Count / pageSize) + 1);
        }
    }
}