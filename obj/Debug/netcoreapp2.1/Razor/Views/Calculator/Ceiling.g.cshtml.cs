#pragma checksum "C:\Users\Administrator\Desktop\MyWebCalculator\Views\Calculator\Ceiling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72badb4d3cedb3566783734b13f8542862f2c61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Ceiling), @"mvc.1.0.view", @"/Views/Calculator/Ceiling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Ceiling.cshtml", typeof(AspNetCore.Views_Calculator_Ceiling))]
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
#line 1 "C:\Users\Administrator\Desktop\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72badb4d3cedb3566783734b13f8542862f2c61e", @"/Views/Calculator/Ceiling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c788849adb963fe4eeed78e8014b0d891663bd30", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Ceiling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Desktop\MyWebCalculator\Views\Calculator\Ceiling.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 28, true);
            WriteLiteral("\n<h1>Ceiling Result</h1>\n<p>");
            EndContext();
            BeginContext(53, 25, false);
#line 6 "C:\Users\Administrator\Desktop\MyWebCalculator\Views\Calculator\Ceiling.cshtml"
Write(ViewData["CeilingResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(78, 6, true);
            WriteLiteral("</p>\n\n");
            EndContext();
#line 8 "C:\Users\Administrator\Desktop\MyWebCalculator\Views\Calculator\Ceiling.cshtml"
  
    double num = Convert.ToDouble(ViewData["Num"]);
    double result = Math.Round((Math.Ceiling(num)),2);

#line default
#line hidden
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
