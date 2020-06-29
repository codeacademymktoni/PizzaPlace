using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void AddOrder(Order order)
        {
            orderRepository.Add(order);
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAll();
        }

        public void SetProcessed(int id)
        {
            var order = orderRepository.GetById(id);

            if(order != null)
            {
                order.IsProcessed = true;
                orderRepository.Update(order);
            }
        }
    }
}
