#pragma checksum "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51281fa75a6a2a599ff18a63064e68653896500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meals_Info), @"mvc.1.0.view", @"/Views/Meals/Info.cshtml")]
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
#line 1 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/_ViewImports.cshtml"
using KristaLO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
using KristaLO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51281fa75a6a2a599ff18a63064e68653896500", @"/Views/Meals/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1aa93d6eb420f37d94450146029c1b96c2d0595", @"/Views/_ViewImports.cshtml")]
    public class Views_Meals_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meals>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>");
#nullable restore
#line 4 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<table class=\"table\">\n    <tr>\n        <th>Price</th>\n        <td>");
#nullable restore
#line 9 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Meal</th>\n        <td>");
#nullable restore
#line 13 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Description</th>\n        <td>");
#nullable restore
#line 17 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Dietary Restrictions</th>\n        <td>");
#nullable restore
#line 21 "/Users/kristavaldez/Desktop/final/LastProject/KristaLO/Views/Meals/Info.cshtml"
       Write(Model.DietaryRestrictions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n\n</table>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            WriteLiteral(@"




<!--<h1>This will display only one meal, also will only show the one meal that you add</h1>

<br />
<br />
<br />




<h1>What are you cooking!</h1>

<table class=""table"">
    <tr>
        <th>Price</th>
        <td>Model.Price</td>
    </tr>
    <tr>
        <th>Meal</th>
        <td>Model.Name</td>
    </tr>
    <tr>
        <th>Description</th>
        <td>Model.Description</td>

    </tr>
    <tr>
        <th>Dietary Restriction</th>
        <td>Chosen Restrictions</td>
    </tr>


</table>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meals> Html { get; private set; }
    }
}
#pragma warning restore 1591
