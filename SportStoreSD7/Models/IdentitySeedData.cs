using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreSD7.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Gow3bAdmin";
        private const string adminPassword = "Pa$$w0rd";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Gow3bAdmin");
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
