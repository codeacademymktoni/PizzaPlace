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

        public List<IdentityUser> Users{ get; set; }

        public UsersListModel(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public void OnGet()
        {
            Users = userManager.Users.ToList();
        }
    }
}