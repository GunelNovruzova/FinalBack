#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d347a4d21cc97bf036edc5791dbf83d07116fa16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d347a4d21cc97bf036edc5791dbf83d07116fa16", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437baa4820bc8d9fe72342d1023ce00483fc0df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addtocart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: static; opacity: 1; visibility: visible;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
           
    ViewData["Title"] = "Detail";
    string tags = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    * {
        font-family: ""Lato"";
    }


    .product-review-stars {
        padding: 20px 50px 20px 20px;
        width: 335px !important;
    }

        .product-review-stars label {
            text-shadow: 0px 0px 10px black;
        }

    .visuallyhidden {
        position: absolute !important;
        clip: rect(1px 1px 1px 1px);
        clip: rect(1px, 1px, 1px, 1px);
    }

    .product-review-stars label:after {
        content: ""★"";
        color: inherit;
        -webkit-transform: scale(4);
        position: absolute;
        z-index: 4;
        left: 0px;
        transition: all .4s;
        opacity: 0;
        color: inherit;
        visibility: hidden;
    }

    .product-review-stars input:checked + label:after {
        visibility: visible;
        -webkit-transform: scale(1);
        opacity: 1;
    }

    .product-review-stars {
        unicode-bidi: bidi-override;
        direction: rtl;
        width: 335px !important;
    }

    ");
            WriteLiteral(@"    .product-review-stars label {
            font-family: ""icomoon"";
            font-size: 2em;
            position: relative;
            cursor: pointer;
            color: #DFE3E4;
        }

        .product-review-stars input:checked ~ label:before {
            opacity: 1;
        }

        .product-review-stars:hover input ~ label:before {
            opacity: 0;
        }

        .product-review-stars input + label:before {
            content: ""\2605"";
            position: absolute;
            right: 0;
            opacity: 0;
            transition: opacity .3s ease-in-out, color .3s ease-in-out;
            backface-visibility: hidden;
            -webkit-backface-visibility: hidden; /* Chrome and Safari */
            -moz-backface-visibility: hidden; /* Firefox */
            -ms-backface-visibility: hidden; /* Internet Explorer */
        }

        .product-review-stars input + label:hover:before,
        .product-review-stars input + label:hover ~ label:befo");
            WriteLiteral(@"re {
            opacity: 1;
        }

        .product-review-stars input + label:nth-of-type(1):after,
        .product-review-stars input + label:nth-of-type(1):before,
        .product-review-stars input + label:nth-of-type(1):hover:before,
        .product-review-stars input + label:nth-of-type(1):hover ~ label:before,
        .product-review-stars input:nth-of-type(1):checked ~ label:before {
            color: #2ecc71;
        }

        .product-review-stars input + label:nth-of-type(2):after,
        .product-review-stars input + label:nth-of-type(2):before,
        .product-review-stars input + label:nth-of-type(2):hover:before,
        .product-review-stars input + label:nth-of-type(2):hover ~ label:before,
        .product-review-stars input:nth-of-type(2):checked ~ label:before {
            color: #f1c40f;
        }

        .product-review-stars input + label:nth-of-type(3):after,
        .product-review-stars input + label:nth-of-type(3):before,
        .product-review-s");
            WriteLiteral(@"tars input + label:nth-of-type(3):hover:before,
        .product-review-stars input + label:nth-of-type(3):hover ~ label:before,
        .product-review-stars input:nth-of-type(3):checked ~ label:before {
            color: #F39C12;
        }

        .product-review-stars input + label:nth-of-type(4):after,
        .product-review-stars input + label:nth-of-type(4):before,
        .product-review-stars input + label:nth-of-type(4):hover:before,
        .product-review-stars input + label:nth-of-type(4):hover ~ label:before,
        .product-review-stars input:nth-of-type(4):checked ~ label:before {
            color: #e74c3c;
        }

        .product-review-stars input + label:nth-of-type(5):after,
        .product-review-stars input + label:nth-of-type(5):before,
        .product-review-stars label:nth-of-type(5):hover:before,
        .product-review-stars input:nth-of-type(5):checked ~ label:before {
            color: #d35400;
        }

        .product-review-stars label:nth-of-t");
            WriteLiteral("ype(5):hover:before {\r\n            color: #d35400 !important;\r\n        }\r\n</style>\r\n<section class=\"shop\">\r\n    <div class=\"shop-text\">\r\n        <h1>Shop</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4473, "\"", 4480, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
        <i class=""fa-solid fa-angle-right""></i>
        <span>Products</span>
    </div>
</section>
<section class=""product-detail"" style=""margin:0px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""image"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d347a4d21cc97bf036edc5791dbf83d07116fa1611886", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4815, "~/assets/img/meals/", 4815, 19, true);
#nullable restore
#line 147 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 4834, Model.Product.Image, 4834, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-12\">\r\n                <h2>");
#nullable restore
#line 151 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
               Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 152 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
              Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <span>");
#nullable restore
#line 153 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                 Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</span>\r\n                <div class=\"amountcart\">\r\n                    <div class=\"productamount\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5219, "\"", 5226, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-minus\"></i></a>\r\n                        <span>1</span>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5333, "\"", 5340, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-plus\"></i></a>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d347a4d21cc97bf036edc5791dbf83d07116fa1614920", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                                                                         WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <h4>Category:<span>");
#nullable restore
#line 162 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                              Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                <h4>\r\n                    Tag:<span>\r\n                        ");
#nullable restore
#line 165 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                    Write(tags = string.Join(", ", Model.Product.ProductTags.Select(p => p.Tag != null ? p.Tag.Name : "")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span>
                </h4>
            </div>
        </div>
    </div>
</section>

<section class=""allreviews"">
    <div class=""product-info-tab-menu"">
        <div class=""tab"">
            <button class=""tablinks active""
                    onclick=""openInfo(event, 'Description')""
                    id=""defaultOpen"">
                Description
            </button>
            <button class=""tablinks"" onclick=""openInfo(event, 'Adittional')"">Reviews</button>

        </div>

        <div id=""Description"" class=""tabcontent"">
            <h4>Description</h4>
            <p>");
#nullable restore
#line 187 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
          Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div id=\"Adittional\" class=\"tabcontent\">\r\n            <div class=\"reviewtable\">\r\n                <p>1 review for ");
#nullable restore
#line 192 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <div class=\"all-reviews\">\r\n                    ");
#nullable restore
#line 195 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
               Write(await Html.PartialAsync("_ReviewStarPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <h3>Add a Review</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d347a4d21cc97bf036edc5791dbf83d07116fa1619868", async() => {
                WriteLiteral(@"
                    <label for=""Name"">Name</label>
                    <br>
                    <input id=""Name"" name=""Name"">
                    <br>
                    <label for=""Email"">Email</label>
                    <br>
                    <input id=""Email"" name=""Email"" type=""text"">
                    <br>

                    <label for=""Message"">Your Review</label>
                    <br />
                    <input id=""Message"" name=""Message"" type=""text"">
                    <br />
                    <label for=""Rating"">Your Rating</label>
                    <br />
                    <link href='https://fonts.googleapis.com/css?family=Lato:300,400,700,900' rel='stylesheet' type='text/css'>
                    <div class=""product-review-stars"">
                        <input type=""radio"" id=""star5"" name=""rating"" value=""5"" class=""visuallyhidden"" /><label for=""star5"" title=""Rocks!"">★</label>
                        <input type=""radio"" id=""star4"" name=""rating"" value=""4"" class");
                WriteLiteral(@"=""visuallyhidden"" /><label for=""star4"" title=""Pretty good"">★</label>
                        <input type=""radio"" id=""star3"" name=""rating"" value=""3"" class=""visuallyhidden"" /><label for=""star3"" title=""Meh"">★</label>
                        <input type=""radio"" id=""star2"" name=""rating"" value=""2"" class=""visuallyhidden"" /><label for=""star2"" title=""Kinda bad"">★</label>
                        <input type=""radio"" id=""star1"" name=""rating"" value=""1"" class=""visuallyhidden"" /><label for=""star1"" title=""Sucks big time"">★</label>
                    </div>
                    <br />
                    <a href=""#"" class=""StarRate"" data-id=""");
#nullable restore
#line 224 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                                                     Write(Model.Product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Submit</a>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"related\">\r\n    <h3>Related Products</h3>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 234 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
             foreach (Product product in Model.Products)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <div class=\"product-related\">\r\n                        <div class=\"imgcart\">\r\n                            <a href=\"shopdetail.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d347a4d21cc97bf036edc5791dbf83d07116fa1623844", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9084, "~/assets/img/meals/", 9084, 19, true);
#nullable restore
#line 240 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 9103, product.Image, 9103, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 9162, "\"", 9169, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"addtocart\">Add to cart</a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"product-text\">\r\n                        <h4>");
#nullable restore
#line 245 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span>");
#nullable restore
#line 246 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
                         Write(product.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 249 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shop\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    var star;
    $("".visuallyhidden"").click(function (e) {
        star = parseInt($(this).val());
    });
    $(document).ready(function () {
        $("".StarRate"").click(function (e) {
            e.preventDefault();
            var id = $(this).attr(""data-id"");
            var message = $(""#Message"").val();
            fetch(""../Product/Review"" + ""?rid="" + id + ""&message="" + message + ""&star="" + star).then(res => {
                return res.text()
            }).then(data => {
                console.log(data)
                if (data == 0) {
                    window.location = window.location.origin + ""/Account/Login"";
                    return;
                }
                $("".all-reviews"").html(data);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591