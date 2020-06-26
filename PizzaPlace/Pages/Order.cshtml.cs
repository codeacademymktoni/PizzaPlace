using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService orderService;
        private readonly ISubscriptionService subscriptionService;

        public OrderModel(IOrderService orderService, ISubscriptionService subscriptionService)
        {
            this.orderService = orderService;
            this.subscriptionService = subscriptionService;
        }

        [BindProperty]
        public OrderViewModel Order { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    Name = Order.Name,
                    Surname = Order.Surname,
                    Address = Order.Address,
                    Message = Order.Message,
                    Phone = Order.Phone
                };

                orderService.AddOrder(order);

                return RedirectToPage("Confirmation", "Order");
            }

            return Page();
        }

        public IActionResult OnPostSubscribe(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                subscriptionService.Add(email);

                return RedirectToPage("Confirmation", "Subscription");
            }

            ErrorMessage = "Please enter email";

            return Page();
        }
    }
}