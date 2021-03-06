#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ce9d8554fec8c2a937e8609d66d0b687f8f840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamagotchis_Index), @"mvc.1.0.view", @"/Views/Tamagotchis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tamagotchis/Index.cshtml", typeof(AspNetCore.Views_Tamagotchis_Index))]
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
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
using TamagotchiGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ce9d8554fec8c2a937e8609d66d0b687f8f840", @"/Views/Tamagotchis/Index.cshtml")]
    public class Views_Tamagotchis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/eachTamagotchi.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/gameOver.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(57, 92, true);
            WriteLiteral("\n<div class=\"container\">\n  <h1>Your Tamagotchis!</h1>\n\n  <div class=\"tamagotchi-container\">\n");
            EndContext();
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(182, 37, true);
            WriteLiteral("      <p>You have no Tamagotchis</p>\n");
            EndContext();
#line 14 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(225, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if (tamagotchi.GetLife())
      {

#line default
#line hidden
            BeginContext(317, 28, true);
            WriteLiteral("        <div>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 345, "\"", 379, 2);
            WriteAttributeValue("", 352, "/tamagotchis/", 352, 13, true);
#line 20 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
WriteAttributeValue("", 365, tamagotchi.Id, 365, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(380, 16, true);
            WriteLiteral(">\n              ");
            EndContext();
            BeginContext(396, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ce9d8554fec8c2a937e8609d66d0b687f8f8405473", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 15, true);
            WriteLiteral("\n              ");
            EndContext();
            BeginContext(448, 15, false);
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
         Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(463, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(466, 15, false);
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                           Write(tamagotchi.Food);

#line default
#line hidden
            EndContext();
            BeginContext(481, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(484, 16, false);
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                             Write(tamagotchi.Sleep);

#line default
#line hidden
            EndContext();
            BeginContext(500, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(503, 20, false);
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                Write(tamagotchi.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(523, 33, true);
            WriteLiteral("\n            </a>\n        </div>\n");
            EndContext();
#line 25 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(570, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 28 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if(@tamagotchi.GetLife() == false)
      {

#line default
#line hidden
            BeginContext(672, 23, true);
            WriteLiteral("        <li>\n          ");
            EndContext();
            BeginContext(695, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21ce9d8554fec8c2a937e8609d66d0b687f8f8408811", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(725, 11, true);
            WriteLiteral("\n          ");
            EndContext();
            BeginContext(737, 15, false);
#line 34 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(752, 24, true);
            WriteLiteral(" is dead.\n        </li>\n");
            EndContext();
#line 36 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(790, 301, true);
            WriteLiteral(@"  </div>



  <form action=""/tamagotchis/time"" method=""post"">
    <button class=""btn"" type=""submit"" name=""button"">Pass Time</button>
  </form>

  <div class=""footer"">
    <a href=""/tamagotchis/new"">Add A Tamagotchi</a>
    <a href=""/tamagotchis/deleteAll"">Delete All Tamagotchis</a>
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
