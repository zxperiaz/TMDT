#pragma checksum "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711e17e822cb4cbea05745bf4d2dc62ff1975b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_QuanLy_Index), @"mvc.1.0.view", @"/Areas/Merchant/Views/QuanLy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/QuanLy/Index.cshtml", typeof(AspNetCore.Areas_Merchant_Views_QuanLy_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711e17e822cb4cbea05745bf4d2dc62ff1975b92", @"/Areas/Merchant/Views/QuanLy/Index.cshtml")]
    public class Areas_Merchant_Views_QuanLy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Merchant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListSP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\ASP.NET\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MerchantManagementLayout.cshtml";

#line default
#line hidden
            BeginContext(160, 305, true);
            WriteLiteral(@"<div class=""container menu_knb"">
    <h2>Chào mừng đến với SNKRX - Kênh Người bán</h2>
    <p>SNKRX - Kênh Người bán là công cụ quản lý shop, giúp bạn dễ phân loại sản phẩm,</p>
    <p>theo dõi đơn hàng, chăm sóc khách hàng và đánh giá hoạt động của shop.</p>
    <div class=""menu_knb_part"">
        ");
            EndContext();
            BeginContext(465, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2412f7517963405e9e8584217fe36376", async() => {
                BeginContext(534, 147, true);
                WriteLiteral("\r\n            <div class=\"menu_knb_icon\">\r\n                <i class=\"fa fa-inbox\"></i>\r\n            </div>\r\n            <h4>Sản Phẩm</h4>\r\n        ");
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
            BeginContext(685, 1153, true);
            WriteLiteral(@"
    </div>
    <div class=""menu_knb_part"">
        <a href=""#"">
            <div class=""menu_knb_icon"">
                <i class=""fa fa-tags""></i>
            </div>
            <h4>Đơn Bán</h4>
        </a>
    </div>
    <div class=""menu_knb_part"">
        <a href=""#"">
            <div class=""menu_knb_icon"">
                <i class=""fa fa-video-camera""></i>
            </div>
            <h4>Quảng Cáo</h4>
        </a>
    </div>
    <div class=""menu_knb_part"">
        <a href=""#"">
            <div class=""menu_knb_icon"">
                <i class=""fa fa-money""></i>
            </div>
            <h4>Doanh Thu</h4>
        </a>
    </div>
    <div class=""menu_knb_part"">
        <a href=""#"">
            <div class=""menu_knb_icon"">
                <i class=""fa fa-gear ""></i>
            </div>
            <h4>Thiết Lập Shop</h4>
        </a>
    </div>
    <div class=""clearfix""></div>
    <div class=""bottom_knb"">
        <p>Bạn có thắc mắc? Ghé thăm ngay<a href=""#""> Trung t");
            WriteLiteral("âm trợ giúp Người bán</a> để tìm hiểu các mẹo,</p>\r\n        <p> câu hỏi thường gặp và tài liệu hướng dẫn.</p>\r\n    </div>\r\n</div>");
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
