using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace BlazorApp.MessageHandlers;
public class WeatherMessageHandler : AuthorizationMessageHandler
{
    public WeatherMessageHandler(
        IAccessTokenProvider provider,
        NavigationManager navigationManager
    ) : base(provider, navigationManager) {
        ConfigureHandler(
            authorizedUrls: new[] { "https://localhost:44304" },
            scopes: new[] { "api://{API SCOPE}/API.Access" });
    }
}
