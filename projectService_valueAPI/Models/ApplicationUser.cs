using Microsoft.AspNetCore.Identity;

namespace projectService_valueAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
