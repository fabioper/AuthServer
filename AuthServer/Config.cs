// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4;

namespace AuthServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };

        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {

        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {

        };

        public static IEnumerable<Client> Clients => new[]
        {
            new Client {
                ClientId = "angular-client",
                ClientName = "Angular Client",
                
                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = true,
                RequireClientSecret = false,
                
                RequireConsent = false,
                
                RedirectUris = { "http://localhost:4200" },
                PostLogoutRedirectUris =  { "http://localhost:4200" },
                
                AllowedCorsOrigins = { "http://localhost:4200" },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email
                }
            }
        };
    }
}