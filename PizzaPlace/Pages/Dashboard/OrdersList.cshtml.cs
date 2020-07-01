using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common;
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
            Orders = dbOrders.Select(x => ModelConverter.CreateToOrderViewModel(x)).ToList();
        }

        public void OnGetNotProcessed()
        {
            var dbOrders = orderService.GetByStatus(false, false);
            Orders = dbOrders.Select(x => ModelConverter.CreateToOrderViewModel(x)).ToList();
        }

        public void OnGetProcessed()
        {
            var dbOrders = orderService.GetByStatus(true, false);
            Orders = dbOrders.Select(x => ModelConverter.CreateToOrderViewModel(x)).ToList();
        }

        public void OnGetDone()
        {
            var dbOrders = orderService.GetByStatus(true, true);
            Orders = dbOrders.Select(x => ModelConverter.CreateToOrderViewModel(x)).ToList();
        }

        public IActionResult OnGetSetProcessed(int id)
        {
            orderService.SetProcessed(id);
            return RedirectToPage("OrdersList", "NotProcessed");
        }

        public IActionResult OnGetSetDelivered(int id)
        {
            orderService.SetDelivered(id);
            return RedirectToPage("OrdersList", "Processed");
        }
    }
}