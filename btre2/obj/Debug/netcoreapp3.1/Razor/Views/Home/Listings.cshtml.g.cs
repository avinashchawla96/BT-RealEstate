#pragma checksum "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794e01bb01c17aa6ae093739cde4a90293924bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listings), @"mvc.1.0.view", @"/Views/Home/Listings.cshtml")]
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
#line 1 "E:\Workspace\btre2\btre2\Views\_ViewImports.cshtml"
using btre2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\btre2\btre2\Views\_ViewImports.cshtml"
using btre2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Workspace\btre2\btre2\Views\_ViewImports.cshtml"
using btre2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794e01bb01c17aa6ae093739cde4a90293924bbb", @"/Views/Home/Listings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fad8109b773e2ee2d2bc88c3d3d631017ce713a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<btre2.Models.Listing>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
  
    ViewData["Title"] = "Listings";
    NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumb -->\r\n<section id=\"bc\" class=\"mt-3\">\r\n    <div class=\"container\">\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794e01bb01c17aa6ae093739cde4a90293924bbb6133", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-home\"></i> Home\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
                <li class=""breadcrumb-item active""> Browse Listings</li>
            </ol>
        </nav>
    </div>
</section>

<!-- Listings -->
<section id=""listings"" class=""py-4"">
    <div class=""container"">
        <div class=""row"">

");
#nullable restore
#line 32 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
             foreach (var item in @Model)
            {
                var daysAgo = (DateTime.Now - item.ListDate.Value).Days.ToString();
                if (daysAgo == "0")
                {
                    daysAgo = "Posted Today";
                }
                else
                {
                    daysAgo = daysAgo + "days ago";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4 mb-4\">\r\n                    <div class=\"card listing-preview\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "794e01bb01c17aa6ae093739cde4a90293924bbb8334", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1414, "~/images/", 1414, 9, true);
#nullable restore
#line 45 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
AddHtmlAttributeValue("", 1423, item.PhotoMain, 1423, 15, false);

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
            WriteLiteral("\r\n                        <div class=\"card-img-overlay\">\r\n                            <h2>\r\n                                <span class=\"badge badge-secondary text-white\">");
#nullable restore
#line 48 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                          Write(item.Price.ToString("C", nfi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </h2>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <div class=\"listing-heading text-center\">\r\n                                <h4 class=\"text-primary\">");
#nullable restore
#line 53 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                    Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>\r\n                                    <i class=\"fas fa-map-marker text-secondary\"></i> ");
#nullable restore
#line 55 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                                Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                                           Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 55 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                                                        Write(item.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <hr>
                            <div class=""row py-2 text-secondary"">
                                <div class=""col-6"">
                                    <i class=""fas fa-th-large""></i> Sqft: ");
#nullable restore
#line 61 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                     Write(item.Sqft);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <i class=\"fas fa-car\"></i> Garage: ");
#nullable restore
#line 64 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                  Write(item.Garage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row py-2 text-secondary"">
                                <div class=""col-6"">
                                    <i class=""fas fa-bed""></i> Bedrooms: ");
#nullable restore
#line 69 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                    Write(item.Bedrooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <i class=\"fas fa-bath\"></i> Bathrooms: ");
#nullable restore
#line 72 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                      Write(item.Bathrooms);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row py-2 text-secondary"">
                                <div class=""col-12"">
                                    <i class=""fas fa-user""></i> 
                                </div>
                            </div>
                            <div class=""row text-secondary pb-2"">
                                <div class=""col-6"">
                                    <i class=""fas fa-clock""></i> ");
#nullable restore
#line 83 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                            Write(daysAgo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <hr>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794e01bb01c17aa6ae093739cde4a90293924bbb14806", async() => {
                WriteLiteral("More Info");
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
#line 87 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 91 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <nav aria-label=\"Products navigation example\">\r\n            ");
#nullable restore
#line 95 "E:\Workspace\btre2\btre2\Views\Home\Listings.cshtml"
       Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </nav>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<btre2.Models.Listing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
