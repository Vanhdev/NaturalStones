using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text;

namespace NaturalStones.Pages.Admin
{
    public class Admin : ComponentBase
    {
        string? authString;
        [Inject]
        ILocalStorageService localStorageService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var auth = await localStorageService.GetItemAsStringAsync("auth");
            if(auth != null)
            {
                authString = Encoding.UTF8.GetString(Convert.FromBase64String(auth));
            }
            else
            {
                navigationManager.NavigateTo("/admin/login");
            }

            var admin = DB.Accounts.Find("admin");
            var adminString = $"{admin.Username.ToMD5()}-{admin.Password.ToMD5()}";

            if (authString != adminString)
            {
                navigationManager.NavigateTo("/admin/login");
            }
            StateHasChanged();
        }
    }
}
