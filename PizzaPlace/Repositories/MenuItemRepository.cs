using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly PizzaPlaceDbContext context;

        public MenuItemRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public List<MenuItem> GetAll()
        {
            return context.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return context.MenuItems.FirstOrDefault(x => x.Id == id);
        }

        public MenuItem GetBySlug(string slug)
        {
            return context.MenuItems.FirstOrDefault(x => x.Slug == slug);
        }
    }
}
