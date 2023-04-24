using System;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace tweet22.Client
{
    public class CustomAuthProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;

        public CustomAuthProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //set an empty result
            var state = new AuthenticationState(new ClaimsPrincipal());

            //check existing state exists
            if (await _localStorageService.GetItemAsync<bool>("isAuthenticated"))
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "Patrick")
                }, "test authentication type");

                var user = new ClaimsPrincipal(identity);

                // set authentication state to value of mapped user
                state = new AuthenticationState(user);
            }

            //notify of the change
            NotifyAuthenticationStateChanged(Task.FromResult(state));

            //return the state
            return state;
        }
    }
}

