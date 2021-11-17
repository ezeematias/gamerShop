namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoicing")]
    public partial class Invoicing
    {
        [Key]
        public int IdInvoicing { get; set; }

        public int IdInvoice { get; set; }

        [Required]
        [StringLength(20)]
        public string DNI { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
