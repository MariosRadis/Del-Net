#pragma checksum "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileIndi\IndexIndi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0dcb57e00ccb16b5eded41fb9f7e26b50b77c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfileIndi_IndexIndi), @"mvc.1.0.view", @"/Views/ProfileIndi/IndexIndi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProfileIndi/IndexIndi.cshtml", typeof(AspNetCore.Views_ProfileIndi_IndexIndi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0dcb57e00ccb16b5eded41fb9f7e26b50b77c37", @"/Views/ProfileIndi/IndexIndi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3850bc768a0c373bad8ffdc3985faaeecbc40899", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfileIndi_IndexIndi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/IndiClientSide.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileIndi\IndexIndi.cshtml"
  
    ViewData["Title"] = "DeliverNET | WorkSpace";
    Layout = "~/Views/Shared/_LayoutIndi.cshtml";

#line default
#line hidden
            BeginContext(109, 10656, true);
            WriteLiteral(@"
<!-- Order Info Modal -->
<div class=""modal fade rounded"" id=""orderModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body bg-jet p-0"" style=""border-radius: 5px"">
                <div class=""card text-center"">
                    <div class=""card-header bg-jet text-bone"">
                        <h2 id=""modal-restaurantTitle"" class=""font-pacifico""></h2>
                        <span id=""modal-restaurantAddress"" class=""""></span>
                    </div>
                    <div class=""card-body bg-carmine"">

                        <p class="""">
                            <strong>Payment Type: </strong>
                            <span id=""modal-paymentType""></span>
                        </p>

                        <p class="""">
                            <strong>Price: </strong>
                         ");
            WriteLiteral(@"   <span id=""modal-price""></span>
                        </p>
                                              
                        <input class=""form-control"" hidden type=""text"" id=""modal-orderId""/>
                        <a onclick=""onOrderAccepted()"" id=""acceptOrderBtn"" class=""btn bg-winter text-bone d-block"">Accept</a>
                    </div>
                    <div id=""modal-timestamp"" class=""card-footer"" bg-jet text-bone""></div>
                </div>
            </div>
        </div>
    </div>
</div>


<!-- Order Accepted Modal -->
<div class=""modal fade rounded"" id=""orderAcceptedModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-jet"">
                <h4 class=""text-bone"">Order Accepted!</h4>
            </div>
            <div class=""modal-body bg-bone"">
                <div class=""c");
            WriteLiteral(@"ontainer-fluid"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h5 class=""text-jet"">Restaurant Info</h5>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Name</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalAccepted-restaurantName"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet mb-0"">Address</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalAccepted-restaurantAddress"" class=""text-jet mb-0"">tade</span>
                        </div>
                    </div>
        ");
            WriteLiteral(@"            <div class=""row"">
                        <div class=""col"">
                            <hr />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <h5 class=""text-jet"">Order Info</h5>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Price</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalAccepted-orderPrice"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Payment</span>
                        </div>
                        <div class=""col-6"">
                            <span i");
            WriteLiteral(@"d=""modalAccepted-orderPaymentType"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <button onclick=""onOrderPicked()"" class=""btn btn-block bg-winter text-bone mt-3"">Picked Up</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer justify-content-center bg-jet"">
                <input hidden type=""text"" id=""modalAccepted-orderId"" />
                <span id=""modalAccepted-timestamp"" class=""text-bone"">eliybrliergbly</span>
            </div>
        </div>
    </div>
</div>


<!-- Order Picked Modal -->
<div class=""modal fade rounded"" id=""orderPickedModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
     ");
            WriteLiteral(@"       <div class=""modal-header bg-jet"">
                <h4 class=""text-bone"">Order Picked!</h4>
            </div>
            <div class=""modal-body bg-bone"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h5 class=""text-jet"">Customer Info</h5>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Name</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-customerName"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Address</span>
                        </div>
                        <div class=");
            WriteLiteral(@"""col-6"">
                            <span id=""modalPicked-customerAddress"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Door Name</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-customerDoorName"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Floor No</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-customerFloorNo"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">");
            WriteLiteral(@"
                            <span class=""text-jet"">Phone Number</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-customerPhoneNumber"" class=""text-jet"">tade</span>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col"">
                            <hr />
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12"">
                            <h5 class=""text-jet"">Order Info</h5>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Price</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-orderPrice"" class=""text-jet"">tade</span>
  ");
            WriteLiteral(@"                      </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <span class=""text-jet"">Payment</span>
                        </div>
                        <div class=""col-6"">
                            <span id=""modalPicked-orderPaymentType"" class=""text-jet"">tade</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <button onclick=""onOrderDelivered()"" class=""btn btn-block bg-winter text-bone mt-3"">Delivered</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer justify-content-center bg-jet"">
                <input hidden type=""text"" id=""modalPicked-orderId"" />
                <span id=""modalAccepted-timestamp"" class=""text-bone"">eliybrliergbly</span>
            </div>
      ");
            WriteLiteral(@"  </div>
    </div>
</div>


<div class=""container pt-5"">
    <div class=""row"">

        <!-- Order List for Deliverer -->
        <div class=""col-md-6 px-0 bg-carmine-3d"" onclick=""event.stopPropagation()"" style=""border:solid 1px #E0DDC3;border-radius:4px;height:70vh"">
            <div id=""orderList"" class=""list-group"">
                <div class=""list-group-item flex-column align-items-center bg-jet"">
                    <span class=""text-bone"">Order Pool</span>
                </div>
                <!--Orders go here-->
            </div>
        </div>
        <!-- TODO : Enter Tips button -->


        <!-- Availability Button -->
        <div class=""col-md-6"" style=""text-align:-webkit-center"">
            <!-- Ignore error here, all good -->
            <button class=""btn btn-unavailable btn-shadow-none text-bone"" id=""btnReady"">
                <i class=""fas fa-signal"" style=""font-size: 70px""></i>
                <p>Not Available</p>
            </button>
        </div>

   ");
            WriteLiteral(@" </div>

    <!--Test button to remove order based on id-->
    <div class=""row no-gutters mt-3"">
        <div class=""col-md-5"">
            <input type=""text"" id=""orderToRemove"" class=""form-control"" placeholder=""Order Id"" />
        </div>
        <div class=""col-md-1"">
            <button type=""button"" id=""removeOrderBtn"" class=""btn btn-danger"">Delete</button>
        </div>
    </div>

</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10783, 302, true);
                WriteLiteral(@"

    <!-- Background Image -->
    <script>
        var back = document.getElementById('bodyDiv');
        back.classList.remove(""bg-img-carmine"");
        back.classList.add(""bg-img-biker"");
    </script>

    <!-- Available Button Logic -->
    <script>



            var userName = """);
                EndContext();
                BeginContext(11086, 18, false);
#line 262 "C:\Users\margi\OneDrive\Desktop\Developing\GitRep\delivernet\DeliverNET\DeliverNET\Views\ProfileIndi\IndexIndi.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(11104, 1142, true);
                WriteLiteral(@""";
            var IsClicked = false;
            var btn = document.getElementById('btnReady');
            var IsWorking = document.getElementById('IsWorking');
            var htmlON = '<i class=""fas fa-signal"" style=""font-size: 70px""></i> <p> Not Available</p >';
            var htmlOFF = '<i class=""fas fa-check"" style=""font-size: 70px""></i> <p> Available</p >';


        btn.onclick = function () {
            IsClicked ?
                (IsClicked = false,
                    btn.classList.add(""btn-unavailable""),
                    btn.classList.remove(""btn-available""),
                    btn.innerHTML = htmlON,
                    removeMeFromGroup(), // Remove from group of available deliverers
                    clearOrderList()) :   

                    (IsClicked = true,
                        btn.classList.add(""btn-available""),
                        btn.classList.remove(""btn-unavailable""),
                        btn.innerHTML = htmlOFF,
                        addMeToG");
                WriteLiteral("roup());         // Add to group  -- bugs everything fuck off gamw tin panagia\r\n            }\r\n\r\n    </script>\r\n\r\n    ");
                EndContext();
                BeginContext(12246, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c823151bd224946b175e0d28253e030", async() => {
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
                BeginContext(12292, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
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
