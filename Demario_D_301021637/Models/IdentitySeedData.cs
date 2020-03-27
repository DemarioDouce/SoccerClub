using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class IdentitySeedData
    {
        private const string AdminUser = "Admin";
        private const string AdminPassword = "Secret123$";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser UserAdmin = await userManager.FindByIdAsync(AdminUser);
            if (UserAdmin == null)
            {
                UserAdmin = new IdentityUser("Admin");
                await userManager.CreateAsync(UserAdmin, AdminPassword);
            }

        }
    }
}
