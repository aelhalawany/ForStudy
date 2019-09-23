using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2018.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="التصنيف")]
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] CategoryImage { get; set; }
    }
}
