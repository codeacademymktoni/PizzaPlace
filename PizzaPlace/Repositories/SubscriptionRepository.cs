using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;

namespace PizzaPlace.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly PizzaPlaceDbContext context;

        public SubscriptionRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
        }
    }
}
