#pragma checksum "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7e7423ae3b986b2a556dcbb5a8673e385be5f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7e7423ae3b986b2a556dcbb5a8673e385be5f9", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/proNas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\About.cshtml"
  
    ViewBag.Title = "Про нас";

#line default
#line hidden
#line 4 "C:\Users\asus\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Home\About.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Style", async() => {
                BeginContext(100, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(106, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "849293ae62b54b88b2bc81d899f388f3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(155, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(160, 1605, true);
            WriteLiteral(@"<div class=""pronas"">
    <div class=""news"">
        <div>
            <h2>Новини</h2>
            <p>
                В цьому розділі будуть публікуватися новини сайта.
            </p>
        </div>
    </div>
    <div class=""instruction"">
        <h2>Інструкція</h2>
        <p>
            Вітаємо що завітали на наш сайт. На даний час ви можете використовувати такі функції:
            <ul>
                <li>Переглядати розклад занять (в ""шапці"" сайта введіть ваш номер групи і курс)</li>
                <li>Якщо ви натиснете на кнопку ""Показати"", не заповнивши дані курсу і групи, вам буде показано розклад останньої групи яку ви переглядали</li>
                <li>Переглядати тематичні плани (натисніть по назві заняття і вас перенаправить на тематичний план)</li>
            </ul>
            Також ви можете налаштувати сайт під свій смак, натисніть пункт ""Налаштування"" на шапці сайту.
        </p>
    </div>
    <div class=""propozicii"">
        <h2>Пропозиції та побажання</h2>
   ");
            WriteLiteral(@"     <div style=""width: 100%;display: flex;justify-content: center;flex-wrap: wrap;"">
            <p style=""align-items: center;display: inline-flex;margin: 2%;"">
                <img src=""https://img.icons8.com/nolan/64/000000/telegram-app.png"">
                Telegram: misha1809
            </p>
            <p style=""display: inline-flex;align-items: center;margin: 2%; padding-left:10%;"">
                <img src=""https://img.icons8.com/nolan/64/000000/email.png"">
                E-mail: mykhaylo1809@gmail.com
            </p>
        </div>
    </div>
</div>
");
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
