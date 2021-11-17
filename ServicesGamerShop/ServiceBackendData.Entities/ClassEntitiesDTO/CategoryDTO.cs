using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class CategoryDTO
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
