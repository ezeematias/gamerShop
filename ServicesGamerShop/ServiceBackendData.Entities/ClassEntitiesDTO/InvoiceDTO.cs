using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class InvoiceDTO
    {
        [Key]
        public int IdInvoice { get; set; }

        public int Number { get; set; }

        public int IdClient { get; set; }

        public DateTime DateTime { get; set; }

        public int IdPaymentMethod { get; set; }

        public decimal Subtotal { get; set; }

        public decimal VAT { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public bool Status { get; set; }
    }
}
