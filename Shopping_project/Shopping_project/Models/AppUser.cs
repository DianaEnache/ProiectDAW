using Microsoft.AspNetCore.Identity;

namespace Shopping_project.Models
{
    public class AppUser:IdentityUser
    {
        public string Occupation {  get; set; }

    }
}
