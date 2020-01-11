
using System;
using Microsoft.AspNetCore.Identity;

namespace ASPNetCore31.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}