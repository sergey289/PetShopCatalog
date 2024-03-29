#pragma checksum "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59059e15dba3fcc02a988879d57773d437c60450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Catalog), @"mvc.1.0.view", @"/Views/User/Catalog.cshtml")]
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
#line 1 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\_ViewImports.cshtml"
using PetShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\_ViewImports.cshtml"
using PetShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59059e15dba3fcc02a988879d57773d437c60450", @"/Views/User/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9cb11fa8dfc4463cdadb982486cbc1eda18e7a4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PetShop.Models.Animals>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n    <h2 class=\" text-center\">List of animals</h2>\r\n    <br />\r\n    <select onchange=\"location = this.value;\">\r\n");
#nullable restore
#line 11 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
     foreach (Categories item in @ViewBag.categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59059e15dba3fcc02a988879d57773d437c604503807", async() => {
#nullable restore
#line 13 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/User/ByCategories/");
#nullable restore
#line 13 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
                           WriteLiteral(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("?limit=50");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    <br />
    <br />

    <div class=""container"">

        <div class=""row"">
            <div class=""col-12"">


                <table class=""table table-image"">
                    <thead>
                        <tr>
                            <th scope=""col"">Portrait</th>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">For more information</th>

                        </tr>
                    </thead>
");
#nullable restore
#line 35 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>\r\n                                <img class=\"img-fluid img-thumbnail\" style=\"height:80px;width:100px;\"");
            BeginWriteAttribute("src", " src=\"", 1131, "\"", 1168, 1);
#nullable restore
#line 40 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
WriteAttributeValue("", 1137, Url.Content(@item.PictureName), 1137, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"button\" class=\"btn-outline-primary\" value=\"Details\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1404, "\"", 1491, 3);
            WriteAttributeValue("", 1414, "location.href=\'", 1414, 15, true);
#nullable restore
#line 44 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
WriteAttributeValue("", 1429, Url.Action("AnimalInfo", "User", new { id = item.AnimalID }), 1429, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1490, "\'", 1490, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 48 "C:\Users\sergey\Desktop\PetShop\PetShop\Views\User\Catalog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PetShop.Models.Animals>> Html { get; private set; }
    }
}
#pragma warning restore 1591
