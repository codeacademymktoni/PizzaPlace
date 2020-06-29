using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGetOrder()
        {
            Message = "Thanks for ordering!!";
        }

        public void OnGetSubscription()
        {
            Message = "Thanks for subscription";
        }
    }
}