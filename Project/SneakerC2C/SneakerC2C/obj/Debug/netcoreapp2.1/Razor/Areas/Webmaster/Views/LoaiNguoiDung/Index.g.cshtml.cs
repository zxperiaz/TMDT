<<<<<<< HEAD
#pragma checksum "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a38b1e4bf697a79a7db5b742efa3a38faea410"
=======
<<<<<<< HEAD
#pragma checksum "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694ee939a6f88c4c1917f6f7647d22d687e0c993"
=======
#pragma checksum "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a38b1e4bf697a79a7db5b742efa3a38faea410"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Webmaster_Views_LoaiNguoiDung_Index), @"mvc.1.0.view", @"/Areas/Webmaster/Views/LoaiNguoiDung/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Webmaster/Views/LoaiNguoiDung/Index.cshtml", typeof(AspNetCore.Areas_Webmaster_Views_LoaiNguoiDung_Index))]
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
<<<<<<< HEAD
#line 2 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
<<<<<<< HEAD
#line 2 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 2 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694ee939a6f88c4c1917f6f7647d22d687e0c993", @"/Areas/Webmaster/Views/LoaiNguoiDung/Index.cshtml")]
    public class Areas_Webmaster_Views_LoaiNguoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Models.Database.LoaiNguoiDung>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
#line 3 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
<<<<<<< HEAD
#line 3 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 3 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(176, 597, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">Danh Sách Loại Người Dùng</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<div class=""col-lg-12"">
    <div class=""panel panel-default"">
        <!-- /.panel-heading -->
        <div class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered table-hover"">
                    <!--------------------------------------------- Search And Add ------------------------------------------------->
                    <div class=""form-group"">
");
            EndContext();
#line 22 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
                        using (Html.BeginForm("Index", "LoaiNguoiDung", FormMethod.Get))
                        {

#line default
#line hidden
            BeginContext(890, 223, true);
            WriteLiteral("                            <label>Nhập Tên Loại:</label>\r\n                            <input type=\"text\" , name=\"searchString\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Tìm Kiếm</button>\r\n");
            EndContext();
#line 27 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1140, 828, true);
            WriteLiteral(@"                        <a href=""/Webmaster/LoaiNguoiDung""><button type=""submit"" class=""btn btn-primary"">Làm Mới</button></a>
                        <a href=""/Webmaster/LoaiNguoiDung/Create""><button type=""button"" class=""btn btn-warning"">Thêm Mới</button></a>
                    </div>
                    <!------------------------------------------- Loading Edit Delete ----------------------------------------------->
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Mã Loại người Dùng</th>
                            <th>Tên Loại người Dùng</th>
                            <th>Tình Trạng</th>
                            <th>Chức Năng</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
<<<<<<< HEAD
#line 42 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
<<<<<<< HEAD
#line 42 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 42 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2049, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
<<<<<<< HEAD
            BeginWriteAttribute("id", " id=\"", 2076, "\"", 2090, 2);
            WriteAttributeValue("", 2081, "row_", 2081, 4, true);
#line 44 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
WriteAttributeValue("", 2085, item, 2085, 5, false);
=======
            BeginWriteAttribute("id", " id=\"", 2053, "\"", 2067, 2);
            WriteAttributeValue("", 2058, "row_", 2058, 4, true);
#line 44 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
WriteAttributeValue("", 2062, item, 2062, 5, false);
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2091, 36, true);
            WriteLiteral(">\r\n                            <td> ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2128, 7, false);
#line 45 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
            BeginContext(2105, 7, false);
<<<<<<< HEAD
#line 45 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 45 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2176, 20, false);
#line 46 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
            BeginContext(2153, 20, false);
<<<<<<< HEAD
#line 46 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 46 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                            Write(item.MaLoaiNguoiDung);

#line default
#line hidden
            EndContext();
            BeginContext(2196, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2237, 21, false);
#line 47 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
            BeginContext(2214, 21, false);
<<<<<<< HEAD
#line 47 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 47 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                            Write(item.TenLoaiNguoiDung);

#line default
#line hidden
            EndContext();
            BeginContext(2258, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2299, 14, false);
#line 48 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
            BeginContext(2276, 14, false);
<<<<<<< HEAD
#line 48 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 48 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                            Write(item.TinhTrang);

#line default
#line hidden
            EndContext();
            BeginContext(2313, 75, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            EndContext();
<<<<<<< HEAD
            BeginWriteAttribute("href", " href=\"", 2388, "\"", 2446, 2);
            WriteAttributeValue("", 2395, "/Webmaster/LoaiNguoiDung/Edit/", 2395, 30, true);
#line 50 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
WriteAttributeValue("", 2425, item.MaLoaiNguoiDung, 2425, 21, false);
=======
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2405, 2);
            WriteAttributeValue("", 2372, "/DaiLy/Edit/", 2372, 12, true);
#line 50 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
WriteAttributeValue("", 2384, item.MaLoaiNguoiDung, 2384, 21, false);
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2447, 263, true);
            WriteLiteral(@"><button type=""button"" class=""btn btn-primary"">Sửa</button></a>
                                <button type=""button"" class=""btn btn-warning""> Khoá


                                </button>
                            </td>
                        </tr>
");
            EndContext();
<<<<<<< HEAD
#line 76 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
<<<<<<< HEAD
#line 57 "F:\GitHub\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
=======
#line 76 "D:\Projects\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Webmaster\Views\LoaiNguoiDung\Index.cshtml"
>>>>>>> 517633d7c9d65d361a150591bffb53d01d042aa9
>>>>>>> 2b68cb4586be6cd33f1687729d35741d69d8c414
                        }

#line default
#line hidden
            BeginContext(2737, 148, true);
            WriteLiteral("                    </tbody>\r\n                </table>                                                                                            \r\n");
            EndContext();
            BeginContext(2977, 148, true);
            WriteLiteral("            </div>\r\n            <!-- /.table-responsive -->\r\n        </div>\r\n        <!-- /.panel-body -->\r\n    </div>\r\n    <!-- /.panel -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Models.Database.LoaiNguoiDung>> Html { get; private set; }
    }
}
#pragma warning restore 1591
