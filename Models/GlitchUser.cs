using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace Glitchdoctor.Models
{
    public class GlitchUser : IdentityUser
    {
        public DateTime AccountCreateDate { get; set; }
    }
}
