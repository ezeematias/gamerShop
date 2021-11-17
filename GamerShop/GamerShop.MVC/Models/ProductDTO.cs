using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamerShop.MVC.Models
{
    public class ProductDTO
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Reference { get; set; }

        public bool Available { get; set; }

        public List<ImageProductDTO> Images { get; set; }
    }
}