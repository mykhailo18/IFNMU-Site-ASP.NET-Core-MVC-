#pragma checksum "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70127f1915e0cf8ce4eceae1108b782316d4a734"
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
#line 1 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#line 2 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70127f1915e0cf8ce4eceae1108b782316d4a734", @"/Views/Admin/AddLesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddLesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<byte>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
  Layout = null;
    

#line default
#line hidden
            BeginContext(38, 135, true);
            WriteLiteral("<div style=\"border-bottom: 2px solid green; border-top: 2px solid green; padding: 5% 0;\">\r\n    <div class=\"form-group\">\r\n        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 173, "\"", 222, 3);
            WriteAttributeValue("", 179, "ScheduleDays[", 179, 13, true);
#line 6 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 192, Model, 192, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 198, "].Lessons[].LessonNumber", 198, 24, true);
            EndWriteAttribute();
            BeginContext(223, 59, true);
            WriteLiteral(">Номер заняття</label>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 282, "\"", 332, 3);
            WriteAttributeValue("", 289, "ScheduleDays[", 289, 13, true);
#line 7 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 302, Model, 302, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 308, "].Lessons[].LessonNumber", 308, 24, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 333, "\"", 381, 3);
            WriteAttributeValue("", 338, "ScheduleDays[", 338, 13, true);
#line 7 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 351, Model, 351, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 357, "].Lessons[].LessonNumber", 357, 24, true);
            EndWriteAttribute();
            BeginContext(382, 84, true);
            WriteLiteral(" type=\"number\" value=\"\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 466, "\"", 507, 3);
            WriteAttributeValue("", 472, "ScheduleDays[", 472, 13, true);
#line 11 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 485, Model, 485, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 491, "].Lessons[].Name", 491, 16, true);
            EndWriteAttribute();
            BeginContext(508, 59, true);
            WriteLiteral(">Назва заняття</label>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 567, "\"", 609, 3);
            WriteAttributeValue("", 574, "ScheduleDays[", 574, 13, true);
#line 12 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 587, Model, 587, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 593, "].Lessons[].Name", 593, 16, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 610, "\"", 650, 3);
            WriteAttributeValue("", 615, "ScheduleDays[", 615, 13, true);
#line 12 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 628, Model, 628, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 634, "].Lessons[].Name", 634, 16, true);
            EndWriteAttribute();
            BeginContext(651, 82, true);
            WriteLiteral(" type=\"text\" value=\"\">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 733, "\"", 784, 3);
            WriteAttributeValue("", 739, "ScheduleDays[", 739, 13, true);
#line 16 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 752, Model, 752, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 758, "].Lessons[].ThematicPlanId", 758, 26, true);
            EndWriteAttribute();
            BeginContext(785, 50, true);
            WriteLiteral(">Виберіть тематичний план</label>\r\n        <select");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 835, "\"", 887, 3);
            WriteAttributeValue("", 842, "ScheduleDays[", 842, 13, true);
#line 17 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 855, Model, 855, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 861, "].Lessons[].ThematicPlanId", 861, 26, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 888, "\"", 938, 3);
            WriteAttributeValue("", 893, "ScheduleDays[", 893, 13, true);
#line 17 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 906, Model, 906, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 912, "].Lessons[].ThematicPlanId", 912, 26, true);
            EndWriteAttribute();
            BeginContext(939, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(954, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e6eb60419a4095b14ac38239ee4551", async() => {
                BeginContext(973, 4, true);
                WriteLiteral("None");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(986, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
             foreach (var i in ViewBag.ThematicPlan)
            {

#line default
#line hidden
            BeginContext(1057, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1073, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa19699184a4deaa1334f667fd72e6e", async() => {
                BeginContext(1095, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1097, 6, false);
#line 21 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                  Write(i.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1103, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
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
            BeginContext(1113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
            }

#line default
#line hidden
            BeginContext(1130, 75, true);
            WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1205, "\"", 1267, 3);
            WriteAttributeValue("", 1211, "ScheduleDays[", 1211, 13, true);
#line 26 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 1224, Model, 1224, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1230, "].Lessons[].MethodicalRecomendationId", 1230, 37, true);
            EndWriteAttribute();
            BeginContext(1268, 50, true);
            WriteLiteral(">Виберіть тематичний план</label>\r\n        <select");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1318, "\"", 1381, 3);
            WriteAttributeValue("", 1325, "ScheduleDays[", 1325, 13, true);
#line 27 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 1338, Model, 1338, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1344, "].Lessons[].MethodicalRecomendationId", 1344, 37, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1382, "\"", 1443, 3);
            WriteAttributeValue("", 1387, "ScheduleDays[", 1387, 13, true);
#line 27 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
WriteAttributeValue("", 1400, Model, 1400, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1406, "].Lessons[].MethodicalRecomendationId", 1406, 37, true);
            EndWriteAttribute();
            BeginContext(1444, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1459, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbe505aff6a34a1da047f905be8de161", async() => {
                BeginContext(1478, 4, true);
                WriteLiteral("None");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
             foreach (var i in ViewBag.MethodicRecomentadion)
            {

#line default
#line hidden
            BeginContext(1571, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1587, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23065aef0d9414782855d53d44d52a2", async() => {
                BeginContext(1612, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1614, 6, false);
#line 31 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
                                     Write(i.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1620, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
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
            BeginContext(1630, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Admin\AddLesson.cshtml"
            }

#line default
#line hidden
            BeginContext(1647, 45, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<byte> Html { get; private set; }
    }
}
#pragma warning restore 1591
