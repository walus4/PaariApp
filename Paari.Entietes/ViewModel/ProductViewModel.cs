using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paari.Entietes.ViewModel
{
    public class ProductViewModel
    {

       [Display(Name = "ProductNo/SKU")]
        public Guid Id { get; set; }

       [Display(Name = "Product Name")]
       [StringLength(100)]
       [Required]
        public string Name { get; set; }

        [Display(Name = "Product Price")]
        [Required]
        public decimal Price { get; set; }
    }
}