#pragma checksum "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b5a74721a54d8b95b14cba1cc5905361d89a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_SanPham_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/SanPham/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/SanPham/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_SanPham_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b5a74721a54d8b95b14cba1cc5905361d89a63", @"/Areas/Customer/Views/SanPham/Index.cshtml")]
    public class Areas_Customer_Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Database.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-imagezoom", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
            BeginContext(126, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(130, 20, false);
#line 7 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
Write(Context.Request.Path);

#line default
#line hidden
            EndContext();
            BeginContext(150, 896, true);
            WriteLiteral(@"</p>
<!--/single_page-->
<!-- /banner_bottom_agile_info -->
<div class=""page-head_agile_info_w3l"">
    <div class=""container"">
        <h3>Single <span>Page </span></h3>
        <!--/w3_short-->
        <div class=""services-breadcrumb"">
            <div class=""agile_inner_breadcrumb"">

                <ul class=""w3_short"">
                    <li><a href=""index.html"">Trang Chủ</a><i>|</i></li>
                    <li>Chi Tiết</li>
                </ul>
            </div>
        </div>
        <!--//w3_short-->
    </div>
</div>

<!-- banner-bootom-w3-agileits -->
<div class=""banner-bootom-w3-agileits"">
    <div class=""container"">
        <div class=""col-md-4 single-right-left "">
            <div class=""grid images_3_of_2"">
                <div class=""flexslider"">
                    <ul class=""slides"">
                        <li data-thumb=""/Hinh/SanPham/");
            EndContext();
            BeginContext(1047, 10, false);
#line 34 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                                 Write(Model.Hinh);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 58, true);
            WriteLiteral("\">\r\n                            <div class=\"thumb-image\"> ");
            EndContext();
            BeginContext(1115, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6b75bf6dd8d48fbba288c952edae4e2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1125, "~/Hinh/SanPham/", 1125, 15, true);
#line 35 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
AddHtmlAttributeValue("", 1140, Model.Hinh, 1140, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1198, 94, true);
            WriteLiteral(" </div>\r\n                        </li>\r\n                        <li data-thumb=\"/Hinh/SanPham/");
            EndContext();
            BeginContext(1293, 10, false);
#line 37 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                                 Write(Model.Hinh);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 58, true);
            WriteLiteral("\">\r\n                            <div class=\"thumb-image\"> ");
            EndContext();
            BeginContext(1361, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f35f5296a82145c6a556e6b9009e4f44", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1371, "~/Hinh/SanPham/", 1371, 15, true);
#line 38 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
AddHtmlAttributeValue("", 1386, Model.Hinh, 1386, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1444, 94, true);
            WriteLiteral(" </div>\r\n                        </li>\r\n                        <li data-thumb=\"/Hinh/SanPham/");
            EndContext();
            BeginContext(1539, 10, false);
#line 40 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                                 Write(Model.Hinh);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 58, true);
            WriteLiteral("\">\r\n                            <div class=\"thumb-image\"> ");
            EndContext();
            BeginContext(1607, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07d7ad837bbc43a494abd693c6b3549a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1617, "~/Hinh/SanPham/", 1617, 15, true);
#line 41 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
AddHtmlAttributeValue("", 1632, Model.Hinh, 1632, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1690, 264, true);
            WriteLiteral(@" </div>
                        </li>
                    </ul>
                    <div class=""clearfix""></div>
                </div>
            </div>
        </div>
        <div class=""col-md-8 single-right-left simpleCart_shelfItem"">
            <h3>");
            EndContext();
            BeginContext(1955, 16, false);
#line 49 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
           Write(Model.TenSanPham);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 50 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
             if (Model.GiamGia != null && Model.GiamGia != 0)
            {
                double gia = Model.Gia * (100 - Model.GiamGia) / 100 ?? 0;

#line default
#line hidden
            BeginContext(2132, 44, true);
            WriteLiteral("                <p><span class=\"item_price\">");
            EndContext();
            BeginContext(2177, 3, false);
#line 53 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                       Write(gia);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 19, true);
            WriteLiteral(" vnđ</span> <del>- ");
            EndContext();
            BeginContext(2200, 9, false);
#line 53 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                                              Write(Model.Gia);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 16, true);
            WriteLiteral(" VNĐ</del></p>\r\n");
            EndContext();
#line 54 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2273, 44, true);
            WriteLiteral("                <p><span class=\"item_price\">");
            EndContext();
            BeginContext(2318, 9, false);
#line 57 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                                       Write(Model.Gia);

#line default
#line hidden
            EndContext();
            BeginContext(2327, 17, true);
            WriteLiteral(" VNĐ</span></p>\r\n");
            EndContext();
#line 58 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2359, 1250, true);
            WriteLiteral(@"            <div class=""rating1"">
                <span class=""starRating"">
                    <input id=""rating5"" type=""radio"" name=""rating"" value=""5"">
                    <label for=""rating5"">5</label>
                    <input id=""rating4"" type=""radio"" name=""rating"" value=""4"">
                    <label for=""rating4"">4</label>
                    <input id=""rating3"" type=""radio"" name=""rating"" value=""3"" checked="""">
                    <label for=""rating3"">3</label>
                    <input id=""rating2"" type=""radio"" name=""rating"" value=""2"">
                    <label for=""rating2"">2</label>
                    <input id=""rating1"" type=""radio"" name=""rating"" value=""1"">
                    <label for=""rating1"">1</label>
                </span>
            </div>
            <!--<div class=""description"">
        <h5>Check delivery, payment options and charges at your location</h5>
         <form action=""#"" method=""post"">
        <input type=""text"" value=""Enter pincode"" onfocus=""this.value = ");
            WriteLiteral("\'\';\" onblur=\"if (this.value == \'\') {this.value = \'Enter pincode\';}\" required=\"\">\r\n        <input type=\"submit\" value=\"Check\">\r\n        </form>\r\n    </div>-->\r\n            <div class=\"brands-color\">\r\n                <h5>Hãng : ");
            EndContext();
            BeginContext(3610, 37, false);
#line 81 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                      Write(Model.IdHangSanPhamNavigation.TenHang);

#line default
#line hidden
            EndContext();
            BeginContext(3647, 93, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"brands-color\">\r\n                <h5>Màu : ");
            EndContext();
            BeginContext(3741, 9, false);
#line 84 "C:\doan\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Customer\Views\SanPham\Index.cshtml"
                     Write(Model.Mau);

#line default
#line hidden
            EndContext();
            BeginContext(3750, 18728, true);
            WriteLiteral(@"</h5>
            </div>
            <div class=""color-quality"">
                <div class=""color-quality-right"">
                    <h5>Size :</h5>
                    <select id=""country1"" onchange=""change_country(this.value)"" class=""frm-field required sect"">
                        <option value=""null"">35</option>
                        <option value=""null"">36</option>
                        <option value=""null"">37</option>
                        <option value=""null"">38</option>
                        <option value=""null"">39</option>
                        <option value=""null"">40</option>
                        <option value=""null"">41</option>
                        <option value=""null"">42</option>
                        <option value=""null"">43</option>
                    </select>
                </div>
            </div>
            <!--<div class=""occasional"">
        <h5>Types :</h5>
        <div class=""colr ert"">
            <label class=""radio""><input type=""radio"" name");
            WriteLiteral(@"=""radio"" checked=""""><i></i>Casual Shoes</label>
        </div>
        <div class=""colr"">
            <label class=""radio""><input type=""radio"" name=""radio""><i></i>Sneakers </label>
        </div>
        <div class=""colr"">
            <label class=""radio""><input type=""radio"" name=""radio""><i></i>Formal Shoes</label>
        </div>
        <div class=""clearfix""> </div>
    </div>-->
            <div class=""occasion-cart"">
                <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2"">
                    <form action=""#"" method=""post"">
                        <fieldset>
                            <input type=""hidden"" name=""cmd"" value=""_cart"">
                            <input type=""hidden"" name=""add"" value=""1"">
                            <input type=""hidden"" name=""business"" value="" "">
                            <input type=""hidden"" name=""item_name"" value=""Wing Sneakers"">
                            <input type=""hidden"" name=""amount"" value=");
            WriteLiteral(@"""650.00"">
                            <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                            <input type=""hidden"" name=""currency_code"" value=""USD"">
                            <input type=""hidden"" name=""return"" value="" "">
                            <input type=""hidden"" name=""cancel_return"" value="" "">
                            <input type=""submit"" name=""submit"" value=""Thêm vào giỏ hàng"" class=""button"">
                        </fieldset>
                    </form>
                </div>

            </div>
            <ul class=""social-nav model-3d-0 footer-social w3_agile_social single_page_w3ls"">
                <li class=""share"">Chia sẻ trên : </li>
                <li>
                    <a href=""#"" class=""facebook"">
                        <div class=""front""><i class=""fa fa-facebook"" aria-hidden=""true""></i></div>
                        <div class=""back""><i class=""fa fa-facebook"" aria-hidden=""true""></i></div>
                    </a>
                </");
            WriteLiteral(@"li>
                <li>
                    <a href=""#"" class=""twitter"">
                        <div class=""front""><i class=""fa fa-twitter"" aria-hidden=""true""></i></div>
                        <div class=""back""><i class=""fa fa-twitter"" aria-hidden=""true""></i></div>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""instagram"">
                        <div class=""front""><i class=""fa fa-instagram"" aria-hidden=""true""></i></div>
                        <div class=""back""><i class=""fa fa-instagram"" aria-hidden=""true""></i></div>
                    </a>
                </li>
                <li>
                    <a href=""#"" class=""pinterest"">
                        <div class=""front""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></div>
                        <div class=""back""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></div>
                    </a>
                </li>
            </ul>

        </div>
        <div class");
            WriteLiteral(@"=""clearfix""> </div>
        <!-- /new_arrivals -->
        <div class=""responsive_tabs_agileits"">
            <div id=""horizontalTab"">
                <ul class=""resp-tabs-list"">
                    <li>Description</li>
                    <li>Reviews</li>
                    <li>Information</li>
                </ul>
                <div class=""resp-tabs-container"">
                    <!--/tab_one-->
                    <div class=""tab1"">

                        <div class=""single_page_agile_its_w3ls"">
                            <h6>Lorem ipsum dolor sit amet</h6>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.</p>
                            <p class=""w3ls_pa");
            WriteLiteral(@"ra"">Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.</p>
                        </div>
                    </div>
                    <!--//tab_one-->
                    <div class=""tab2"">

                        <div class=""single_page_agile_its_w3ls"">
                            <div class=""bootstrap-tab-text-grids"">
                                <div class=""bootstrap-tab-text-grid"">
                                    <div class=""bootstrap-tab-text-grid-left"">
                                        <img src=""images/t1.jpg"" alt="" "" class=""img-responsive"">
                                    </div>
                                    <div class=""bootstrap-tab-text-grid-right"">
              ");
            WriteLiteral(@"                          <ul>
                                            <li><a href=""#"">Admin</a></li>
                                            <li><a href=""#""><i class=""fa fa-reply-all"" aria-hidden=""true""></i> Reply</a></li>
                                        </ul>
                                        <p>
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget.Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis
                                            suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem
                                            vel eum iure reprehenderit.
                                        </p>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""add-review"">
                                    <h4>add a re");
            WriteLiteral(@"view</h4>
                                    <form action=""#"" method=""post"">
                                        <input type=""text"" name=""Name"" required=""Name"">
                                        <input type=""email"" name=""Email"" required=""Email"">
                                        <textarea name=""Message"" required=""""></textarea>
                                        <input type=""submit"" value=""SEND"">
                                    </form>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""tab3"">

                        <div class=""single_page_agile_its_w3ls"">
                            <h6>Big Wing Sneakers (Navy)</h6>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tem");
            WriteLiteral(@"por incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.</p>
                            <p class=""w3ls_para"">Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- //new_arrivals -->
        <!--/slider_owl-->

        <div class=""w3_agile_latest_arrivals"">
            <h3 class=""wthree_text_info"">Featured <span>Arrivals</span></h3>
            <div class=""col-md-3 product-men single"">
                <div class=""men-pro-item simpleCart_shelfItem"">
                    <div class=""men-thumb-");
            WriteLiteral(@"item"">
                        <img src=""images/w2.jpg"" alt="""" class=""pro-image-front"">
                        <img src=""images/w2.jpg"" alt="""" class=""pro-image-back"">
                        <div class=""men-cart-pro"">
                            <div class=""inner-men-cart-pro"">
                                <a href=""single.html"" class=""link-product-add-cart"">Quick View</a>
                            </div>
                        </div>
                        <span class=""product-new-top"">New</span>

                    </div>
                    <div class=""item-info-product "">
                        <h4><a href=""single.html"">Sleeveless Solid Blue Top</a></h4>
                        <div class=""info-product-price"">
                            <span class=""item_price"">$140.99</span>
                            <del>$189.71</del>
                        </div>
                        <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2"">
    ");
            WriteLiteral(@"                        <form action=""#"" method=""post"">
                                <fieldset>
                                    <input type=""hidden"" name=""cmd"" value=""_cart"">
                                    <input type=""hidden"" name=""add"" value=""1"">
                                    <input type=""hidden"" name=""business"" value="" "">
                                    <input type=""hidden"" name=""item_name"" value=""Sleeveless Solid Blue Top"">
                                    <input type=""hidden"" name=""amount"" value=""30.99"">
                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                                    <input type=""hidden"" name=""currency_code"" value=""USD"">
                                    <input type=""hidden"" name=""return"" value="" "">
                                    <input type=""hidden"" name=""cancel_return"" value="" "">
                                    <input type=""submit"" name=""submit"" value=""Thêm vào giỏ hàng"" class=""button"">
   ");
            WriteLiteral(@"                             </fieldset>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-md-3 product-men single"">
                <div class=""men-pro-item simpleCart_shelfItem"">
                    <div class=""men-thumb-item"">
                        <img src=""images/w4.jpg"" alt="""" class=""pro-image-front"">
                        <img src=""images/w4.jpg"" alt="""" class=""pro-image-back"">
                        <div class=""men-cart-pro"">
                            <div class=""inner-men-cart-pro"">
                                <a href=""single.html"" class=""link-product-add-cart"">Quick View</a>
                            </div>
                        </div>
                        <span class=""product-new-top"">New</span>

                    </div>
                    <div class=""item-info-product "">
                        <h4><a href=""single.html"">Black Basic Shorts</a></");
            WriteLiteral(@"h4>
                        <div class=""info-product-price"">
                            <span class=""item_price"">$120.99</span>
                            <del>$189.71</del>
                        </div>
                        <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2"">
                            <form action=""#"" method=""post"">
                                <fieldset>
                                    <input type=""hidden"" name=""cmd"" value=""_cart"">
                                    <input type=""hidden"" name=""add"" value=""1"">
                                    <input type=""hidden"" name=""business"" value="" "">
                                    <input type=""hidden"" name=""item_name"" value=""Black Basic Shorts"">
                                    <input type=""hidden"" name=""amount"" value=""30.99"">
                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                                    <input type=""");
            WriteLiteral(@"hidden"" name=""currency_code"" value=""USD"">
                                    <input type=""hidden"" name=""return"" value="" "">
                                    <input type=""hidden"" name=""cancel_return"" value="" "">
                                    <input type=""submit"" name=""submit"" value=""Thêm vào giỏ hàng"" class=""button"">
                                </fieldset>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-md-3 product-men single"">
                <div class=""men-pro-item simpleCart_shelfItem"">
                    <div class=""men-thumb-item"">
                        <img src=""images/s6.jpg"" alt="""" class=""pro-image-front"">
                        <img src=""images/s6.jpg"" alt="""" class=""pro-image-back"">
                        <div class=""men-cart-pro"">
                            <div class=""inner-men-cart-pro"">
                                <a href=""single.html"" class");
            WriteLiteral(@"=""link-product-add-cart"">Quick View</a>
                            </div>
                        </div>
                        <span class=""product-new-top"">New</span>

                    </div>
                    <div class=""item-info-product "">
                        <h4><a href=""single.html"">Aero Canvas Loafers  </a></h4>
                        <div class=""info-product-price"">
                            <span class=""item_price"">$120.99</span>
                            <del>$199.71</del>
                        </div>
                        <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2"">
                            <form action=""#"" method=""post"">
                                <fieldset>
                                    <input type=""hidden"" name=""cmd"" value=""_cart"">
                                    <input type=""hidden"" name=""add"" value=""1"">
                                    <input type=""hidden"" name=""business"" value="" "">");
            WriteLiteral(@"
                                    <input type=""hidden"" name=""item_name"" value=""Aero Canvas Loafers"">
                                    <input type=""hidden"" name=""amount"" value=""30.99"">
                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                                    <input type=""hidden"" name=""currency_code"" value=""USD"">
                                    <input type=""hidden"" name=""return"" value="" "">
                                    <input type=""hidden"" name=""cancel_return"" value="" "">
                                    <input type=""submit"" name=""submit"" value=""Thêm vào giỏ hàng"" class=""button"">
                                </fieldset>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-md-3 product-men single"">
                <div class=""men-pro-item simpleCart_shelfItem"">
                    <div class=""men-thumb-item"">");
            WriteLiteral(@"
                        <img src=""images/w7.jpg"" alt="""" class=""pro-image-front"">
                        <img src=""images/w7.jpg"" alt="""" class=""pro-image-back"">
                        <div class=""men-cart-pro"">
                            <div class=""inner-men-cart-pro"">
                                <a href=""single.html"" class=""link-product-add-cart"">Quick View</a>
                            </div>
                        </div>
                        <span class=""product-new-top"">New</span>

                    </div>
                    <div class=""item-info-product "">
                        <h4><a href=""single.html"">Ankle Length Socks</a></h4>
                        <div class=""info-product-price"">
                            <span class=""item_price"">$100.99</span>
                            <del>$159.71</del>
                        </div>
                        <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2"">
                  ");
            WriteLiteral(@"          <form action=""#"" method=""post"">
                                <fieldset>
                                    <input type=""hidden"" name=""cmd"" value=""_cart"">
                                    <input type=""hidden"" name=""add"" value=""1"">
                                    <input type=""hidden"" name=""business"" value="" "">
                                    <input type=""hidden"" name=""item_name"" value=""Ankle Length Socks"">
                                    <input type=""hidden"" name=""amount"" value=""30.99"">
                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                                    <input type=""hidden"" name=""currency_code"" value=""USD"">
                                    <input type=""hidden"" name=""return"" value="" "">
                                    <input type=""hidden"" name=""cancel_return"" value="" "">
                                    <input type=""submit"" name=""submit"" value=""Thêm vào giỏ hàng"" class=""button"">
                        ");
            WriteLiteral(@"        </fieldset>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""clearfix""> </div>
            <!--//slider_owl-->
        </div>
    </div>
</div>
<!--//single_page-->");
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
