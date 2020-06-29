using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        List<Order> GetAll();
        void SetProcessed(int id);
    }
}
