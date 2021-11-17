using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class ImageProductDTO
    {
        [Key]
        public int IdImageProduct { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Url { get; set; }

        public bool IsMain { get; set; }
    }
}
