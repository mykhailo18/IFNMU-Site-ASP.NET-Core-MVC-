#pragma checksum "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1adc415fb15d32c81d7a30f40723f609fc43de7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddLesson), @"mvc.1.0.view", @"/Views/Admin/AddLesson.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AddLesson.cshtml", typeof(AspNetCore.Views_Admin_AddLesson))]
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
#line 1 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#line 2 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1adc415fb15d32c81d7a30f40723f609fc43de7", @"/Views/Admin/AddLesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddLesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
  Layout = null;

#line default
#line hidden
            BeginContext(19, 619, true);
            WriteLiteral(@"
<div style=""border-bottom: 2px solid green; border-top: 2px solid green; padding: 5% 0;"">
    <div class=""form-group"">
        <label for=""LessonNumber"">Номер заняття</label>
        <input class=""form-control"" id=""LessonNumber"" name=""LessonNumber"" type=""text"" value="""">
    </div>

    <div class=""form-group"">
        <label for=""Name"">Назва заняття</label>
        <input class=""form-control"" id=""Name"" name=""Name"" type=""text"" value="""">
    </div>

    <div class=""form-group"">
        <label for=""ThematicPlan"">Виберіть тематичний план</label>
        <select id=""ThematicPlan"" name=""ThematicPlan"">
");
            EndContext();
#line 17 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
             foreach (var i in ViewBag.ThematicPlan)
            {

#line default
#line hidden
            BeginContext(707, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(723, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c68f6d79404ca1b736d16c6f2c68f2", async() => {
                BeginContext(746, 11, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                 Write(i.NameChair);

#line default
#line hidden
                EndContext();
                BeginContext(757, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(761, 12, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                                Write(i.NameLesson);

#line default
#line hidden
                EndContext();
                BeginContext(773, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(777, 9, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                                                Write(i.Courses);

#line default
#line hidden
                EndContext();
                BeginContext(786, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(790, 15, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                                                             Write(i.NameSpecialty);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                   WriteLiteral(i.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(814, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
            }

#line default
#line hidden
            BeginContext(831, 45, true);
            WriteLiteral("        </select>\r\n    </div>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
