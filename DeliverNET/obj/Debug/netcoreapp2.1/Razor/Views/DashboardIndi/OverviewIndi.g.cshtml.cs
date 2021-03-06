#pragma checksum "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec10f5375efef864418c89459d2449ced291cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardIndi_OverviewIndi), @"mvc.1.0.view", @"/Views/DashboardIndi/OverviewIndi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DashboardIndi/OverviewIndi.cshtml", typeof(AspNetCore.Views_DashboardIndi_OverviewIndi))]
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
#line 1 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET;

#line default
#line hidden
#line 2 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET.Models;

#line default
#line hidden
#line 3 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET.Data;

#line default
#line hidden
#line 5 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET.Infrastructure.Account;

#line default
#line hidden
#line 7 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\_ViewImports.cshtml"
using DeliverNET.Managers.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec10f5375efef864418c89459d2449ced291cf6", @"/Views/DashboardIndi/OverviewIndi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3850bc768a0c373bad8ffdc3985faaeecbc40899", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardIndi_OverviewIndi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliverNET.Models.ProfileDummies.IndiDashboardDummyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
            BeginContext(130, 524, true);
            WriteLiteral(@"
<div class=""container"" style=""height:100vh"">
    <div class=""text-bone border-bottom mt-2 ml-4 pb-3"">
        <h1 style=""font-weight:300"">
            Overview
        </h1>
    </div>

    <div class=""row d-flex h-75 justify-content-around"">

        <div class=""d-flex flex-column justify-content-around"">

            <div class=""container pt-2 square"" style=""background-color:#46a079"">
                <div style=""font-size:small"">
                    Total Profit :
                    <h3 class=""pt-1"">");
            EndContext();
            BeginContext(655, 17, false);
#line 21 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml"
                                Write(Model.totalProfit);

#line default
#line hidden
            EndContext();
            BeginContext(672, 289, true);
            WriteLiteral(@" €</h3>
                    <hr />
                </div>

            </div>

            <div class=""container pt-2 square"" style=""background-color:#a35e38"">
                <div style=""font-size:small"">
                    Tips Per Order :
                    <h3 class=""pt-1"">");
            EndContext();
            BeginContext(963, 47, false);
#line 30 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml"
                                 Write(Math.Round((Model.tips / Model.totalOrders), 2));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 416, true);
            WriteLiteral(@" € <i style=""font-size:large"">/ Order</i></h3>
                    <hr />

                </div>

            </div>

        </div>

        <div class=""d-flex flex-column justify-content-around"">

            <div class=""container pt-2 square"" style=""background-color:#896490"">
                <div style=""font-size:small"">
                    Profit Per Hour :
                    <h3 class=""pt-1"">");
            EndContext();
            BeginContext(1429, 60, false);
#line 44 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml"
                                 Write(Math.Round((Model.totalProfit / Model.totalHoursWorking), 2));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 324, true);
            WriteLiteral(@" € <i style=""font-size:large"">/ h</i></h3>
                    <hr />

                </div>
            </div>

            <div class=""container pt-2 square"" style=""background-color:#a09a46"">
                <div style=""font-size:small"">
                    Orders Per Day :
                    <h3 class=""pt-1"">");
            EndContext();
            BeginContext(1816, 59, false);
#line 53 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\DashboardIndi\OverviewIndi.cshtml"
                                 Write(Math.Round((Model.totalOrders / Model.totalDaysWorking), 2));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 158, true);
            WriteLiteral(" <i style=\"font-size:large\">/ d</i></h3>\r\n                    <hr />\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliverNET.Models.ProfileDummies.IndiDashboardDummyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
