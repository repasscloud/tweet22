using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace tweet22.Client
{
    public class CustomAuthProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "Patrick")
            }, "test authentication type");

            var user = new ClaimsPrincipal(identity);

            return Task.FromResult(new AuthenticationState(user);

            //return Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));
        }
    }
}

