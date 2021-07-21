// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebApp.Client.Pages.Pessoas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\Pages\Pessoas\Listar.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pessoas/lista")]
    public partial class Listar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\ivoli\source\repos\BlazorWebApp\BlazorWebApp\Client\Pages\Pessoas\Listar.razor"
             

    List<Pessoa> pessoas;
    protected override async Task OnInitializedAsync()
    {
        await LoadPessoas();
    }

    async Task LoadPessoas()
    {
        await Task.Delay(2000);

        pessoas = new List<Pessoa>{
           new Pessoa { Id = 1, Nome = "Ivo", Peso = 50},
           new Pessoa { Id = 2, Nome = "Lima", Peso = 70},
           new Pessoa { Id = 3, Nome = "Paulo", Peso = 100},
           new Pessoa { Id = 4, Nome = "Junior", Peso = 40},
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
