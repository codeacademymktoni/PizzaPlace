using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository repository;

        public MenuItemService(IMenuItemRepository repository)
        {
            this.repository = repository;
        }

        public List<MenuItem> GetAll()
        {
            return repository.GetAll();
        }

        public MenuItem GetById(int id)
        {
            return repository.GetById(id);
        }

        public MenuItem GetBySlug(string slug)
        {
            return repository.GetBySlug(slug);
        }
    }
}
