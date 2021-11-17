namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
            Invoicing = new HashSet<Invoicing>();
        }

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

        public virtual Client Client { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoicing> Invoicing { get; set; }
    }
}
