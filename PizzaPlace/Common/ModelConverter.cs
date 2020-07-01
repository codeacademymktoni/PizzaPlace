using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Common
{
    public static class ModelConverter
    {
        public static OrderViewModel CreateToOrderViewModel(Order order)
        {
            return new OrderViewModel()
            {
                Id = order.Id,
                Name = order.Name,
                Surname = order.Surname,
                Address = order.Address,
                Phone = order.Phone,
                Message = order.Message,
                IsProcessed = order.IsProcessed,
                IsDelivered = order.IsDelivered
            };
        }
    }
}
