#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47985b24bee7f0896a035e95e1eebbb69c7f5a84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Table;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47985b24bee7f0896a035e95e1eebbb69c7f5a84", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437baa4820bc8d9fe72342d1023ce00483fc0df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/details/certified.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("That\'s an image "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("filtercategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TableReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-from", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""intro"">
    <div data-aos=""fade-left""
         data-aos-offset=""300""
         data-aos-easing=""ease-in-sine"" class=""all"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-12 col-md-6"">
                    <i><h6>Welcome to Our Restaurant</h6></i>
                    <h1>The Best Food For <br> The Best Moments</h1>
                    <h5>We have created for you the Prive Steak Gallery, <br> which presents the most delicious meat and <br> hosts your sincere conversations.</h5>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47985b24bee7f0896a035e95e1eebbb69c7f5a8410413", async() => {
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
            WriteLiteral(@"
    </div>
</section>
<section class=""feature"">
    <div class=""all"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5 col-12 col-md-5"">
                    <i> <h6>Welcome To Home Of Taste</h6></i>
                    <h1>A Tasty Food Is What You Deserve</h1>
                    <ul>
                        <li><i class=""fa-solid fa-check""></i>Only Fresh Food</li>
                        <li><i class=""fa-solid fa-check""></i>Quality Certified</li>
                        <li><i class=""fa-solid fa-check""></i>Best Drinks</li>
                        <li><i class=""fa-solid fa-check""></i>Easy to Order</li>
                    </ul>
                </div>
                <div class=""col-lg-7 col-12 col-md-7"">
                    <div data-aos=""flip-down"" class=""imageschef"">
                        <img class=""img1"" src=""/assets/img/chefs/_0014500.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1666, "\"", 1672, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"img2\" src=\"/assets/img/meals/_0010056.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1754, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""gallery"">
    <div class=""text"">
        <i><h6>Our Gallery</h6></i>
        <h1>Try Our Special Dishes</h1>
    </div>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-12 col-md-12"">
                <div class=""images"">
");
#nullable restore
#line 54 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                     foreach (Product product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"box\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47985b24bee7f0896a035e95e1eebbb69c7f5a8413606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2341, "~/assets/img/meals/", 2341, 19, true);
#nullable restore
#line 57 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2360, product.Image, 2360, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"overlay\"><p>");
#nullable restore
#line 58 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<section class=""details"">
    <div class=""allcontent"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-12 col-md-4"">
                    <img src=""/assets/img/details/img_1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2838, "\"", 2844, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>Fresh Products</h3>\r\n                    <p>For each dish, the growth of every <br> element & the selection</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3007, "\"", 3014, 0);
            EndWriteAttribute();
            WriteLiteral(">Discover More</a>\r\n                </div>\r\n                <div class=\"col-lg-4 col-12 col-md-4\">\r\n                    <img src=\"/assets/img/details/img_2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3175, "\"", 3181, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>Skilled Chefs</h3>\r\n                    <p>For each dish, the growth of every <br> element & the selection</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3343, "\"", 3350, 0);
            EndWriteAttribute();
            WriteLiteral(">Discover More</a>\r\n                </div>\r\n                <div class=\"col-lg-4 col-12 col-md-4\">\r\n                    <img src=\"/assets/img/details/img_3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3511, "\"", 3517, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>Best Drinks</h3>\r\n                    <p>For each dish, the growth of every <br> element & the selection</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3677, "\"", 3684, 0);
            EndWriteAttribute();
            WriteLiteral(@">Discover More</a>
                </div>

            </div>
        </div>
    </div>
</section>
<section id=""navmenu"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""prpodsCat"">
                <ul class=""nav-list"">
");
#nullable restore
#line 98 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                     foreach (Category category in ViewBag.Category)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8418345", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47985b24bee7f0896a035e95e1eebbb69c7f5a8418633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4292, "~/assets/img/meals/", 4292, 19, true);
#nullable restore
#line 102 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4311, category.Image, 4311, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <p class=\"animate__animated animate__flash animate__slower animate__infinite infinite red \">\r\n                                    ");
#nullable restore
#line 104 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </p>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                                                                                   WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                                                                                                                 Write(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 108 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <div class=\"prod\">\r\n                    ");
#nullable restore
#line 111 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_IndexCategoryPartial", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""team"">
    <div class=""allteam"">
        <div class=""team-text"">
            <i><h4>Team of  Restaurant</h4></i>
            <h1>Meet our Professionals</h1>
        </div>
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 125 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                 foreach (Team team in Model.Teams.Take(3))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div ");
            WriteLiteral(" class=\"col-lg-4 col-12 col-md-3 col-sm-3\">\r\n                        <div class=\"ceo\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5438, "\"", 5473, 2);
            WriteAttributeValue("", 5444, "/assets/img/chefs/", 5444, 18, true);
#nullable restore
#line 129 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
WriteAttributeValue("", 5462, team.Image, 5462, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5474, "\"", 5480, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"member-info\">\r\n                                <h4>");
#nullable restore
#line 131 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                               Write(team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 132 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                              Write(team.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 136 "C:\Users\User\Desktop\PriveFinal\Final\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<section class=""video"">
    <iframe src=""/assets/img/videos/Privelive (3).mp4"" frameborder=""0"" class=""vid""> </iframe>
</section>
<section class=""booking"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12 col-md-12 col-sm-12 form-text"">
                <h3>Book A Table</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8426775", async() => {
                WriteLiteral(@"
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <input id=""Name"" name=""Name"" placeholder=""Name"">
                                <select id=""Person"" name=""Person""  class=""reserve"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8427394", async() => {
                    WriteLiteral("1 Person");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8428656", async() => {
                    WriteLiteral("2 Person");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8429918", async() => {
                    WriteLiteral("4 Person");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47985b24bee7f0896a035e95e1eebbb69c7f5a8431180", async() => {
                    WriteLiteral("6 Person");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                                <input id=""Date"" name=""Date"" type=""date""  placeholder=""mm/dd/yy"">
                                <br>

                            </div>
                            <div class=""col-lg-6"">
                                <input id=""Phone"" name=""Phone""  placeholder=""Phone"">
                                <input id=""Email"" name=""Email""  placeholder=""Email ID"">

                            </div>
                            <div class=""col-lg-12"">
                                <button class=""res"" type=""submit"">Book Now</button>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-from", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["from"] = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-6 col-12 col-md-6 col-sm-6\">\r\n                <img src=\"/assets/img/interier/_54A5232.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7818, "\"", 7824, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>

        </div>
    </div>
</section>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<script>
    $(document).ready(function () {
        $("".filtercategory"").click(function (e) {
            e.preventDefault();
            var id = $(this).attr(""data-id"");
            console.log(id)
            fetch(""Home/CategoryFilter"" + ""?id="" + id).then(res => {
                return res.text()
            }).then(data => {
                $("".prod"").html(data);
            })
        })
    })
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
