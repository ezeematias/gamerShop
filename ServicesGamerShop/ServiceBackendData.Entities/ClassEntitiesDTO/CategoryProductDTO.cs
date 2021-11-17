using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class CategoryProductDTO
    {
        [Key]
        public int IdCategoryProduct { get; set; }

        public int IdProduct { get; set; }

        public int IdCategory { get; set; }

    }
}
