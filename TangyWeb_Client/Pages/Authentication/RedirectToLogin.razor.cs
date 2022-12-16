using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using TangyWeb_Client.Service.IService;

namespace TangyWeb_Client.Pages.Authentication
{
    public partial class RedirectToLogin
    {
        [CascadingParameter]
        public Task<AuthenticationState> _authState { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
    }
    
    protected override async Task OnInitializedAsync()
    {

    }

}
