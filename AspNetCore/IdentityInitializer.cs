using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Entities; 

namespace AspNetCore
{
    public class IdentityInitializer
    {
        public static void OlusturAdmin(UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            AppUser appUser = new AppUser
            {
                Name = "Melisa",
                SurName = "Bayramlı",
                UserName = "Melisaa"
            };
            if (userManager.FindByNameAsync("Melisa").Result == null)
            {
                var identityResult = userManager.CreateAsync(appUser,"1").Result;
            }
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name="Admin"
                };
                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(appUser, role.Name).Result;
            }

        }
    }
}
