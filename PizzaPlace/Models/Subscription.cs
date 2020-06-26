using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
