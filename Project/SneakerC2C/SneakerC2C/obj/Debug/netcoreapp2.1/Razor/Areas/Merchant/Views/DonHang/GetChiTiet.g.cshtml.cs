#pragma checksum "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e406102d83d32d6ec1d3091c0009de2357a9f035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_DonHang_GetChiTiet), @"mvc.1.0.view", @"/Areas/Merchant/Views/DonHang/GetChiTiet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/DonHang/GetChiTiet.cshtml", typeof(AspNetCore.Areas_Merchant_Views_DonHang_GetChiTiet))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e406102d83d32d6ec1d3091c0009de2357a9f035", @"/Areas/Merchant/Views/DonHang/GetChiTiet.cshtml")]
    public class Areas_Merchant_Views_DonHang_GetChiTiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.ChiTietDonHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
  
    ViewData["Title"] = "GetChiTiet";
    Layout = "~/Views/Shared/_MerchantManagementLayout.cshtml";

#line default
#line hidden
            BeginContext(217, 444, true);
            WriteLiteral(@"

<div class=""container-fluid bg_giohang"">
    <div class=""container"">
            <div class=""form_chuthich"">
                <div class=""form_padding_15_30"">
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-file-text-o""></i>
                        </div>
                        <div class=""donban_content"">
                            ");
            EndContext();
            BeginContext(662, 17, false);
#line 18 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                       Write(ViewBag.TinhTrang);

#line default
#line hidden
            EndContext();
            BeginContext(679, 518, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form_chuthich"">
                <div class=""form_padding_15_30"">
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-paperclip""></i>
                        </div>
                        <div class=""donban_content"">
                            ID Đơn Hàng
                            <h5>");
            EndContext();
            BeginContext(1198, 10, false);
#line 31 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                           Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 395, true);
            WriteLiteral(@"</h5>
                        </div>
                    </div>
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-map-marker""></i>
                        </div>
                        <div class=""donban_content"">
                            Địa chỉ nhận hàng
                            <h5>");
            EndContext();
            BeginContext(1604, 13, false);
#line 40 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                           Write(ViewBag.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 39, true);
            WriteLiteral("</h5>\r\n                            <h5>");
            EndContext();
            BeginContext(1657, 14, false);
#line 41 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                           Write(ViewBag.DiaChi);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 885, true);
            WriteLiteral(@"</h5>
                        </div>
                    </div>
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-truck""></i>
                        </div>
                        <div class=""donban_content"">
                            Thông Tin Vận Chuyển
                            <h5>Giao Hàng Tiết Kiệm</h5>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form_chuthich"">
                <div class=""form_padding_15_30"">
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-user""></i>
                        </div>
                        <div class=""donban_content"">
                            ");
            EndContext();
            BeginContext(2557, 11, false);
#line 62 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                       Write(ViewBag.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(2568, 549, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form_chuthich"">
                <div class=""form_padding_15_30"">
                    <div class=""ct_donban_part"">
                        <div class=""donban_icon"">
                            <i class=""fa fa-usd""></i>
                        </div>
                        <div class=""donban_content"">
                            Thông Tin Thanh Toán
                        </div>
                    </div>
");
            EndContext();
#line 77 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3190, 599, true);
            WriteLiteral(@"                        <div class=""ct_thanhtoan"">
                            <div class=""ct_tt_thanhtoan ct_tt_thanhtoan_header"">
                                <div class=""ct_sanpham_header"">Sản phẩm</div>
                                <div class=""dongia_ct"">Đơn giá</div>
                                <div class=""soluong_ct"">Số lượng</div>
                                <div class=""thanhtien_ct"">Thành tiền</div>
                            </div>
                            <div class=""ct_tt_thanhtoan"">
                                <div class=""hinh_sanpham_giohang ct_hinh""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3789, "\"", 3888, 3);
            WriteAttributeValue("", 3797, "background-image:url(/Hinh/SanPham/", 3797, 35, true);
#line 87 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
WriteAttributeValue("", 3832, item.IdSizeSanPhamNavigation.IdSanPhamNavigation.Hinh, 3832, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 3886, ");", 3886, 2, true);
            EndWriteAttribute();
            BeginContext(3889, 169, true);
            WriteLiteral("></div>\r\n                                <div class=\"form_ten_sp_giohang sanpham_ct\">\r\n                                    <h5>\r\n                                        ");
            EndContext();
            BeginContext(4059, 59, false);
#line 90 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                   Write(item.IdSizeSanPhamNavigation.IdSanPhamNavigation.TenSanPham);

#line default
#line hidden
            EndContext();
            BeginContext(4118, 142, true);
            WriteLiteral("\r\n                                    </h5>\r\n                                </div>\r\n                                <div class=\"dongia_ct\">₫ ");
            EndContext();
            BeginContext(4261, 11, false);
#line 93 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                                    Write(item.DonGia);

#line default
#line hidden
            EndContext();
            BeginContext(4272, 66, true);
            WriteLiteral("</div>\r\n                                <div class=\"soluong_ct\">x ");
            EndContext();
            BeginContext(4339, 12, false);
#line 94 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                                     Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(4351, 68, true);
            WriteLiteral("</div>\r\n                                <div class=\"thanhtien_ct\">đ ");
            EndContext();
            BeginContext(4420, 11, false);
#line 95 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                                       Write(item.DonGia);

#line default
#line hidden
            EndContext();
            BeginContext(4431, 1, true);
            WriteLiteral("*");
            EndContext();
            BeginContext(4433, 12, false);
#line 95 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                                                    Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(4445, 475, true);
            WriteLiteral(@"</div>
                            </div>
                        </div>
                        <hr>
                        <div class=""chitiet_donmua"">
                            <div class=""tong_tienhang"">
                                <div class=""txt_dathang"">
                                    <p>Tổng tiền hàng</p>
                                </div>
                                <div class=""gia_dathang"">
                                    <p>₫ ");
            EndContext();
            BeginContext(4921, 16, false);
#line 105 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                                    Write(ViewBag.TongTien);

#line default
#line hidden
            EndContext();
            BeginContext(4937, 114, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 109 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DonHang\GetChiTiet.cshtml"
                    }

#line default
#line hidden
            BeginContext(5074, 66, true);
            WriteLiteral("                </div>\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.ChiTietDonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
