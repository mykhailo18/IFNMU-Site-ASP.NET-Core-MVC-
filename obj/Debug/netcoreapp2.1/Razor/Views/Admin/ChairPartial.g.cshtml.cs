#pragma checksum "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20cf489b2871681f08d6780b5ad31c49f8613424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ChairPartial), @"mvc.1.0.view", @"/Views/Admin/ChairPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ChairPartial.cshtml", typeof(AspNetCore.Views_Admin_ChairPartial))]
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
#line 1 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#line 2 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cf489b2871681f08d6780b5ad31c49f8613424", @"/Views/Admin/ChairPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ChairPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IFNMUSiteCore.Models.Chair>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formDocuments"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Folder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#foldersAndFiles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modalContentAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FolderAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("function () {$(\'.modalFolderAdd\').removeClass(\'active\');$(\'.modal2\').removeClass(\'active\');}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FileAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("function () {$(\'.modalFileAdd\').removeClass(\'active\');$(\'.modal3\').removeClass(\'active\');}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
  
    Layout = null;
    string classCss, path;

#line default
#line hidden
            BeginContext(90, 2460, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e18c313fd449789fd64fbfaa41d56a", async() => {
                BeginContext(233, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
     foreach (Folder folder in Model.Folders)
    {

#line default
#line hidden
                BeginContext(289, 68, true);
                WriteLiteral("    <div class=\"contBtn\">\r\n        <button name=\"btn\" class=\"folder\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 357, "\"", 375, 1);
#line 10 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 365, folder.Id, 365, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 376, "\"", 396, 1);
#line 10 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 384, folder.Name, 384, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(397, 4, true);
                WriteLiteral("><p>");
                EndContext();
                BeginContext(402, 11, false);
#line 10 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
                                                                                Write(folder.Name);

#line default
#line hidden
                EndContext();
                BeginContext(413, 93, true);
                WriteLiteral("</p></button>\r\n        <button type=\"button\" name=\"btnInfo\" class=\"btnInfoСlass\" id=\"btnInfo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 506, "\"", 524, 1);
#line 11 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 514, folder.Id, 514, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(525, 24, true);
                WriteLiteral("></button>\r\n    </div>\r\n");
                EndContext();
#line 13 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
    }

#line default
#line hidden
                BeginContext(556, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 14 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
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
                BeginContext(2300, 37, true);
                WriteLiteral("    <div class=\"contBtn\">\r\n        <a");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2337, "\"", 2356, 1);
#line 62 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 2345, classCss, 2345, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2357, "\"", 2369, 1);
#line 62 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 2364, path, 2364, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2370, "\"", 2388, 1);
#line 62 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 2378, file.Name, 2378, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2389, 4, true);
                WriteLiteral("><p>");
                EndContext();
                BeginContext(2394, 9, false);
#line 62 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
                                                             Write(file.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2403, 92, true);
                WriteLiteral("</p></a>\r\n        <button type=\"button\" name=\"btnInfo\" class=\"btnInfoСlassFile\" id=\"btnInfo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2495, "\"", 2511, 1);
#line 63 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 2503, file.Id, 2503, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2512, 24, true);
                WriteLiteral("></button>\r\n    </div>\r\n");
                EndContext();
#line 65 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(2550, 785, true);
            WriteLiteral(@"

<div class=""modal-overlay modalFolderAdd"" style=""overflow-y: auto"">
    <div class=""modal modal2"">

        <a class=""close-modal close-modal2"">
            <svg viewBox=""0 0 20 20"">
                <path fill=""#000000"" d=""M15.898,4.045c-0.271-0.272-0.713-0.272-0.986,0l-4.71,4.711L5.493,4.045c-0.272-0.272-0.714-0.272-0.986,0s-0.272,0.714,0,0.986l4.709,4.711l-4.71,4.711c-0.272,0.271-0.272,0.713,0,0.986c0.136,0.136,0.314,0.203,0.492,0.203c0.179,0,0.357-0.067,0.493-0.203l4.711-4.711l4.71,4.711c0.137,0.136,0.314,0.203,0.494,0.203c0.178,0,0.355-0.067,0.492-0.203c0.273-0.273,0.273-0.715,0-0.986l-4.711-4.711l4.711-4.711C16.172,4.759,16.172,4.317,15.898,4.045z""></path>
            </svg>
        </a><!-- close modal -->

        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(3335, 602, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e14ace1e394ff899893624310cc192", async() => {
                BeginContext(3619, 66, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"ChairId\" id=\"ChairId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3685, "\"", 3702, 1);
#line 79 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 3693, Model.Id, 3693, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3703, 227, true);
                WriteLiteral(" />\r\n                <label for=\"Name\">Введіть назву папки</label><br />\r\n                <input type=\"text\" name=\"Name\" id=\"Name\" style=\"width:80%\"><br />\r\n                <input type=\"submit\" value=\"Створити\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3937, 865, true);
            WriteLiteral(@"
        </div><!-- content -->

    </div><!-- modal -->
</div><!-- overlay -->
<div class=""modal-overlay modalFileAdd"" style=""overflow-y: auto"">
    <div class=""modal modal3"">

        <a class=""close-modal close-modal3"">
            <svg viewBox=""0 0 20 20"">
                <path fill=""#000000"" d=""M15.898,4.045c-0.271-0.272-0.713-0.272-0.986,0l-4.71,4.711L5.493,4.045c-0.272-0.272-0.714-0.272-0.986,0s-0.272,0.714,0,0.986l4.709,4.711l-4.71,4.711c-0.272,0.271-0.272,0.713,0,0.986c0.136,0.136,0.314,0.203,0.492,0.203c0.179,0,0.357-0.067,0.493-0.203l4.711-4.711l4.71,4.711c0.137,0.136,0.314,0.203,0.494,0.203c0.178,0,0.355-0.067,0.492-0.203c0.273-0.273,0.273-0.715,0-0.986l-4.711-4.711l4.711-4.711C16.172,4.759,16.172,4.317,15.898,4.045z""></path>
            </svg>
        </a><!-- close modal -->

        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(4802, 631, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17b74899d9844d9a70c69d6f7953e4b", async() => {
                BeginContext(5112, 68, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"ChairIdd\" id=\"ChairIdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5180, "\"", 5197, 1);
#line 99 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\ChairPartial.cshtml"
WriteAttributeValue("", 5188, Model.Id, 5188, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5198, 228, true);
                WriteLiteral(" />\r\n                <label for=\"Name\">Додайте файли</label>\r\n                <input type=\"file\" name=\"uploadFile\" id=\"uploadFile\" style=\"width:80%\" multiple>\r\n                <input type=\"submit\" value=\"Додати\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5433, 84, true);
            WriteLiteral("\r\n        </div><!-- content -->\r\n\r\n    </div><!-- modal -->\r\n</div><!-- overlay -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IFNMUSiteCore.Models.Chair> Html { get; private set; }
    }
}
#pragma warning restore 1591
