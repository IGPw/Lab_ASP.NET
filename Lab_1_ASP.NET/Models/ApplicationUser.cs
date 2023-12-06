using Microsoft.AspNetCore.Identity;

namespace Lab_1_ASP.NET.Models {
    public class ApplicationUser : IdentityUser {
        public byte[] Avatar { get; set; }
    }
}
