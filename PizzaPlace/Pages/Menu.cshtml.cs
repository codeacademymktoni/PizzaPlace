using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;

namespace PizzaPlace
{
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public MenuModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }

        public List<MenuItemModel> MenuItems { get; set; }

        public void OnGet()
        {
            MenuItems = new List<MenuItemModel>();

            var menuItemsDb = menuItemService.GetAll();

            foreach (var item in menuItemsDb)
            {
                var newItem = new MenuItemModel();
                newItem.Id = item.Id;
                newItem.Title = item.Title;
                newItem.Description = item.Description;
                newItem.DateCreated = item.DateCreated;
                newItem.ImageUrl = item.ImageUrl;
                newItem.Price = item.Price;
                newItem.Slug = item.Slug;

                MenuItems.Add(newItem);
            };
        }
    }
}