#pragma checksum "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf66f2c17df348985086c47338c70dfd006fba2"
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
#nullable restore
#line 4 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
using Net5Wasm.Api.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Uploadpage")]
    public partial class Uploadpage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 7 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
                          OnFileSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
#nullable restore
#line 9 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
         foreach (var imgurlname in imgUrlsname)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 11 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
                        imgurlname

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "type", "text");
            __builder.CloseElement();
#nullable restore
#line 12 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
         
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
#nullable restore
#line 17 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
         foreach (var imgUrl in imgUrls)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 19 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
           imgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
        
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
                                                                SaveToServer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Upload");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\RadZenstock\Net5Wasm\client\Pages\Uploadpage.razor"
       List<string> imgUrls = new List<string>();
    List<string> imgUrlsname = new List<string>();
    List<FileData> fileData = new List<FileData>();
    private async Task OnFileSelection(InputFileChangeEventArgs e)
    {
        foreach (IBrowserFile imgFile in e.GetMultipleFiles(5))
        {
            var buffers = new byte[imgFile.Size];
            await imgFile.OpenReadStream().ReadAsync(buffers);
            string imageType = imgFile.ContentType;
            string imgUrl = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
            string imgurlname = imgFile.Name;
            imgUrls.Add(imgUrl);
            imgUrlsname.Add(imgurlname);

            fileData.Add(new FileData
            {
                Data = buffers,
                FileType = imageType,
                Size = imgFile.Size
            });
        }
    }

    private async Task SaveToServer()
    {
        if (fileData.Count > 0)
        {
            var payload = new SaveFile { Files = fileData };
            await Http.PostAsJsonAsync("/api/FileUpload/save-file-to-physicallocation", payload);
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
