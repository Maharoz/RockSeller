
using Microsoft.AspNetCore.Identity;

namespace RockSelling_Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
