<<<<<<< HEAD
#pragma checksum "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c48730f21e409a844e86238aa681158a925e996"
=======
#pragma checksum "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9421a0f9633d3e2fa6b29412186e7e6b7fc1c70a"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Webmaster_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Webmaster/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Webmaster/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Webmaster_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c48730f21e409a844e86238aa681158a925e996", @"/Areas/Webmaster/Views/Home/Index.cshtml")]
    public class Areas_Webmaster_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
#line 2 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
=======
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(147, 1945, true);
            WriteLiteral(@"

<h2>Trang chủ</h2>

<div id=""wrapper"">
    <div id=""content-wrapper"">
        <div class=""container-fluid"">
            <!-- Breadcrumbs-->
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">
                    <a href=""#"">Dashboard</a>
                </li>
                <li class=""breadcrumb-item active"">Charts</li>
            </ol>
            <!-- Area Chart Example-->
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-chart-area""></i>
                    Tổng Doanh Thu Các Merchant Theo Tháng:
                </div>
                <div class=""card-body"">
                    <canvas id=""myAreaChart"" width=""100%"" height=""30""></canvas>
                </div>
            </div>
            <!-- 2 Chart Example-->
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""card mb-3"">
                        <div class=""card-header"">
        ");
            WriteLiteral(@"                    <i class=""fas fa-chart-bar""></i>
                            Bar Chart Example
                        </div>
                        <div class=""card-body"">
                            <canvas id=""myBarChart"" width=""100%"" height=""50""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""card mb-3"">
                        <div class=""card-header"">
                            <i class=""fas fa-chart-pie""></i>
                            Pie Chart Example
                        </div>
                        <div class=""card-body"">
                            <canvas id=""myPieChart"" width=""100%"" height=""100""></canvas>
                        </div>
                    </div>
                </div>
            </div>





        </div>
    </div>
</div>

");
            EndContext();
<<<<<<< HEAD
#line 64 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
=======
#line 9 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
 if (ViewBag.ThongBao != null)
{

#line default
#line hidden
            BeginContext(2127, 29, true);
            WriteLiteral("    <script>\r\n        alert(\"");
            EndContext();
<<<<<<< HEAD
            BeginContext(2157, 26, false);
#line 67 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
=======
            BeginContext(184, 26, false);
#line 12 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 20, true);
            WriteLiteral("\");\r\n    </script>\r\n");
            EndContext();
<<<<<<< HEAD
#line 69 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
=======
#line 14 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\Home\Index.cshtml"
>>>>>>> b97e3c82312ede63dab98bc1645a6b3df03bb71a
}

#line default
#line hidden
            BeginContext(2206, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
