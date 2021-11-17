using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class PaymentMethodDTO
    {
        [Key]
        public int IdPaymentMethod { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
