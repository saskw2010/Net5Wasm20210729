#pragma checksum "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809a7fe3f8b6e3ae3bd03199d8cc7a28fa272746"
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
#line 5 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Net5Wasm.Models.Net5Wasmconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Net5Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Net5Wasm.Pages.LoginComponent
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
#line 16 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
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
                __Blazor.Net5Wasm.Client.Pages.Login.TypeInference.CreateRadzenTemplateForm_0(__builder2, 11, 12, "account/login", 13, 
#nullable restore
#line 20 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
                                                           "login"

#line default
#line hidden
#nullable disable
                , 14, "post", 15, (context) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLogin>(16);
                    __builder3.AddAttribute(17, "AllowResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
                                             false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Register", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 22 "E:\RadZenstock\Net5Wasm\client\Pages\Login.razor"
                                                               Login0Register

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Login> L { get; set; }
    }
}
namespace __Blazor.Net5Wasm.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenTemplateForm_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TItem __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenTemplateForm<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Action", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Method", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
