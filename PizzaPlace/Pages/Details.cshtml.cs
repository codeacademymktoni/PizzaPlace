using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class DetailsModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public DetailsModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }

        public MenuItemModel MenuItem{ get; set; }

        public void OnGet(string slug)
        {
            var menuItem = menuItemService.GetBySlug(slug);

            MenuItem = new MenuItemModel()
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                Description = menuItem.Description,
                DateCreated = menuItem.DateCreated,
                Price = menuItem.Price,
                ImageUrl = menuItem.ImageUrl
            };
        }
    }
}