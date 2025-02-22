﻿using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityServer.IdentityServer
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
        {
            new InMemoryUser
            {
                Username = "bob",
                Password = "bob",
                Subject = "1",

                Claims = new[]
                {
                    new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                    new Claim(Constants.ClaimTypes.FamilyName, "Smith"),
                    new Claim(Constants.ClaimTypes.Role, "Geek"),
                    new Claim(Constants.ClaimTypes.Role, "Foo")
                }
            }
        };
        }
    }
}