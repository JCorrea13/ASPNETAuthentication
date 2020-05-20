using Microsoft.AspNetCore.Identity;
using System;

namespace AspNetCoreIdentity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData] //This tag allows users to get all information tagged with the tag; Also when a users deletes a account all the data tagged as PersonalData gets Deleted
        public DateTime CareerStarted { get; set; }

    }
}
