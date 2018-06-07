using Microsoft.PowerBI.Api.V2.Models;
using System;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class EmbedConfig
    {
        public string Id { get; set; }

        public string EmbedUrl { get; set; }

        public string EmbedToken { get; set; }
        
        
        public bool? IsEffectiveIdentityRolesRequired { get; set; }

        public bool? IsEffectiveIdentityRequired { get; set; }

        public bool EnableRLS { get; set; }

        public string Username { get; set; }

        public string Roles { get; set; }

        public string ErrorMessage { get; internal set; }
    }
}