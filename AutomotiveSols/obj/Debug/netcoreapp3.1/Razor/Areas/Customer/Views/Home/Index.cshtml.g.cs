#pragma checksum "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcdfb71d5af2b11b1ead2d2cb4f9fcb9428ace8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\_ViewImports.cshtml"
using AutomotiveSols;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\_ViewImports.cshtml"
using AutomotiveSols.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcdfb71d5af2b11b1ead2d2cb4f9fcb9428ace8", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941992a470b79c1a7b24451a467a83ee011bb263", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutomotiveSols.BLL.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:2px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsPart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br />\n<br />\n\n<div class=\"row\">\n");
#nullable restore
#line 7 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var service in Model.Services)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4\">\n    <div class=\"card mb-4\">\n        <div class=\"card-header\">\n            <h4 class=\"my-0 font-weight-normal\">\n                <label style=\"font-size:23px;color:black;\">");
#nullable restore
#line 13 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                                      Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            </h4>\n        </div>\n\n        <img class=\"card-img-top\" style=\"height:100%;\"");
            BeginWriteAttribute("src", " src=\"", 437, "\"", 460, 1);
#nullable restore
#line 17 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 443, service.ImageUrl, 443, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card Image\" />\n        <div class=\"card-body\">\n            <div class=\"d-flex justify-content-between align-items-center\">\n                <div class=\"btn-group\">\n                    <label style=\"font-size:20px; color:#a51313\"><b>Rs.");
#nullable restore
#line 21 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                                                  Write(service.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\n                </div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcdfb71d5af2b11b1ead2d2cb4f9fcb9428ace86917", async() => {
                WriteLiteral(" View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                WriteLiteral(service.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n</div>");
#nullable restore
#line 28 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 31 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
 foreach (var category in Model.CategoryList.OrderBy(o => o.DisplayOrder))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.AutoPartList.Where(c => c.CategoryId == category.Id).Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row container pb-3 backgroundWhite\">\n    <div class=\"col-12\">\n        <div class=\"row\">\n            <h4 class=\"text-dark\"><b>");
#nullable restore
#line 38 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\n\n            <div class=\"col-12\">\n                <div class=\"row my-3\">\n");
#nullable restore
#line 42 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                     foreach (var part in Model.AutoPartList.Where(c => c.CategoryId == category.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-xl-3 col-md-6 pb-4\">\n    <div class=\"card\" style=\"border:2px solid black;border-radius:5px; background:url(\'/images/leaves.png\')\">\n        <div class=\"pl-3 pt-1 text-center\">\n            <h3 class=\"card-title text-dark\"><b>");
#nullable restore
#line 47 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(part.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\n        </div>\n        <div class=\"d-flex justify-content-between \">\n            <div class=\"pl-1 text-muted\">Price </div>\n            <div class=\"pr-1 text-danger h5\">$");
#nullable restore
#line 51 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                         Write(part.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        <img");
            BeginWriteAttribute("src", " src=\"", 1964, "\"", 1988, 1);
#nullable restore
#line 53 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1970, part.MainImageUrl, 1970, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-2 rounded\" />\n\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 55 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 56 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.SubCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 57 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcdfb71d5af2b11b1ead2d2cb4f9fcb9428ace813477", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                                                                      WriteLiteral(part.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
#nullable restore
#line 61 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 66 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 68 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
 foreach (var brand in Model.Brands.OrderBy(o => o.Name))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Cars.Where(c => c.BranId == brand.Id).Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row container pb-3 backgroundWhite\">\n    <div class=\"col-12\">\n        <div class=\"row\">\n            <h4 class=\"text-dark\"><b>");
#nullable restore
#line 75 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                Write(brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\n\n            <div class=\"col-12\">\n                <div class=\"row my-3\">\n");
#nullable restore
#line 79 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                     foreach (var part in Model.Cars.Where(c => c.BranId == brand.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-xl-3 col-md-6 pb-4\">\n    <div class=\"card\" style=\"border:2px solid black;border-radius:5px; background:url(\'/images/leaves.png\')\">\n        <div class=\"pl-3 pt-1 text-center\">\n            <h3 class=\"card-title text-dark\"><b>");
#nullable restore
#line 84 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(part.Trim.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\n        </div>\n        <div class=\"d-flex justify-content-between \">\n            <div class=\"pl-1 text-muted\">Price </div>\n            <div class=\"pr-1 text-danger h5\">$");
#nullable restore
#line 88 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                         Write(part.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        <img");
            BeginWriteAttribute("src", " src=\"", 3431, "\"", 3452, 1);
#nullable restore
#line 90 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 3437, part.MainImage, 3437, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-2 rounded\" />\n\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 92 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.Year.SolarYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 93 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.RegistrationCity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 94 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                            Write(part.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcdfb71d5af2b11b1ead2d2cb4f9fcb9428ace820156", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
                                                                                     WriteLiteral(part.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
#nullable restore
#line 98 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 103 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "F:\dotnet\AutomotiveSols\AutomotiveSols\Areas\Customer\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutomotiveSols.BLL.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591