<<<<<<< HEAD
#pragma checksum "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819f1e81e3c01262eb1d4e7b2b46b42add88ed88"
=======
#pragma checksum "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628fadbb9020757699e9074820d742166dbc6d21"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628fadbb9020757699e9074820d742166dbc6d21", @"/Areas/Webmaster/Views/SanPham/pSizeSanPham.cshtml")]
    public class Areas_Webmaster_Views_SanPham_pSizeSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.SizeSanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 226, true);
            WriteLiteral("\r\n<table table table-striped table-bordered table-hover>\r\n    <thead>\r\n        <tr>\r\n            <th>Tên sản phẩm</th>\r\n            <th>Size</th>\r\n            <th>Số lượng</th>\r\n        </tr>\r\n    </thead>\r\n    \r\n    <tbody>\r\n");
            EndContext();
<<<<<<< HEAD
#line 13 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
         foreach(var item in Model)
=======
#line 13 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
         foreach (var item in Model)
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
        {
            if (item.SoLuong > 0)
            {

#line default
#line hidden
            BeginContext(374, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(362, 35, false);
#line 16 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
               Write(item.IdSanPhamNavigation.TenSanPham);
=======
            BeginContext(421, 35, false);
#line 18 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.IdSanPhamNavigation.TenSanPham);
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a

#line default
#line hidden
            EndContext();
            BeginContext(456, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(425, 9, false);
#line 17 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
               Write(item.Size);
=======
            BeginContext(488, 9, false);
#line 19 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.Size);
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a

#line default
#line hidden
            EndContext();
            BeginContext(497, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(462, 12, false);
#line 18 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
               Write(item.SoLuong);
=======
            BeginContext(529, 12, false);
#line 20 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
                   Write(item.SoLuong);
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a

#line default
#line hidden
            EndContext();
            BeginContext(541, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
<<<<<<< HEAD
#line 20 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
=======
#line 22 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\SanPham\pSizeSanPham.cshtml"
            }
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
        }

#line default
#line hidden
            BeginContext(597, 22, true);
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
