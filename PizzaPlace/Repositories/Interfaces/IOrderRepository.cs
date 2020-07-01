using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
        List<Order> GetByStatus(bool isProcessed, bool isDelivered);
    }
}
