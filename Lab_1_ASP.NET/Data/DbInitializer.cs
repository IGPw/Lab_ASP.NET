namespace Lab_1_ASP.NET.Data {
    public static class DbInitializer {
        public static void Populate(WebApplication app) {
            using var scope = app.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated();
        }
    }
}
