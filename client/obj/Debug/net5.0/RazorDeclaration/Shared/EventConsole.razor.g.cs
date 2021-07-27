// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Net5Wasm.Client.Shared
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
#line 11 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\RadZenstock\Net5Wasm\client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class EventConsole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "E:\RadZenstock\Net5Wasm\client\Shared\EventConsole.razor"
       
    class Message
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    ElementReference console;

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> Attributes { get; set; }
    IList<Message> messages = new List<Message>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            await JSRuntime.InvokeVoidAsync("scrollToBottom", console);
        }
    }

    void OnClearClick()
    {
        Clear();
    }

    public void Clear()
    {
        messages.Clear();

        InvokeAsync(StateHasChanged);
    }

    public void Log(string message)
    {
        messages.Add(new Message { Date = DateTime.Now, Text = message });

        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
