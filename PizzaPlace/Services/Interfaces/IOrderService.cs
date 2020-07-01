using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        List<Order> GetAll();
        void SetProcessed(int id);
        List<Order> GetByStatus(bool isProcessed, bool isDelivered);
        void SetDelivered(int id);
    }
}
