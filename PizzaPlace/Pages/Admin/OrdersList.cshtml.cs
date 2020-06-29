using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    [Authorize]
    public class OrdersListModel : PageModel
    {
        private readonly IOrderService orderService;

        public OrdersListModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public List<OrderViewModel> Orders { get; set; }

        public void OnGet()
        {
            var dbOrders = orderService.GetAll();

            Orders = dbOrders.Select(x => new OrderViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Address = x.Address,
                Phone = x.Phone,
                Message = x.Message,
                IsProcessed = x.IsProcessed
            }).ToList(); 
        }

        public IActionResult OnGetSetProcessed(int id)
        {
            orderService.SetProcessed(id);
            return RedirectToPage();
        }
    }
}