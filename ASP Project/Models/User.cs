using Microsoft.AspNetCore.Identity;

namespace ASP_Project.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
