namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryProduct")]
    public partial class CategoryProduct
    {
        [Key]
        public int IdCategoryProduct { get; set; }

        public int IdProduct { get; set; }

        public int IdCategory { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}
