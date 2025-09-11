namespace OgrenciOtomasyonSistemi.api.Data
{
    using Microsoft.AspNetCore.Identity;
    using OgrenciOtomasyonSistemi.api.Entities;

    public static class DataSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Teacher", "Student" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            if (await userManager.FindByEmailAsync("admin@test.com") == null)
            {
                var adminUser = new AppUser
                {
                    UserName = "admin@test.com",
                    Email = "admin@test.com",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, "Password123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}

