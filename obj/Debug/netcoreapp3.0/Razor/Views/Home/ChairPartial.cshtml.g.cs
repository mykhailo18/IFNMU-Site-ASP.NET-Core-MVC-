#pragma checksum "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036a365d2e1c616d1399c3224a15b0cfa1ca6f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChairPartial), @"mvc.1.0.view", @"/Views/Home/ChairPartial.cshtml")]
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
#line 1 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036a365d2e1c616d1399c3224a15b0cfa1ca6f37", @"/Views/Home/ChairPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChairPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IFNMUSiteCore.Models.Chair>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formDocuments"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Folder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#foldersAndFiles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
  
    Layout = null;
    string classCss,path;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036a365d2e1c616d1399c3224a15b0cfa1ca6f375528", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
     foreach (Folder folder in Model.Folders)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button name=\"btn\" class=\"folder\"");
                BeginWriteAttribute("value", " value=\"", 328, "\"", 346, 1);
#nullable restore
#line 9 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
WriteAttributeValue("", 336, folder.Id, 336, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 347, "\"", 367, 1);
#nullable restore
#line 9 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
WriteAttributeValue("", 355, folder.Name, 355, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><p>");
#nullable restore
#line 9 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
                                                                                Write(folder.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></button>\r\n");
#nullable restore
#line 10 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
     foreach (File file in Model.Files)
    {
        switch (file.TypeFile)
        {
            case TypeFile.Word:
                {
                    classCss = "fileWord";
                    path = "https://view.officeapps.live.com/op/embed.aspx?src=http://" + (string)ViewBag.Host + "" + file.Path;
                    break;
                }
            case TypeFile.Excel:
                {
                    classCss = "fileExcel";
                    path = "https://view.officeapps.live.com/op/embed.aspx?src=http://" + (string)ViewBag.Host + "" + file.Path;
                    break;
                }
            case TypeFile.PowerPoint:
                {
                    classCss = "filePowerPoint";
                    path = "https://view.officeapps.live.com/op/embed.aspx?src=http://" + (string)ViewBag.Host + "" + file.Path;
                    break;
                }
            case TypeFile.PDF:
                {
                    classCss = "filePDF";
                    path = (string)ViewBag.Host + file.Path;
                    break;
                }
            case TypeFile.Image:
                {
                    classCss = "fileImage";
                    path = (string)ViewBag.Host + file.Path;
                    break;
                }
            case TypeFile.DJVU:
                {
                    classCss = "fileDJVU";
                    path = (string)ViewBag.Host + file.Path;
                    break;
                }
            default:
                {
                    classCss = "fileNone";
                    path = (string)ViewBag.Host + file.Path;
                    break;
                }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a");
                BeginWriteAttribute("class", " class=\"", 2160, "\"", 2177, 1);
#nullable restore
#line 58 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
WriteAttributeValue("", 2168, classCss, 2168, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2178, "\"", 2190, 1);
#nullable restore
#line 58 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
WriteAttributeValue("", 2185, path, 2185, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2191, "\"", 2209, 1);
#nullable restore
#line 58 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
WriteAttributeValue("", 2199, file.Name, 2199, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><p>");
#nullable restore
#line 58 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
                                                           Write(file.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></a>\r\n");
#nullable restore
#line 59 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\ChairPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IFNMUSiteCore.Models.Chair> Html { get; private set; }
    }
}
#pragma warning restore 1591