#pragma checksum "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c664def88c7fc6306319549bd44a6fa391a837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_QuanLy_pSuaSanPham), @"mvc.1.0.view", @"/Areas/Merchant/Views/QuanLy/pSuaSanPham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/QuanLy/pSuaSanPham.cshtml", typeof(AspNetCore.Areas_Merchant_Views_QuanLy_pSuaSanPham))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c664def88c7fc6306319549bd44a6fa391a837", @"/Areas/Merchant/Views/QuanLy/pSuaSanPham.cshtml")]
    public class Areas_Merchant_Views_QuanLy_pSuaSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Database.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px; height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 137, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Mã sản phẩm</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-ma\" name=\"item_sua_ma\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 169, "\"", 193, 1);
#line 4 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 177, Model.MaSanPham, 177, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(194, 164, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Tên sản phẩm</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-tensp\" name=\"item_sua_tensp\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 358, "\"", 383, 1);
#line 8 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 366, Model.TenSanPham, 366, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 151, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Màu</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-mau\" name=\"item_sua_mau\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 535, "\"", 553, 1);
#line 12 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 543, Model.Mau, 543, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(554, 146, true);
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Hãng sản phẩm</label>\r\n    <select class=\"form-control\" id=\"item-sua-hang\" name=\"item_sua_hang\">\r\n");
            EndContext();
#line 17 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
         foreach (var item in ViewBag.HangSanPham)
        {

#line default
#line hidden
            BeginContext(763, 19, true);
            WriteLiteral("            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 782, "\"", 798, 1);
#line 19 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 790, item.Id, 790, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(799, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(801, 12, false);
#line 19 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
                                Write(item.TenHang);

#line default
#line hidden
            EndContext();
            BeginContext(813, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 20 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
        }

#line default
#line hidden
            BeginContext(835, 398, true);
            WriteLiteral(@"    </select>
</div>
<div class=""form-group"">
    <label>Phân loại</label>
    <select class=""form-control"" id=""item-sua-phanloai"" name=""item_sua_phanloai"">
        <option value=""Nam"">Nam</option>
        <option value=""Nữ"">Nữ</option>
    </select>
</div>
<div class=""form-group"">
    <label>Giá</label>
    <input type=""text"" class=""form-control"" id=""item-sua-gia"" name=""item_sua_gia""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1233, "\"", 1251, 1);
#line 32 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1241, Model.Gia, 1241, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1252, 66, true);
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Hinh</label>\r\n    ");
            EndContext();
            BeginContext(1318, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ffa40e8189445dd94a3484227128c8c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1349, "~/Hinh/SanPham/", 1349, 15, true);
#line 36 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
AddHtmlAttributeValue("", 1364, Model.Hinh, 1364, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1414, 249, true);
            WriteLiteral("\r\n    <input type=\"file\" class=\"form-control\" id=\"item-sua-hinh\" name=\"item_sua_hinh\" multiple>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Chi tiết</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-chitiet\" name=\"item_sua_chitiet\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1663, "\"", 1685, 1);
#line 41 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1671, Model.ChiTiet, 1671, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1686, 155, true);
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Giảm giá</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-giamgia\" name=\"item_sua_giamgia\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1841, "\"", 1863, 1);
#line 45 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1849, Model.GiamGia, 1849, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1864, 192, true);
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Size</label>\r\n    <select class=\"form-control\" id=\"item-sua-size\" name=\"item_sua_size\">\r\n        <option value=\"không\" selected>Không</option>\r\n");
            EndContext();
#line 51 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
         foreach(var item in ViewBag.ListSizeSanPham)
        {

#line default
#line hidden
            BeginContext(2122, 19, true);
            WriteLiteral("            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2141, "\"", 2157, 1);
#line 53 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 2149, item.Id, 2149, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2160, 9, false);
#line 53 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
                                Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(2169, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 54 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
        }

#line default
#line hidden
            BeginContext(2191, 1894, true);
            WriteLiteral(@"    </select>
</div>
<div class=""form-group"">
    <label>Số lượng</label>
    <input type=""number"" class=""form-control"" id=""item-sua-soluong"" name=""item_sua_soluong"" value=""0"" readonly>
</div>
<script>
    function validateNumber(e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
            // Allow: Ctrl/cmd+A
            (e.keyCode == 65 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: Ctrl/cmd+C
            (e.keyCode == 67 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: Ctrl/cmd+X
            (e.keyCode == 88 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: home, end, left, right
            (e.keyCode >= 35 && e.keyCode <= 39)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)");
            WriteLiteral(@") && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    };
</script>
<script>
     $(""#item-sua-gia"").keydown(validateNumber);
   $(""item-sua-giamgia"").keydown(validateNumber);
    $(""#item-sua-size"").change(function(){
        let id = $(this).val();
        if (id == ""không"")
        {
            $(""#item-sua-soluong"").attr('readonly', true);
        }
        else
        {
            $(""#item-sua-soluong"").attr('readonly', false);

            $.ajax({
            url: ""/Merchant/QuanLy/GetQuantity"",
            type: ""post"",
            data: { ""id"": id },
            success: function (data) {
                $(""#item-sua-soluong"").val(data);
            },
            error: function (data) {
                alert(""Error: "" + data);
            }
        });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Database.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
