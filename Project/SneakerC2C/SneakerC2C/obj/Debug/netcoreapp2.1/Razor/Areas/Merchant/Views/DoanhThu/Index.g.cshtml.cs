#pragma checksum "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DoanhThu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305e0f67c9773cf2ca58483ba9dd6a6e6a31b35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_DoanhThu_Index), @"mvc.1.0.view", @"/Areas/Merchant/Views/DoanhThu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/DoanhThu/Index.cshtml", typeof(AspNetCore.Areas_Merchant_Views_DoanhThu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305e0f67c9773cf2ca58483ba9dd6a6e6a31b35a", @"/Areas/Merchant/Views/DoanhThu/Index.cshtml")]
    public class Areas_Merchant_Views_DoanhThu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/maintemplate/js/jquery-2.1.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DoanhThu\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MerchantManagementLayout.cshtml";

#line default
#line hidden
            BeginContext(108, 734, true);
            WriteLiteral(@"
<div class=""new_arrivals_agile_w3ls_info menu-qlsp"">
    <div class=""container"">
        <div class=""doanh_thu"">
            <h2>Doanh Thu</h2>
            <div class=""ngay_thang"">
                Từ
                <input type=""date"" id=""ngaybatdau"">
                <span>-</span>
                Đến
                <input type=""date"" id=""ngayketthuc"">
                <button class=""btn btn-primary"" type=""button"" id=""btnTim"">Tìm</button>
            </div>
            <h2 hidden id=""title-doanhthu-theongay"">Tổng Doanh Thu Theo Ngày</h2>
            <h1 id=""doanhthu-theongay""></h1>
        </div>
        <div class=""doanh_thu"">
            <h2>Tổng Doanh Thu</h2>
            <h1 style=""padding-top: 15px;"">");
            EndContext();
            BeginContext(843, 38, false);
#line 24 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\DoanhThu\Index.cshtml"
                                      Write(ViewBag.TongDoanhThu.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(881, 47, true);
            WriteLiteral(" đ</h1>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(928, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f57add2949c5452698493cee79698d4c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1012, 954, true);
            WriteLiteral(@"
<script>
    $(""#btnTim"").click(function () {
        if ($(""#ngaybatdau"").val() == null || $(""#ngaybatdau"").val() == """") {
            alert(""Vui lòng nhập ngày bắt đầu"");
            return;
        }
        if ($(""#ngayketthuc"").val() == null || $(""#ngayketthuc"").val() == """") {
            alert(""Vui lòng nhập ngày kết thúc"");
            return;
        }
        let nbd = $(""#ngaybatdau"").val();
        let nkt = $(""#ngayketthuc"").val();
        $.ajax({
            url: ""/Merchant/DoanhThu/GetTongDoanhThuTheoNgay"",
            type: ""post"",
            data: { ""nbd"": nbd, ""nkt"": nkt },
            success: function (data) {
                $(""#doanhthu-theongay"").text(data.toLocaleString('en-EN') + ' đ');
                $(""#title-doanhthu-theongay"").attr('hidden', false);
            },
            error: function (data) {
                alert(""Error: "" + data);
            }
        });
    });
</script>");
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
