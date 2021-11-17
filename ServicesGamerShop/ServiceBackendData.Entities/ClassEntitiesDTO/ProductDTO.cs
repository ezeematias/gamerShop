using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
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

        public IEnumerable<ImageProductDTO> Images { get; set; }
    }
}
