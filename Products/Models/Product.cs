using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Models
{
   
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }


        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ScaffoldColumn(false)]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
