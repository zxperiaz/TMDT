#pragma checksum "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbd892b445e5e8c7394894a110a6af521887086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_DonHang_pDiaChi), @"mvc.1.0.view", @"/Areas/Customer/Views/DonHang/pDiaChi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/DonHang/pDiaChi.cshtml", typeof(AspNetCore.Areas_Customer_Views_DonHang_pDiaChi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbd892b445e5e8c7394894a110a6af521887086", @"/Areas/Customer/Views/DonHang/pDiaChi.cshtml")]
    public class Areas_Customer_Views_DonHang_pDiaChi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Database.DiaChi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 20, true);
            WriteLiteral("\r\n<input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 51, "\"", 68, 1);
#line 3 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml"
WriteAttributeValue("", 59, Model.Id, 59, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(69, 44, true);
            WriteLiteral(" id=\"txtIdDiaChi\" readonly hidden/>\r\n<h4><b>");
            EndContext();
            BeginContext(114, 20, false);
#line 4 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml"
  Write(ViewBag.TaiKhoan.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(134, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(137, 26, false);
#line 4 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml"
                         Write(ViewBag.TaiKhoan.DienThoai);

#line default
#line hidden
            EndContext();
            BeginContext(163, 6, true);
            WriteLiteral(") </b>");
            EndContext();
            BeginContext(170, 11, false);
#line 4 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml"
                                                          Write(Model.Duong);

#line default
#line hidden
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(184, 40, false);
#line 4 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\DonHang\pDiaChi.cshtml"
                                                                        Write(Model.IdTinhThanhNavigation.TenTinhThanh);

#line default
#line hidden
            EndContext();
            BeginContext(224, 79, true);
            WriteLiteral("</h4>\r\n<a href=\"#\" data-toggle=\"modal\" data-target=\"#addressModal\">Thay Đổi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Database.DiaChi> Html { get; private set; }
    }
}
#pragma warning restore 1591
