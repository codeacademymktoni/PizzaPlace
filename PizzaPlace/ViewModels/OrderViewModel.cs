using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public bool IsProcessed { get; set; }

        [Required]
        public bool IsDelivered { get; set; }
    }
}
