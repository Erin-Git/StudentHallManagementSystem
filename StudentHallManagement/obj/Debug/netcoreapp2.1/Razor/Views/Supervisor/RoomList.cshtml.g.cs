#pragma checksum "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619f28315a7c03c76b26f009df0941c7b23f492f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supervisor_RoomList), @"mvc.1.0.view", @"/Views/Supervisor/RoomList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Supervisor/RoomList.cshtml", typeof(AspNetCore.Views_Supervisor_RoomList))]
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
#line 1 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\_ViewImports.cshtml"
using StudentHallManagement;

#line default
#line hidden
#line 2 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\_ViewImports.cshtml"
using StudentHallManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619f28315a7c03c76b26f009df0941c7b23f492f", @"/Views/Supervisor/RoomList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca87bc28b776b570619476c215b45728997132ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Supervisor_RoomList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentHallManagement.ViewModels.RoomViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Supervisor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 797, true);
            WriteLiteral(@"
<style>
    #formdiv {
        background-color: #fff;
        padding: 30px;
        margin-top: 3%;
        border: 2px solid rebeccapurple;
        border-radius: 5px;
    }

    h2 {
        text-align: center;
    }
    hr {
        margin-bottom: 5%;
    }
    table {
        text-align: center;
    }

    th {
        text-align: center;
    }
</style>
<div class=""col-lg-9 col-lg-offset-2"" id=""formdiv"">

    <h2>List of Room</h2>
    <hr />
    <table class=""table table-responsive"">
        <thead>
            <tr>
                <th>Serial No</th>
                <th>Room Name</th>
                <th>Room Capacity</th>
                <th>Available</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 42 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(915, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(962, 15, false);
#line 45 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
                   Write(item.serialnoVM);

#line default
#line hidden
            EndContext();
            BeginContext(977, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1009, 15, false);
#line 46 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
                   Write(item.roomnameVM);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1056, 19, false);
#line 47 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
                   Write(item.roomcapacityVM);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1107, 20, false);
#line 48 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
                   Write(item.availablilityVM);

#line default
#line hidden
            EndContext();
            BeginContext(1127, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1184, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb9d8c4c1894f3184803b8576026b86", async() => {
                BeginContext(1279, 129, true);
                WriteLiteral("\r\n                            <i class=\"fa fa-pencil-square-o\" style=\"font-size:25px;color:green;\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idupdateroom", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
                                                                                           WriteLiteral(item.roomidVM);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idupdateroom"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idupdateroom", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idupdateroom"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1412, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 55 "C:\Users\ERIN\Desktop\9th\System\StudentHallManagement\StudentHallManagement\Views\Supervisor\RoomList.cshtml"
            }

#line default
#line hidden
            BeginContext(1479, 46, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentHallManagement.ViewModels.RoomViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
