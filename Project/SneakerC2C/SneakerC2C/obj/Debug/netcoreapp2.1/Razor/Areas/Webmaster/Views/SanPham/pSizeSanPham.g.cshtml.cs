#pragma checksum "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cbfbb74aaf927812228088b64ff065302e3fe88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Webmaster_Views_SanPham_pSizeSanPham), @"mvc.1.0.view", @"/Areas/Webmaster/Views/SanPham/pSizeSanPham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Webmaster/Views/SanPham/pSizeSanPham.cshtml", typeof(AspNetCore.Areas_Webmaster_Views_SanPham_pSizeSanPham))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cbfbb74aaf927812228088b64ff065302e3fe88", @"/Areas/Webmaster/Views/SanPham/pSizeSanPham.cshtml")]
    public class Areas_Webmaster_Views_SanPham_pSizeSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.SizeSanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 375, true);
            WriteLiteral(@"
<table class=""table table-striped table-bordered table-hover"">
    <thead>
        <tr>
            <th style=""text-align: center; line-height: 74px;"">Tên sản phẩm</th>
            <th style=""text-align: center; line-height: 74px;"">Size</th>
            <th style=""text-align: center; line-height: 74px;"">Số lượng</th>
        </tr>
    </thead>
    
    <tbody>
");
            EndContext();
#line 13 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
         foreach (var item in Model)
        {
            if (item.SoLuong > 0)
            {

#line default
#line hidden
            BeginContext(523, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(570, 35, false);
#line 18 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.IdSanPhamNavigation.TenSanPham);

#line default
#line hidden
            EndContext();
            BeginContext(605, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(637, 9, false);
#line 19 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(646, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(678, 12, false);
#line 20 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(690, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "D:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(746, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.SizeSanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
