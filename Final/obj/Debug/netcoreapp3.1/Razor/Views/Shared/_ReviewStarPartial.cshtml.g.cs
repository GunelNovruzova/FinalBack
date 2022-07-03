#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9902b2e9cfd6f7094ecd400d8f555798d4edb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ReviewStarPartial), @"mvc.1.0.view", @"/Views/Shared/_ReviewStarPartial.cshtml")]
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
#nullable restore
#line 13 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.About;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9902b2e9cfd6f7094ecd400d8f555798d4edb9", @"/Views/Shared/_ReviewStarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ea13f67d450b6aad687ab571e80b5256fdb9fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ReviewStarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style>
        .reviewtext{
            position:relative;
        }
        .deletecommentprod {
            position: absolute;
            right: 37px;
            bottom: 20px;
            text-decoration: none;
            padding: 6px 20px;
            border: 2px solid #cfa86e;
            color: #ff6a00;
            border-radius: 56%
        }
        .icons{
            margin-bottom:20px;
        }
    </style>
");
#nullable restore
#line 20 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
 foreach (Review review in Model.Reviews)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"reviewtext\">\r\n        <div class=\"com\">\r\n            <p>");
#nullable restore
#line 24 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
          Write(review.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 24 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
                             Write(review.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n            <h5>");
#nullable restore
#line 25 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
           Write(review.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"icons\" style=\"color:#FFC107;\">\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
                 for (int i = 0; i < review.Star; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fa-solid fa-star\"></i>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <a data-id=\"");
#nullable restore
#line 33 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
                   Write(review.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-bid=\"");
#nullable restore
#line 33 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
                                         Write(review.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"deletecommentprod\">Delete</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\PriveFinal\Final\Views\Shared\_ReviewStarPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
