using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;

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
    }
}
