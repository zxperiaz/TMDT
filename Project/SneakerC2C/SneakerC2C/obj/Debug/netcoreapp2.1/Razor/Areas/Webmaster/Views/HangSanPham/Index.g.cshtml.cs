#pragma checksum "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980d6aee77644361fa0ccbeba977929d5edad344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Webmaster_Views_HangSanPham_Index), @"mvc.1.0.view", @"/Areas/Webmaster/Views/HangSanPham/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Webmaster/Views/HangSanPham/Index.cshtml", typeof(AspNetCore.Areas_Webmaster_Views_HangSanPham_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980d6aee77644361fa0ccbeba977929d5edad344", @"/Areas/Webmaster/Views/HangSanPham/Index.cshtml")]
    public class Areas_Webmaster_Views_HangSanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.HangSanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Webmaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LockHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnlockHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemHangSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SuaHangSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(196, 486, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h2 class=""page-header"">DANH SÁCH HÃNG SẢN PHẨM</h2>
    </div>
    <!-- /.col-lg-12 -->
</div>
<div class=""panel panel-default"">
    <div class=""panel-body"">
        <!-- Search form -->
        <div class=""row"">
            <div class=""col-lg-1"">
                <button class=""btn btn-primary btnThem"" data-toggle=""modal"" data-target=""#themModal"">Thêm</button>
            </div>
            <div class=""col-lg-2"">
");
            EndContext();
            BeginContext(1447, 114, true);
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-6\"></div>\r\n            <div class=\"col-lg-3\">\r\n                ");
            EndContext();
            BeginContext(1561, 577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6be9fa788762429f8377c82fb9e939f2", async() => {
                BeginContext(1629, 502, true);
                WriteLiteral(@"
                    <div class=""input-group custom-search-form"">
                        <input type=""text"" class=""form-control"" id=""searchList"" placeholder=""Tìm kiếm..."" name=""search"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""submit"">
                                <i class=""fa fa-search""></i>
                            </button>
                        </span>

                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2138, 312, true);
            WriteLiteral(@"
            </div>
        </div>
        <!--Table-->
        <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
            <thead class=""thead-dark"">
                <tr class=""odd gradeX"">
                    <th>Mã hãng</th>
                    <th>");
            EndContext();
            BeginContext(2450, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e546412a1094c76b9a33b992fe0ceef", async() => {
                BeginContext(2606, 8, true);
                WriteLiteral("Tên hãng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortorder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                                                                                    WriteLiteral(ViewBag.NameSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortorder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortorder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortorder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 51 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                                                                                                                                WriteLiteral(ViewBag.CurrentFilter);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2618, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(3271, 118, true);
            WriteLiteral("                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"body-content\">\r\n");
            EndContext();
#line 64 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3454, 70, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"item-ma\">");
            EndContext();
            BeginContext(3525, 11, false);
#line 67 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                       Write(item.MaHang);

#line default
#line hidden
            EndContext();
            BeginContext(3536, 52, true);
            WriteLiteral("</td>\r\n                        <td class=\"item-ten\">");
            EndContext();
            BeginContext(3589, 12, false);
#line 68 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                        Write(item.TenHang);

#line default
#line hidden
            EndContext();
            BeginContext(3601, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 70 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                             switch (item.TinhTrang)
                            {
                                case "Không khoá":

#line default
#line hidden
            BeginContext(3775, 182, true);
            WriteLiteral("                                    <button class=\"btn btn-danger btnSua\" type=\"button\" data-toggle=\"modal\" data-target=\"#suaModal\">Sửa</button>\r\n                                    ");
            EndContext();
            BeginContext(3957, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aedea5e1ea04067abbfaf42f325e731", async() => {
                BeginContext(4066, 4, true);
                WriteLiteral("Khoá");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahang", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                                                                                WriteLiteral(item.MaHang);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahang"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahang", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahang"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4074, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                    break;
                                case "Khoá":

#line default
#line hidden
            BeginContext(4166, 182, true);
            WriteLiteral("                                    <button class=\"btn btn-danger btnSua\" type=\"button\" data-toggle=\"modal\" data-target=\"#suaModal\">Sửa</button>\r\n                                    ");
            EndContext();
            BeginContext(4348, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1952c44b472d4d61b600a811845cca6f", async() => {
                BeginContext(4459, 7, true);
                WriteLiteral("Mở khoá");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahang", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                                                                                  WriteLiteral(item.MaHang);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahang"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahang", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahang"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4470, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                                    break;
                            }

#line default
#line hidden
            BeginContext(4547, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4624, 42, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n");
            EndContext();
            BeginContext(7593, 148, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"modal fade\" id=\"themModal\" role=\"dialog\">\r\n    <div class=\"modal-dialog\">\r\n        <!-- Modal content-->\r\n        ");
            EndContext();
            BeginContext(7741, 1215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e11867bc9a430387adc76210fe027d", async() => {
                BeginContext(7819, 312, true);
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">Hãng sản phẩm</h4>
                </div>
                <div class=""modal-body"">
");
                EndContext();
                BeginContext(8390, 559, true);
                WriteLiteral(@"                    <div class=""form-group"">
                        <label>Tên hãng</label>
                        <input type=""text"" class=""form-control"" id=""item-them-ten"" name=""item_them_ten"" required>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-warning"" id=""btnThemHangSp"">Thêm</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Đóng</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8956, 147, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"modal fade\" id=\"suaModal\" role=\"dialog\">\r\n    <div class=\"modal-dialog\">\r\n        <!-- Modal content-->\r\n        ");
            EndContext();
            BeginContext(9103, 1157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bfa61277d074ceca0bf267f13374e0b", async() => {
                BeginContext(9180, 1073, true);
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">Hãng sản phẩm</h4>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label>Mã hãng</label>
                        <input type=""text"" class=""form-control"" id=""item-sua-ma"" name=""item_sua_ma"" readonly>
                    </div>
                    <div class=""form-group"">
                        <label>Tên hãng</label>
                        <input type=""text"" class=""form-control"" id=""item-sua-ten"" name=""item_sua_ten"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-warning"">Sửa</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Đóng</button>
   ");
                WriteLiteral("             </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10260, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 201 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
 if (ViewBag.ThongBao != null)
{

#line default
#line hidden
            BeginContext(10317, 29, true);
            WriteLiteral("    <script>\r\n        alert(\"");
            EndContext();
            BeginContext(10347, 26, false);
#line 204 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(10373, 20, true);
            WriteLiteral("\");\r\n    </script>\r\n");
            EndContext();
#line 206 "F:\Github stuffs\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\HangSanPham\Index.cshtml"
}

#line default
#line hidden
            BeginContext(10396, 362, true);
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $("".btnSua"").click(function () {
            let pId = $(this).closest('tr').find('.item-ma').text();
            let pTen = $(this).closest('tr').find('.item-ten').text();
            $(""#item-sua-ma"").val(pId.trim());
            $(""#item-sua-ten"").val(pTen.trim());
        });
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.HangSanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
