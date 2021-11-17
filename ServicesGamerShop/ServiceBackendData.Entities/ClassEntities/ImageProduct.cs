namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageProduct")]
    public partial class ImageProduct
    {
        [Key]
        public int IdImageProduct { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Url { get; set; }

        public bool IsMain { get; set; }

        public virtual Product Product { get; set; }
    }
}
