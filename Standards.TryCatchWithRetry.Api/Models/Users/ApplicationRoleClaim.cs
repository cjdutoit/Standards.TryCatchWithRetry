using System;
using Microsoft.AspNetCore.Identity;

namespace Standards.TryCatchWithRetry.Api.Models.Users
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}
