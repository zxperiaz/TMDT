﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.BusinessLogicLayer;
using Models.Database;

namespace SneakerC2C.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TaiKhoanController : BaseController
    {
        public async Task<IActionResult> CreateTaiKhoan(string tendangnhap, string matkhau, string confirmmatkhau, string ten, string email)
        {
            string thongbao = "";
            if (matkhau != confirmmatkhau)
            {
                thongbao = "Mật khẩu không trùng nhau";
                return RedirectToAction("Index", "Home", new { thongbao = thongbao });
            }

            TaiKhoanBUS taikhoan = new TaiKhoanBUS();
            thongbao = taikhoan.CreateTaiKhoan(tendangnhap, matkhau, ten, "", email, "", "", "15CF8A9B-517E-4BAE-91E2-F30C596990ED", "Chưa kích hoạt");
            if (thongbao == "Vui lòng kiểm tra hộp thư email để kích hoạt tài khoản")
            {
                await ActivationMail(tendangnhap);
            }
            return RedirectToAction("Index", "Home", new { thongbao = thongbao });
        }

        public IActionResult EditTaiKhoan(string tendangnhap, string ten, string email, string dienthoai)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            string thongbao = taikhoanbus.EditTaiKhoan(tendangnhap, null, ten, null, email, dienthoai, null);
            return RedirectToAction("Index", "Home", new { thongbao = thongbao });
        }

        public string EditPassword(string tendangnhap, string matkhau)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            string thongbao = taikhoanbus.EditTaiKhoan(tendangnhap, matkhau, null, null, null, null, null);
            return thongbao;
        }

        public JsonResult CheckTaiKhoan(string tendangnhap)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            TaiKhoan taikhoan = taikhoanbus.CheckTaiKhoan(tendangnhap);
            return Json(taikhoan);
        }

        public IActionResult Activate(string tendangnhap)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            string thongbao = taikhoanbus.Activate(tendangnhap);
            return RedirectToAction("Index", "Home", new { thongbao = thongbao });
        }

        public async Task<string> ForgotPassword(string tendangnhap, string email)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan = taikhoanbus.CheckTaiKhoan(tendangnhap, email);
            if (taikhoan == null)
            {
                return "Thông tin không khớp";
            }
            else
            {
                await ForgotPasswordMail(tendangnhap);
            }
            taikhoanbus.AllowResetPassword(tendangnhap);
            return "Vui lòng kiểm tra hộp thư email để đặt lại mật khẩu";
        }

        public IActionResult ResetPassword(string tendangnhap, string matkhau)
        {
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            string thongbao = taikhoanbus.ResetPassword(tendangnhap, matkhau);
            return RedirectToAction("Index", "Home", new { thongbao = thongbao });
        }

        public async Task<IActionResult> ActivationMail(string tendangnhap)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            taikhoan = taikhoanbus.CheckTaiKhoan(tendangnhap);
            string kichhoat = "Để kích hoạt tài khoản, vui lòng nhấn vào link phía dưới: \n";
            var local = HttpContext.Request.Host;
            kichhoat += "https://" + local.ToString() + "/Customer/TaiKhoan/Activate?tendangnhap=" + tendangnhap;
            var client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("snkrxemail@gmail.com", "1234@abcd")
            };

            using (var message = new MailMessage("snkrxemail@gmail.com", taikhoan.Email)
            {
                Subject = "Email kích hoạt tài khoản",
                Body = kichhoat,
                Priority = MailPriority.High,
                BodyEncoding = Encoding.UTF8
            })
            {
                await client.SendMailAsync(message);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ForgotPasswordMail(string tendangnhap)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
            taikhoan = taikhoanbus.CheckTaiKhoan(tendangnhap);
            string kichhoat = "Hệ thống đã nhận được yêu cầu thay đổi mật khẩu của quý khách\n";
            kichhoat += "Xin hãy click vào đường dẫn sau để đổi mật khẩu: \n";
            var local = HttpContext.Request.Host;
            kichhoat += "https://" + local.ToString() + "/Customer/Home/ResetPassword?key=" + taikhoan.Id;
            var client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("snkrxemail@gmail.com", "1234@abcd")
            };

            using (var message = new MailMessage("snkrxemail@gmail.com", taikhoan.Email)
            {
                Subject = "Email kích hoạt tài khoản",
                Body = kichhoat,
                Priority = MailPriority.High,
                BodyEncoding = Encoding.UTF8
            })
            {
                await client.SendMailAsync(message);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}