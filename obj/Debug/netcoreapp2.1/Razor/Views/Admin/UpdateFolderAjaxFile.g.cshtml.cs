#pragma checksum "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34655c254ed3636e3bfe1cf3e2850c6db60368fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateFolderAjaxFile), @"mvc.1.0.view", @"/Views/Admin/UpdateFolderAjaxFile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateFolderAjaxFile.cshtml", typeof(AspNetCore.Views_Admin_UpdateFolderAjaxFile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34655c254ed3636e3bfe1cf3e2850c6db60368fb", @"/Views/Admin/UpdateFolderAjaxFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateFolderAjaxFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IFNMUSiteCore.Models.File>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modalContentAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#foldersAndFiles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("function () {$(\'.modalUpdate\').removeClass(\'active\');$(\'.modal5\').removeClass(\'active\'); alert(\'Файл змінено\');}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-confirm", new global::Microsoft.AspNetCore.Html.HtmlString("Ви дійсно хочете видалити файл?"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("function () {$(\'.modalUpdate\').removeClass(\'active\');$(\'.modal5\').removeClass(\'active\'); alert(\'Файл видалено\');}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(61, 904, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb6cedd6c38745ff861037716ca94cc1", async() => {
                BeginContext(366, 44, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\" id=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 410, "\"", 427, 1);
#line 6 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 418, Model.Id, 418, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(428, 57, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ChairId\" id=\"ChairId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 485, "\"", 507, 1);
#line 7 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 493, Model.ChairId, 493, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(508, 59, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"FolderId\" id=\"FolderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 567, "\"", 590, 1);
#line 8 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 575, Model.FolderId, 575, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(591, 59, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"TypeFile\" id=\"TypeFile\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 650, "\"", 673, 1);
#line 9 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 658, Model.TypeFile, 658, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(674, 51, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Path\" id=\"Path\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 725, "\"", 744, 1);
#line 10 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 733, Model.Path, 733, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(745, 124, true);
                WriteLiteral(" />\r\n    <label for=\"Name\">Введіть нову назву файла</label>\r\n    <input style=\"width:80%;\" type=\"text\" name=\"Name\" id=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 869, "\"", 888, 1);
#line 12 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 877, Model.Name, 877, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(889, 69, true);
                WriteLiteral(" />\r\n    <input style=\"width:80%;\" type=\"submit\" value=\"Змінити\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(965, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(967, 885, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91b8b3832d834d748f4ebc732efb5af0", async() => {
                BeginContext(1325, 44, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\" id=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1369, "\"", 1386, 1);
#line 16 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1377, Model.Id, 1377, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1387, 57, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ChairId\" id=\"ChairId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1444, "\"", 1466, 1);
#line 17 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1452, Model.ChairId, 1452, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1467, 59, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"FolderId\" id=\"FolderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1526, "\"", 1549, 1);
#line 18 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1534, Model.FolderId, 1534, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1550, 59, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"TypeFile\" id=\"TypeFile\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1609, "\"", 1632, 1);
#line 19 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1617, Model.TypeFile, 1617, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1633, 51, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Path\" id=\"Path\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1684, "\"", 1703, 1);
#line 20 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1692, Model.Path, 1692, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1704, 51, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Name\" id=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1755, "\"", 1774, 1);
#line 21 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\UpdateFolderAjaxFile.cshtml"
WriteAttributeValue("", 1763, Model.Name, 1763, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1775, 70, true);
                WriteLiteral(" />\r\n    <input style=\"width:80%;\" type=\"submit\" value=\"Видалити\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IFNMUSiteCore.Models.File> Html { get; private set; }
    }
}
#pragma warning restore 1591