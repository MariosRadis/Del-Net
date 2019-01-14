#pragma checksum "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c53650f28de7e68d2b8e0d518cd7c91ae3814d1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfileBusi_SettingsBusi), @"mvc.1.0.view", @"/Views/ProfileBusi/SettingsBusi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProfileBusi/SettingsBusi.cshtml", typeof(AspNetCore.Views_ProfileBusi_SettingsBusi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53650f28de7e68d2b8e0d518cd7c91ae3814d1b", @"/Views/ProfileBusi/SettingsBusi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3850bc768a0c373bad8ffdc3985faaeecbc40899", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfileBusi_SettingsBusi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SettingsBusiPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
  
    ViewData["Title"] = "Profile Settings";
    Layout = "~/Views/Shared/_LayoutBusi.cshtml";
    DeliverNETUser user = await UserManager.FindByNameAsync(User.Identity.Name);

#line default
#line hidden
            BeginContext(238, 2092, true);
            WriteLiteral(@"
<div class=""container p-4"">

    <div class=""row"">

        <!-- Options -->
        <div class=""col-md-6"">

            <div class=""d-flex flex-column justify-content-around"" style=""height:100vh"">

                <!-- Profile Settings btn -->
                <a class=""d-flex align-items-center justify-content-start"" id=""btnSett"">

                    <div class=""btn bg-jet-3d circle text-bone align-items-center d-flex"" id=""circleSett"">
                        <i class=""fas fa-user-edit m-auto"" style=""font-size: 33px""></i>
                    </div>

                    <div class=""btn col-md-5 bg-jet-3d text-bone py-1""
                         style=""border-radius:20px;font-size:25px;"" id=""labSett"">
                        Profile Settings
                    </div>

                </a>

                <!-- Edit Information btn -->
                <a class=""d-flex align-items-center justify-content-start"" id=""btnInfo"">

                    <div class=""btn bg-jet-3d circle text-");
            WriteLiteral(@"bone align-items-center d-flex"" id=""circleInfo"">
                        <i class=""fas fa-unlock-alt m-auto"" style=""font-size: 33px""></i>
                    </div>

                    <div class=""btn col-md-5 bg-jet-3d text-bone py-1""
                         style=""border-radius:20px;font-size:25px;"" id=""labInfo"">
                        Edit Info
                    </div>

                </a>

                <!-- Help btn -->
                <a class=""d-flex align-items-center justify-content-start"" id=""btnHelp"">

                    <div class=""btn bg-jet-3d circle text-bone align-items-center d-flex"" id=""circleHelp"">
                        <i class=""fas fa-question m-auto"" style=""font-size: 33px""></i>
                    </div>

                    <div class=""btn col-md-5 bg-jet-3d text-bone py-1""
                         style=""border-radius:20px;font-size:25px;"" id=""labHelp"">
                        Help
                    </div>

                </a>

                <!");
            WriteLiteral("-- Add Cashier btn (if is not Cashier) -->\r\n");
            EndContext();
#line 62 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                 if(!User.HasClaim(c => c.Value == "Cashier"))
                {

#line default
#line hidden
            BeginContext(2413, 611, true);
            WriteLiteral(@"                    <a class=""d-flex align-items-center justify-content-start"" id=""btnCashier"">

                        <div class=""btn bg-carmine-3d circle text-bone align-items-center d-flex"" id=""circleCashier"">
                            <i class=""fas fa-plus m-auto"" style=""font-size: 33px""></i>
                        </div>

                        <div class=""btn col-md-5 bg-carmine-3d text-bone py-1""
                             style=""border-radius:20px;font-size:25px;"" id=""labCashier"">
                            Add Cashier
                        </div>

                    </a>
");
            EndContext();
#line 76 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                }

#line default
#line hidden
            BeginContext(3043, 39, true);
            WriteLiteral("\r\n                <!-- Verify btn -->\r\n");
            EndContext();
#line 79 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                 if (!user.EmailConfirmed)
                {

#line default
#line hidden
            BeginContext(3145, 639, true);
            WriteLiteral(@"                    <a class=""d-flex align-items-center justify-content-start"" id=""btnVerify"">

                        <div class=""btn bg-jet-green-3d circle text-bone align-items-center d-flex"" style=""text-align:center"" id=""circleVerify"">
                            <i class=""fas fa-address-card m-auto"" style=""font-size: 33px""></i>
                        </div>

                        <div class=""btn col-md-5 bg-jet-green-3d text-bone py-1""
                             style=""border-radius:20px;font-size:25px;"" id=""labVerify"">
                            Verify
                        </div>
                    </a>
");
            EndContext();
#line 92 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3844, 33, true);
            WriteLiteral("                    <div></div>\r\n");
            EndContext();
#line 96 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                }

#line default
#line hidden
            BeginContext(3896, 97, true);
            WriteLiteral("\r\n                <!-- For the alignment, in case user is not a cashier and is not verified -->\r\n");
            EndContext();
#line 99 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                 if (User.HasClaim(c => c.Value == "Cashier"))
                {

#line default
#line hidden
            BeginContext(4076, 33, true);
            WriteLiteral("                    <div></div>\r\n");
            EndContext();
#line 102 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
                }

#line default
#line hidden
            BeginContext(4128, 109, true);
            WriteLiteral("\r\n\r\n                <div></div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- Menus -->\r\n        ");
            EndContext();
            BeginContext(4237, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d97a28236a84fb4bcb780feab97ed07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4276, 30, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4324, 4918, true);
                WriteLiteral(@"

    <script>

        var settClicked = false;
        var infoClicked = false;
        var cashClicked = false;
        var helpClicked = false;
        var verifyClicked = false;

        var sett = document.getElementById('btnSett');
        var info = document.getElementById('btnInfo');
        var cash = document.getElementById('btnCashier');
        var help = document.getElementById('btnHelp');
        var verify = document.getElementById('btnVerify');

        var settCircle = document.getElementById('circleSett');
        var infoCircle = document.getElementById('circleInfo');
        var cashCircle = document.getElementById('circleCashier');
        var helpCircle = document.getElementById('circleHelp');
        var verifyCircle = document.getElementById('circleVerify');

        var settLab = document.getElementById('labSett');
        var infoLab = document.getElementById('labInfo');
        var cashLab = document.getElementById('labCashier');
        var helpLab = docum");
                WriteLiteral(@"ent.getElementById('labHelp');
        var verifyLab = document.getElementById('labVerify');

        var settMenu = document.getElementById('menuSett');
        var infoMenu = document.getElementById('menuInfo');
        var cashMenu = document.getElementById('menuCashier');
        var helpMenu = document.getElementById('menuHelp');
        var verifyMenu = document.getElementById('menuVerify');


        sett.onmouseover = function () {
            settLab.classList.add(""bg-jet-3d-hov"");
            settCircle.classList.add(""bg-jet-3d-hov"");
        };

        sett.onmouseout = function () {
            settLab.classList.remove(""bg-jet-3d-hov"");
            settCircle.classList.remove(""bg-jet-3d-hov"");
        };

        info.onmouseover = function () {
            infoLab.classList.add(""bg-jet-3d-hov"");
            infoCircle.classList.add(""bg-jet-3d-hov"");
        };

        info.onmouseout = function () {
            infoLab.classList.remove(""bg-jet-3d-hov"");
            in");
                WriteLiteral(@"foCircle.classList.remove(""bg-jet-3d-hov"");
        };

        help.onmouseover = function () {
            helpLab.classList.add(""bg-jet-3d-hov"");
            helpCircle.classList.add(""bg-jet-3d-hov"");
        };

        help.onmouseout = function () {
            helpLab.classList.remove(""bg-jet-3d-hov"");
            helpCircle.classList.remove(""bg-jet-3d-hov"");
        };

        function disableAll() {

            if (settClicked) {
                settCircle.classList.remove(""regiClicked""),
                    settLab.classList.remove(""regiClicked""),
                    settMenu.classList.add(""invisible""),
                    settClicked = false
            };
            if (infoClicked) {
                infoCircle.classList.remove(""regiClicked""),
                    infoLab.classList.remove(""regiClicked""),
                    infoMenu.classList.add(""invisible""),
                    infoClicked = false
            };
            if (cashClicked) {
                cashCir");
                WriteLiteral(@"cle.classList.remove(""regiClicked""),
                    cashLab.classList.remove(""regiClicked""),
                    cashMenu.classList.add(""invisible""),
                    cashClicked = false
            };
            if (helpClicked) {
                helpCircle.classList.remove(""regiClicked""),
                    helpLab.classList.remove(""regiClicked""),
                    helpMenu.classList.add(""invisible""),
                    helpClicked = false
            };
            if (verifyClicked) {
                verifyCircle.classList.remove(""regiClicked""),
                    verifyLab.classList.remove(""regiClicked""),
                    verifyMenu.classList.add(""invisible""),
                    verifyClicked = false
            };
        };

        sett.onclick = function () {
            settClicked ? disableAll() :
                (disableAll(),
                    settCircle.classList.add(""regiClicked""),
                    settLab.classList.add(""regiClicked""),
            ");
                WriteLiteral(@"        settMenu.classList.remove(""invisible""),
                    settClicked = true);
        };

        info.onclick = function () {
            infoClicked ? disableAll() :
                (disableAll(),
                    infoCircle.classList.add(""regiClicked""),
                    infoLab.classList.add(""regiClicked""),
                    infoMenu.classList.remove(""invisible""),
                    infoClicked = true);
        };

        help.onclick = function () {
            helpClicked ? disableAll() :
                (disableAll(),
                    helpCircle.classList.add(""regiClicked""),
                    helpLab.classList.add(""regiClicked""),
                    helpMenu.classList.remove(""invisible""),
                    helpClicked = true);
        };

    </script>

");
                EndContext();
#line 248 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
     if (!user.EmailConfirmed)
    {

#line default
#line hidden
                BeginContext(9281, 1437, true);
                WriteLiteral(@"        <script>

            var verifyClicked = false;
            var verify = document.getElementById('btnVerify');
            var verifyCircle = document.getElementById('circleVerify');
            var verifyLab = document.getElementById('labVerify');
            var verifyMenu = document.getElementById('menuVerify');

            verify.onmouseover = function () {
                verifyLab.classList.add(""bg-jet-green-3d-hov"");
                verifyCircle.classList.add(""bg-jet-green-3d-hov"");
            };

            verify.onmouseout = function () {
                verifyLab.classList.remove(""bg-jet-green-3d-hov"");
                verifyCircle.classList.remove(""bg-jet-green-3d-hov"");
            };

            if (verifyClicked) {
                verifyCircle.classList.remove(""regiClicked""),
                    verifyLab.classList.remove(""regiClicked""),
                    verifyMenu.classList.add(""invisible""),
                    verifyClicked = false
            };

    ");
                WriteLiteral(@"        verify.onclick = function () {
                verifyClicked ? disableAll() :
                    (disableAll(),
                        verifyCircle.classList.add(""regiClicked""),
                        verifyLab.classList.add(""regiClicked""),
                        verifyMenu.classList.remove(""invisible""),
                        verifyClicked = true);
            };



        </script>
");
                EndContext();
#line 287 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
    }

#line default
#line hidden
                BeginContext(10725, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 289 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
     if (User.HasClaim(c => c.Value == "Businessman"))
    {

#line default
#line hidden
                BeginContext(10790, 1121, true);
                WriteLiteral(@"        <script>
            var cashClicked = false;
            var cash = document.getElementById('btnCashier');
            var cashCircle = document.getElementById('circleCashier');
            var cashLab = document.getElementById('labCashier');
            var cashMenu = document.getElementById('menuCashier');


            cash.onmouseover = function () {
                cashLab.classList.add(""bg-carmine-3d-hover"");
                cashCircle.classList.add(""bg-carmine-3d-hover"");
            };

            cash.onmouseout = function () {
                cashLab.classList.remove(""bg-carmine-3d-hover"");
                cashCircle.classList.remove(""bg-carmine-3d-hover"");
            };

            cash.onclick = function () {
                cashClicked ? disableAll() :
                    (disableAll(),
                        cashCircle.classList.add(""regiClicked""),
                        cashLab.classList.add(""regiClicked""),
                        cashMenu.classList.remove(""");
                WriteLiteral("invisible\"),\r\n                        cashClicked = true);\r\n            };\r\n\r\n        </script>\r\n");
                EndContext();
#line 319 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileBusi\SettingsBusi.cshtml"
    }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<DeliverNETUser> UserManager { get; private set; }
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