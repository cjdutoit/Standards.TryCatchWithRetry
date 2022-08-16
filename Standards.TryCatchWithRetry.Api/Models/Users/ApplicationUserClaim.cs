using System;
using Microsoft.AspNetCore.Identity;

namespace Standards.TryCatchWithRetry.Api.Models.Users
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
