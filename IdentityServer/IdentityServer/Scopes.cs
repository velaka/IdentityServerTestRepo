﻿using System;
using IdentityServer3.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityServer.IdentityServer
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>
        {
            new Scope
            {
                Enabled = true,
                Name = "roles",
                Type = ScopeType.Identity,
                Claims = new List<ScopeClaim>
                {
                    new ScopeClaim("role")
                }
            },
            new Scope
            {
                Enabled = true,
                DisplayName = "Sample API",
                Name = "sampleApi",
                Description = "Access to a sample API",
                Type = ScopeType.Resource,

                Claims = new List<ScopeClaim>
                {
                    new ScopeClaim("role")
                }
            }
        };

            scopes.AddRange(StandardScopes.All);

            return scopes;
        }
    }
}