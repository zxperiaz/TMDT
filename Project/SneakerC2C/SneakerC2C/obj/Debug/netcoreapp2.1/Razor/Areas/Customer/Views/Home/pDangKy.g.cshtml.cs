#pragma checksum "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c78e3742772ad0f78f5546b2b0cda9025aac3a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_pDangKy), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/pDangKy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/pDangKy.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_pDangKy))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 3 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c78e3742772ad0f78f5546b2b0cda9025aac3a4", @"/Areas/Customer/Views/Home/pDangKy.cshtml")]
    public class Areas_Customer_Views_Home_pDangKy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.TinhThanh>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaiKhoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTaiKhoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(170, 43, true);
            WriteLiteral("\r\n<h3 class=\"agileinfo_sign\">Đăng Ký</h3>\r\n");
            EndContext();
            BeginContext(213, 2714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b7d4f9397a4f4bb4d44f44042af3ad", async() => {
                BeginContext(307, 2082, true);
                WriteLiteral(@"
    <div class=""styled-input agile-styled-input-top"">
        <input type=""text"" name=""tendangnhap"" pattern="".{8,}"" required oninvalid=""this.setCustomValidity('Tên đăng nhập chứa ít nhất 8 ký tự')"" onchange=""this.setCustomValidity('')"">
        <label>Tên đăng nhập</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""password"" name=""matkhau"" pattern="".{8,}"" required oninvalid=""this.setCustomValidity('Mật khẩu chứa ít nhất 8 ký tự')"" onchange=""this.setCustomValidity('')"">
        <label>Mật khẩu</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""password"" name=""confirmmatkhau"" pattern="".{8,}"" required oninvalid=""this.setCustomValidity('Mật khẩu chứa ít nhất 8 ký tự')"" onchange=""this.setCustomValidity('')"">
        <label>Xác nhận mật khẩu</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""text"" name=""ten"" required oninvalid=""this.setCustomValidity('Cần điền vào họ tên')""");
                WriteLiteral(@" onchange=""this.setCustomValidity('')"">
        <label>Tên</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""email"" name=""email"" required oninvalid=""this.setCustomValidity('Email không đúng định dạng')"" onchange=""this.setCustomValidity('')"">
        <label>Email</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""text"" name=""dienthoai"" id=""txtDienThoai"" pattern="".{10,12}"" required oninvalid=""this.setCustomValidity('Số điện thoại chứa 10 - 12 ký tự')"" onchange=""this.setCustomValidity('')"">
        <label>Số điện thoại</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <input type=""text"" name=""diachi"" id=""txtDiaChi"" pattern="".{6,}"" required oninvalid=""this.setCustomValidity('Địa chỉ chứa ít nhất 6 ký tự')"" onchange=""this.setCustomValidity('')"">
        <label>Địa chỉ</label>
        <span></span>
    </div>
    <div class=""styled-input"">
        <select id=""cbbTinhThanh"" name=""tin");
                WriteLiteral("hthanh\" class=\"combobox-format\">\r\n");
                EndContext();
#line 45 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(2446, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(2462, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccfd58458bd442dd8f944b5aa80a0873", async() => {
                    BeginContext(2488, 17, false);
#line 47 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
                                    Write(item.TenTinhThanh);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
                   WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2514, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Code\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\Home\pDangKy.cshtml"
            }

#line default
#line hidden
                BeginContext(2531, 389, true);
                WriteLiteral(@"        </select>
        <span></span>
    </div>
    <div class=""checkbox"">
        <input type=""checkbox"" id=""chkDangKy"" required oninvalid=""this.setCustomValidity('Để đồng ý cần phải đồng ý với các điều khoản')"" onchange=""this.setCustomValidity('')""><p><a>Tôi đã đồng ý với các điều khoản khi bấm đăng ký</a></p>
    </div>
    <input type=""submit"" value=""Đăng Ký"">
    <br />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.TinhThanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
