using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace
{
    [Authorize]
    public class MenuDashboardModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}