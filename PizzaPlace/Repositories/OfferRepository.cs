using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OfferRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public List<Offer> GetAll()
        {
            return context.Offers.ToList();
        }
    }
}
