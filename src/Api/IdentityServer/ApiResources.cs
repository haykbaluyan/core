﻿using IdentityServer4.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace Bit.Api.IdentityServer
{
    public class ApiResources
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api", "Vault API", new string[] {
                    ClaimTypes.AuthenticationMethod,
                    ClaimTypes.NameIdentifier,
                    ClaimTypes.Email,
                    "securitystamp",

                    "nam", // name
                    "eml", // email
                    "sst", // security stamp
                    "pln", // plan
                    "tex", // trial expiration
                    "dev" // device identifier
                })
            };
        }
    }
}
