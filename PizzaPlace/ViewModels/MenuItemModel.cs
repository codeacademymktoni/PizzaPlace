using System;

namespace PizzaPlace.ViewModels
{
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated{ get; set; }
        public string Slug { get; set; }
    }
}
