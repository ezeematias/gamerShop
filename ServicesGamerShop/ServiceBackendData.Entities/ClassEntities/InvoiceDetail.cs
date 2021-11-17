namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceDetail")]
    public partial class InvoiceDetail
    {
        [Key]
        public int IdInvoiceDetail { get; set; }

        public int IdInvoice { get; set; }

        public int IdProduct { get; set; }

        public int Count { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
