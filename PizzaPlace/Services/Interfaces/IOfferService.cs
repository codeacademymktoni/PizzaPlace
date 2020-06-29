using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetAll();
    }
}
