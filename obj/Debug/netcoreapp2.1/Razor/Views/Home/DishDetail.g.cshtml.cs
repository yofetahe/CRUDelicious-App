#pragma checksum "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27b4622ccd7db4cf2842b0760ffd2a25b8f264e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishDetail), @"mvc.1.0.view", @"/Views/Home/DishDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DishDetail.cshtml", typeof(AspNetCore.Views_Home_DishDetail))]
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
#line 1 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27b4622ccd7db4cf2842b0760ffd2a25b8f264e", @"/Views/Home/DishDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 112, true);
            WriteLiteral("\r\n<div class=\"breadcrum\">\r\n    <a href=\"/\">Home</a>\r\n</div>\r\n\r\n<div class=\"header-title\">\r\n    <p class=\"title\">");
            EndContext();
            BeginContext(128, 10, false);
#line 8 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(138, 14, true);
            WriteLiteral("</p>\r\n    <p> ");
            EndContext();
            BeginContext(153, 10, false);
#line 9 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
   Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(163, 39, true);
            WriteLiteral(" </p>\r\n</div>\r\n\r\n<hr>\r\n\r\n<div>\r\n    <p>");
            EndContext();
            BeginContext(203, 17, false);
#line 15 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(220, 23, true);
            WriteLiteral("</p>\r\n    <p>Calories: ");
            EndContext();
            BeginContext(244, 14, false);
#line 16 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
            Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(258, 23, true);
            WriteLiteral("</p>\r\n    <p>Tasiness: ");
            EndContext();
            BeginContext(282, 15, false);
#line 17 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
            Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(297, 29, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 326, "\"", 354, 2);
            WriteAttributeValue("", 333, "/delete/", 333, 8, true);
#line 21 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
WriteAttributeValue("", 341, Model.DishId, 341, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 43, true);
            WriteLiteral(" class=\"btn btn-primary\">Delete</a>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 398, "\"", 424, 2);
            WriteAttributeValue("", 405, "/edit/", 405, 6, true);
#line 22 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\CRUDelicious\Views\Home\DishDetail.cshtml"
WriteAttributeValue("", 411, Model.DishId, 411, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 49, true);
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591