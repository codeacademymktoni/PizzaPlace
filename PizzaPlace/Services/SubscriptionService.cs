using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;

namespace PizzaPlace.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository subscriptionRepository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            this.subscriptionRepository = subscriptionRepository;
        }

        public void Add(string email)
        {
            var subscription = new Subscription();
            subscription.Email = email;
            subscription.DateCreated = DateTime.Now;

            subscriptionRepository.Add(subscription);
        }
    }
}
