using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace
{

    [Authorize(Roles = "Admin")]
    public class UsersListModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public List<IdentityUser> Users{ get; set; }
        public List<IdentityRole> Roles { get; set; }

        public UsersListModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public void OnGet()
        {
            Users = userManager.Users.ToList();
            Roles = roleManager.Roles.ToList();
        }

        public async Task<IActionResult> OnGetRemoveRole(string roleName, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            await userManager.RemoveFromRoleAsync(user, roleName);

            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetAddRole(string roleName, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            await userManager.AddToRoleAsync(user, roleName);

            return RedirectToPage();
        }
    }
}