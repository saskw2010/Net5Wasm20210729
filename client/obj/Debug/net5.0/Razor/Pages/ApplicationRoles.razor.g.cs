#pragma checksum "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c189799561434fe4fd2562e91d2cf52be15367b3"
// <auto-generated/>
#pragma warning disable 1591
namespace Net5Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Net5Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Net5Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Net5Wasm.Models.Net5Wasmconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Net5Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/application-roles")]
    public partial class ApplicationRoles : Net5Wasm.Pages.ApplicationRolesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                    L["pageTitle.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                   L["button0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                                              Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<IdentityRole>>(17);
                __builder2.AddAttribute(18, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<IdentityRole>>(
#nullable restore
#line 23 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                                         roles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<IdentityRole>>(23);
                    __builder3.AddAttribute(24, "Property", "Name");
                    __builder3.AddAttribute(25, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                               L["grid0.Name.Title"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<IdentityRole>>(27);
                    __builder3.AddAttribute(28, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                   false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Width", "70px");
                    __builder3.AddAttribute(31, "Template", (Microsoft.AspNetCore.Components.RenderFragment<IdentityRole>)((identityRole) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                        __builder4.AddAttribute(33, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 29 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "Icon", "close");
                        __builder4.AddAttribute(35, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 29 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, identityRole)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(37, "onclick", 
#nullable restore
#line 29 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 23 "E:\RadZenstock\Net5Wasm\client\Pages\ApplicationRoles.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<IdentityRole>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<ApplicationRoles> L { get; set; }
    }
}
#pragma warning restore 1591
