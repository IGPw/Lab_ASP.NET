using Lab_1_ASP.NET.Models;
using Microsoft.AspNetCore.Identity;

namespace Lab_1_ASP.NET.Data {
    public static class DbInitializer {
        public static async Task PopulateAsync(WebApplication app//,
                         //UserManager<ApplicationUser> userManager,
                         //   RoleManager<IdentityRole> roleManager
            ) {
            using var scope = app.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // создать БД, если она еще не создана
            context.Database.EnsureCreated();

            //// проверка наличия ролей
            //if (!context.Roles.Any()) {
            //    var roleAdmin = new IdentityRole {
            //        Name = "admin",
            //        NormalizedName = "admin"
            //    };
            //    // создать роль admin
            //    await roleManager.CreateAsync(roleAdmin);
            //}

            //// проверка наличия пользователей
            //var user = new ApplicationUser {
            //    Email = "user@mail.ru",
            //    UserName = "user@mail.ru"
            //};
            //await userManager.CreateAsync(user, "123456");
            //// создать пользователя admin@mail.ru
            //var admin = new ApplicationUser {
            //    Email = "admin@mail.ru",
            //    UserName = "admin@mail.ru"
            //};
            //await userManager.CreateAsync(admin, "123456");
            //// назначить роль admin
            //admin = await userManager.FindByEmailAsync("admin@mail.ru");
            //await userManager.AddToRoleAsync(admin, "admin");
        }
    }
}
