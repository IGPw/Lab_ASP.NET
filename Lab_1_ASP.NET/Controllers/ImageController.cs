using Lab_1_ASP.NET.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1_ASP.NET.Controllers {
    public class ImageController : Controller {
        private readonly UserManager<ApplicationUser> _userManager;
        public ImageController(UserManager<ApplicationUser> userManager) {
            _userManager = userManager;
        }
        public async Task<IActionResult> GetImage() {

            var user = await _userManager.GetUserAsync(User);

            return File(user.Avatar, "image/*");
        }
    }
}
