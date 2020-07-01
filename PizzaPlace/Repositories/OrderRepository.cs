using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OrderRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> GetByStatus(bool isProcessed, bool isDelivered)
        {
            return context.Orders.Where(x => x.IsProcessed == isProcessed && x.IsDelivered == isDelivered ).ToList();
        }

        public void Update(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }
    }
}
