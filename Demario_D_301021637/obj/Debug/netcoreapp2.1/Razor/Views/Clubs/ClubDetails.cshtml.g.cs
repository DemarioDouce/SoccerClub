#pragma checksum "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702e534a9ccc4152793faf51972c9fba6b127097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_ClubDetails), @"mvc.1.0.view", @"/Views/Clubs/ClubDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clubs/ClubDetails.cshtml", typeof(AspNetCore.Views_Clubs_ClubDetails))]
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
#line 1 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Demario_D_301021637.Models;

#line default
#line hidden
#line 2 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Demario_D_301021637.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702e534a9ccc4152793faf51972c9fba6b127097", @"/Views/Clubs/ClubDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7989228140c7d5d789c555437cb387b971163615", @"/Views/_ViewImports.cshtml")]
    public class Views_Clubs_ClubDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clubs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clubs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateClub", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteClub", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Players", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
  
    Layout = "_DefaultLayout";
    ViewBag.Title = "ClubDetails";

#line default
#line hidden
            BeginContext(91, 363, true);
            WriteLiteral(@"

<title>Club Details - Dream League Soccer</title>


<h2 class=""cover-heading"">CLUB DETAILS</h2>

<table class=""table table-dark"" border=""1"">
    <thead>
        <tr>
            <th scope=""col"">Club Name</th>
            <th scope=""col"">Club Manager</th>
            <th scope=""col"">Club Details</th>
            <th scope=""col"">Created By</th>

");
            EndContext();
#line 22 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
             if (SignInManager.IsSignedIn(User))
            {
                

#line default
#line hidden
#line 24 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                 if (User.Identity.Name == Model.createdBy)
                {

#line default
#line hidden
            BeginContext(599, 62, true);
            WriteLiteral("                    <th scope=\"col\" colspan=\"2\">Actions</th>\r\n");
            EndContext();
#line 27 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                }

#line default
#line hidden
#line 27 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(695, 74, true);
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(770, 14, false);
#line 34 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
           Write(Model.ClubName);

#line default
#line hidden
            EndContext();
            BeginContext(784, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(808, 17, false);
#line 35 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
           Write(Model.ClubManager);

#line default
#line hidden
            EndContext();
            BeginContext(825, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(849, 17, false);
#line 36 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
           Write(Model.ClubDetails);

#line default
#line hidden
            EndContext();
            BeginContext(866, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(890, 15, false);
#line 37 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
           Write(Model.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(905, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 39 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
             if (SignInManager.IsSignedIn(User))
            {
                

#line default
#line hidden
#line 41 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                 if (User.Identity.Name == Model.createdBy)
                {

#line default
#line hidden
            BeginContext(1059, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1109, 378, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702e534a9ccc4152793faf51972c9fba6b1270979998", async() => {
                BeginContext(1115, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1145, 220, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702e534a9ccc4152793faf51972c9fba6b12709710411", async() => {
                    BeginContext(1291, 70, true);
                    WriteLiteral("\r\n                                UPDATE\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ClubId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                                     WriteLiteral(Model.ClubID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ClubId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ClubId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ClubId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1365, 64, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ClubId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1429, "\"", 1450, 1);
#line 49 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
WriteAttributeValue("", 1437, Model.ClubID, 1437, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1451, 29, true);
                WriteLiteral(" />\r\n                        ");
                EndContext();
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
            EndContext();
            BeginContext(1487, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1566, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702e534a9ccc4152793faf51972c9fba6b12709714923", async() => {
                BeginContext(1633, 64, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ClubId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1697, "\"", 1718, 1);
#line 54 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
WriteAttributeValue("", 1705, Model.ClubID, 1705, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1719, 190, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                DELETE\r\n                            </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1916, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 60 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                }

#line default
#line hidden
#line 60 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1979, 236, true);
            WriteLiteral("\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<table class=\"table table-dark\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\" colspan=\"100\">Players Signed</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n\r\n");
            EndContext();
#line 76 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
             foreach (var p in ViewBag.Players)
            {

#line default
#line hidden
            BeginContext(2279, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(2300, 12, false);
#line 78 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
               Write(p.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(2312, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 79 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Clubs\ClubDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(2334, 41, true);
            WriteLiteral("        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2375, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702e534a9ccc4152793faf51972c9fba6b12709719334", async() => {
                BeginContext(2463, 10, true);
                WriteLiteral("ADD PLAYER");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clubs> Html { get; private set; }
    }
}
#pragma warning restore 1591
