#pragma checksum "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310a4f698ec6be31921285ea1acdfc2979e54fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_QuanLy_KhoaSP), @"mvc.1.0.view", @"/Areas/Merchant/Views/QuanLy/KhoaSP.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/QuanLy/KhoaSP.cshtml", typeof(AspNetCore.Areas_Merchant_Views_QuanLy_KhoaSP))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310a4f698ec6be31921285ea1acdfc2979e54fb0", @"/Areas/Merchant/Views/QuanLy/KhoaSP.cshtml")]
    public class Areas_Merchant_Views_QuanLy_KhoaSP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Merchant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListSP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KhoaSP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
  
    ViewData["Title"] = "KhoaSP";
    Layout = "~/Views/Shared/_MerchantManagementLayout.cshtml";

#line default
#line hidden
            BeginContext(206, 176, true);
            WriteLiteral("\r\n<div class=\"new_arrivals_agile_w3ls_info menu-qlsp\">\r\n    <div class=\"container\">\r\n        <div id=\"horizontalTab\">\r\n            <ul class=\"resp-tabs-list\">\r\n                ");
            EndContext();
            BeginContext(382, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66fc22b802cf4682aa11317f9cf40a05", async() => {
                BeginContext(449, 15, true);
                WriteLiteral("<li>Tất cả</li>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 190, true);
            WriteLiteral("\r\n                <a href=\"merchant-quanly-sanpham-conhang.html\"><li>còn hàng</li></a>\r\n                <a href=\"merchant-quanly-sanpham-hethang.html\"><li>hết hàng</li></a>\r\n                ");
            EndContext();
            BeginContext(658, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e38ac36bd4f47078d9675d456a5d817", async() => {
                BeginContext(725, 53, true);
                WriteLiteral("<li style=\"background-color: #fc636b\">đã bị khoá</li>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(782, 108, true);
            WriteLiteral("\r\n            </ul>\r\n            <div class=\"col-md-4 header-middle fix_timkiem_merchant\">\r\n                ");
            EndContext();
            BeginContext(890, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c571cddab1b5470aa31f1d3cf7c615d8", async() => {
                BeginContext(921, 216, true);
                WriteLiteral("\r\n                    <input type=\"search\" name=\"search\" placeholder=\"Tìm kiếm...\" required=\"\">\r\n                    <input type=\"submit\" value=\" \">\r\n                    <div class=\"clearfix\"></div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1144, 138, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"resp-tabs-container\">\r\n                <!--/tab_one-->\r\n                <div class=\"tab1\">\r\n");
            EndContext();
#line 27 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                      
                        int i = 1;
                    

#line default
#line hidden
            BeginContext(1365, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 30 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1438, 346, true);
            WriteLiteral(@"                        <div class=""col-md-3 product-men margin_merchant"">
                            <div class=""men-pro-item simpleCart_shelfItem"">
                                <div class=""men-thumb-item"">
                                    <div class=""men-thumb-item"">
                                        <div class=""anhsanpham-3""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1784, "\"", 1840, 4);
            WriteAttributeValue("", 1792, "background-image:", 1792, 17, true);
            WriteAttributeValue(" ", 1809, "url(/Hinh/SanPham/", 1810, 19, true);
#line 36 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
WriteAttributeValue("", 1828, item.Hinh, 1828, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1838, ");", 1838, 2, true);
            EndWriteAttribute();
            BeginContext(1841, 244, true);
            WriteLiteral("></div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"item-info-product \">\r\n                                    <h4><a href=\"single.html\" class=\"tieude_sanpham\">");
            EndContext();
            BeginContext(2086, 15, false);
#line 40 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                                                                Write(item.TenSanPham);

#line default
#line hidden
            EndContext();
            BeginContext(2101, 81, true);
            WriteLiteral("</a></h4>\r\n                                    <div class=\"info-product-price\">\r\n");
            EndContext();
#line 42 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                         if (item.GiamGia != null && item.GiamGia != 0)
                                        {
                                            double gia = item.Gia * (100 - item.GiamGia) / 100 ?? 0;

#line default
#line hidden
            BeginContext(2416, 72, true);
            WriteLiteral("                                            <p><span class=\"item_price\">");
            EndContext();
            BeginContext(2489, 21, false);
#line 45 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                                                   Write(gia.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 17, true);
            WriteLiteral(" đ</span> <del>- ");
            EndContext();
            BeginContext(2528, 32, false);
#line 45 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                                                                                          Write(item.Gia.Value.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 14, true);
            WriteLiteral(" đ</del></p>\r\n");
            EndContext();
#line 46 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2706, 72, true);
            WriteLiteral("                                            <p><span class=\"item_price\">");
            EndContext();
            BeginContext(2779, 32, false);
#line 49 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                                                   Write(item.Gia.Value.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(2811, 15, true);
            WriteLiteral(" đ</span></p>\r\n");
            EndContext();
#line 50 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2869, 150, true);
            WriteLiteral("                                    </div>\r\n                                    <div class=\"button-sua-xoa\">\r\n                                        ");
            EndContext();
            BeginContext(3019, 283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567a4b69bd4d4d5b98f6a8c190335cca", async() => {
                BeginContext(3025, 270, true);
                WriteLiteral(@"
                                            <input type=""button"" value=""Sửa"" class=""button-sua"" onclick=""location.href='#'"" />
                                            <input type=""submit"" value=""Xoá"" class=""button-xoa"" />
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3302, 154, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 61 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                        i++;
                        if (i % 4 == 0)
                        {

#line default
#line hidden
            BeginContext(3554, 58, true);
            WriteLiteral("                            <div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 65 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\KhoaSP.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3662, 877, true);
            WriteLiteral(@"                </div>
                <!--//tab_one-->
                <!--phân trang-->
                <ul class=""phantrang modal-1"" style=""padding-top: 1.5em;"">
                    <li><a href=""#"" class=""prev"">&laquo</a></li>
                    <li><a href=""#"" class=""active"">1</a></li>
                    <li> <a href=""#"">2</a></li>
                    <li> <a href=""#"">3</a></li>
                    <li> <a href=""#"">4</a></li>
                    <li> <a href=""#"">5</a></li>
                    <li> <a href=""#"">6</a></li>
                    <li> <a href=""#"">7</a></li>
                    <li> <a href=""#"">8</a></li>
                    <li> <a href=""#"">9</a></li>
                    <li><a href=""#"" class=""next"">&raquo;</a></li>
                </ul>
                <!--hết phân trang-->
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
