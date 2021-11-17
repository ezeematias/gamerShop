using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class InvoiceDetailDTO
    {
        [Key]
        public int IdInvoiceDetail { get; set; }

        public int IdInvoice { get; set; }

        public int IdProduct { get; set; }

        public int Count { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
