using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOfferService offerService;

        public IndexModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }

        public List<OfferViewModel> Offers { get; set; }

        public void OnGet()
        {
            var dbOffers = offerService.GetAll();
            
            Offers = dbOffers.Select(x => new OfferViewModel()
            {
                Title = x.Title,
                Description = x.Description,
                DateCreated = x.DateCreated,
                Price = x.Price
            }).ToList();
        }
    }
}
